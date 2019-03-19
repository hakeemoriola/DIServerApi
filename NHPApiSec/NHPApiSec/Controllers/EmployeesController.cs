using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;
using System.Web.Http.Results;
using NHPApi.Models;
using System.Web.Http;
using System;
using SAPbobsCOM;
using System.Web.Mvc;
using NHPApi.ViewModels;
using NHPApiSec.ViewModels;

namespace SAPAPI.Controllers
{
    [System.Web.Http.Authorize]
    [System.Web.Http.RoutePrefix("api/[Controller]")]
    public class EmployeesController : BaseController
    {
        // POST  sales order
        [System.Web.Http.HttpPost]
        public IHttpActionResult SaveEmployee([FromBody]EmployeeVm oItem)
        {
            Connect();
            try
            {
                int oGRNLineCount = oItem.Lines.Count;

                Documents documents = (Documents)oCompany.GetBusinessObject(BoObjectTypes.oEmployeesInfo);
                documents.CardCode = oItem.user_id;
                documents.HandWritten = SAPbobsCOM.BoYesNoEnum.tNO;
                documents.DocDate = (DateTime)oItem.DateCreated;
                documents.DocDueDate = (DateTime)oItem.DateCreated;
                documents.BPL_IDAssignedToInvoice = 3;

                if (oGRNLineCount > 0)
                {
                    foreach (OrderLineVm row1 in oItem.Lines)
                    {
                        documents.Lines.ItemCode = row1.SapCode;
                        documents.Lines.ItemDescription = row1.ProductName;
                        documents.Lines.Price = row1.Price;
                        documents.Lines.Quantity = row1.Quantity;
                        documents.Lines.LineTotal = row1.Amount;
                        documents.Lines.Add();
                    }
                }
                int resp = documents.Add();

                if (resp != 0)
                {
                    return Json(new Error() { ErrorCode = oCompany.GetLastErrorCode().ToString(), Description = oCompany.GetLastErrorDescription() });
                    //return StatusCode(System.Net.HttpStatusCode.NotFound);
                }
                return StatusCode(System.Net.HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                oCompany.Disconnect();
                //return Json(new Error() { ErrorCode = ex.Source, Description = ex.Message });
                return Json(new Error() { ErrorCode = oCompany.GetLastErrorCode().ToString(), Description = oCompany.GetLastErrorDescription() });
                //return StatusCode(System.Net.HttpStatusCode.NotFound);
            }
        }
    }
}