using AutoMapper;
using NHPApi.Models;
using NHPApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace NHPApiSec
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<OITM, ProductVm>()
                .ForMember(user => user.SapCode, map => map.MapFrom(p => p.ItemCode))
                .ForMember(user => user.Description, map => map.MapFrom(p => p.ItemName))
                .ForMember(user => user.ProductName, map => map.MapFrom(p => p.ItemName))
                 .ForMember(user => user.uom, map => map.MapFrom(p => p.InvntryUom))
                 .ForMember(user => user.Price, map => map.MapFrom(p => p.PricingPrc))
                .ForMember(user => user.Quantity, map => map.MapFrom(p => p.OnHand));


                cfg.CreateMap<ProductVm, OITM>()
                .ForMember(user => user.ItemCode, map => map.MapFrom(p => p.SapCode))
                .ForMember(user => user.ItemName, map => map.MapFrom(p => p.Description))
                 .ForMember(user => user.InvntryUom, map => map.MapFrom(p => p.uom))
                 .ForMember(user => user.PricingPrc, map => map.MapFrom(p => p.Price))
                .ForMember(user => user.OnHand, map => map.MapFrom(p => p.Quantity));


                cfg.CreateMap<OCRD, CustomerVm>()
                .ForMember(user => user.user_id, map => map.MapFrom(p => p.CardCode))
                .ForMember(user => user.Company, map => map.MapFrom(p => p.CardName))
                .ForMember(user => user.Email, map => map.MapFrom(p => p.E_Mail))
                .ForMember(user => user.Phone, map => map.MapFrom(p => p.Phone1));

                cfg.CreateMap<CustomerVm, OCRD>()
                .ForMember(user => user.CardCode, map => map.MapFrom(p => p.user_id))
                .ForMember(user => user.CardName, map => map.MapFrom(p => p.Company))
                 .ForMember(user => user.E_Mail, map => map.MapFrom(p => p.Email));
            });
        }
    }
}
