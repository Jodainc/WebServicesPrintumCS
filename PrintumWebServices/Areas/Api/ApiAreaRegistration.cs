using System.Web.Mvc;

namespace PrintumWebServices.Areas.Api
{
    public class ApiAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Api";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
           
            context.MapRoute(
                "ProductQuery", "Api/Product", new {controller="Product",action = "ProductQuery"}
                );
        }
        
}
}