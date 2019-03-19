using System.Linq;
using System.Collections.Generic;
using System.Web.Http.Results;
using System;
using SAPbobsCOM;
using System.Web.Http;
using NHPApi.ViewModels;
using NHPApiSec.Models;
using NHPApi.Models;
using System.Data.SqlClient;
using System.Configuration;
using AutoMapper;

namespace SAPAPI.Controllers
{
    [Authorize]
    [RoutePrefix("api/[Controller]")]
    public class BusinessPartnersController : BaseController
    {
        [HttpGet]
        public JsonResult<List<OCRD>> Get()
        {
            using (var context = new NHPApi.Models.SAPAPIContext())
            {
                var ocrds = context.OCRDs.SqlQuery("SELECT * FROM OCRD").ToList();
                return Json(ocrds);
            }
        }

        // api/values/5
        //public JsonResult<List<OCRD>> Get(string cardcode, string cardtype)
        //{
        //    using (var context = new NHPApi.Models.SAPAPIContext())
        //    {
        //        var ocrds = context.OCRDs.SqlQuery("SELECT * FROM OCRD where CardCode = '" + cardcode + "' AND CardType= '" + cardtype +"'").ToList();

        //        return Json(ocrds);
        //    }
        //}
        [HttpGet]
        public JsonResult<List<CustomerVm>> GetCustomerByEmail(string email)
        {
            using (var context = new NHPApi.Models.SAPAPIContext())
            {
                var ocrds = context.OCRDs.SqlQuery("SELECT * FROM OCRD where E_Mail = '" + email + "' AND CardType= 'C' ").ToList();
                var org = Mapper.Map<List<OCRD>, List<CustomerVm>>(ocrds);
                return Json(org);
            }
        }


        // POST api/values
        [HttpPost]
        public IHttpActionResult SaveCustomer([FromBody]CustomerVm oItem)
        {
            Connect();
            try
            {
                BusinessPartners documents = (BusinessPartners)oCompany.GetBusinessObject(BoObjectTypes.oBusinessPartners);
                string CardCode = GetCardCode();
                documents.CardCode = CardCode ;
                documents.CardName = oItem.Company;
                documents.Address = oItem.Address;
                documents.EmailAddress = oItem.Email;
                documents.Phone1 = oItem.Phone;
                //documents.ContactPerson = oItem.Firstname+", " + oItem.Lastname;
                documents.City = oItem.City;
                documents.CardType = BoCardTypes.cCustomer;
                documents.Country = "NG";
                int resp = documents.Add();

                if (resp != 0)
                {
                    //return Json(new Error() { ErrorCode = oCompany.GetLastErrorCode().ToString(), Description = oCompany.GetLastErrorDescription() });
                    return StatusCode(System.Net.HttpStatusCode.NotFound);
                }

                documents = (BusinessPartners)oCompany.GetBusinessObject(BoObjectTypes.oBusinessPartners);
                if (documents.GetByKey(CardCode))
                {
                    if (documents.ContactEmployees.Count > 0)
                    {
                        documents.ContactEmployees.Add();
                    }
                    else
                    {
                        if (documents.ContactEmployees.Name != "")
                            documents.ContactEmployees.Add();
                    }
                    documents.ContactEmployees.Name = oItem.Firstname + ", " + oItem.Lastname;
                    documents.ContactEmployees.LastName = oItem.Lastname;
                    documents.ContactEmployees.FirstName = oItem.Firstname;
                    documents.ContactEmployees.Phone1 = oItem.Phone;
                    documents.ContactEmployees.E_Mail = oItem.Email;
                    documents.ContactEmployees.Position = "";
                    int chk = documents.Update(); //used BP.Add();
                    if (chk == 0)
                    {
                    }
                }
                return StatusCode(System.Net.HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                oCompany.Disconnect();
                return Json(new Error() { ErrorCode = oCompany.GetLastErrorCode().ToString(), Description = oCompany.GetLastErrorDescription() });
               //return StatusCode(System.Net.HttpStatusCode.NotFound);
            }
        }

        private string GetCardCode()
        {
            string cardCode = string.Empty;
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["SAPAPIContext"].ConnectionString))
            {
                con.Open();
                var cmd = con.CreateCommand();
                cmd.CommandText = @"SELECT 'C' + RIGHT('0000'+CAST(MAX(CAST(RIGHT(CardCode, LEN(CardCode) - 1) AS INT)) + 1 AS VARCHAR(4)),4) CardCode
                                    FROM         OCRD
                                    WHERE     (CardType = 'C') AND (CardCode LIKE '%C%') AND (CardCode <> 'C99999')";
                cardCode = cmd.ExecuteScalar().ToString();
            }
            return cardCode;
        }
    }
}