using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BankController.Controllers
{
    public class BankController : Controller
    {
        [Route("/")]
        public string Index()
        {
            Response.StatusCode = 200;
            return $"Welcome To The Best Bank {Response.StatusCode}";
        }

        [Route("/account-details")]
        public JsonResult GetAccountDetails()
        {

            SampleJsonClass exampleAccount = new SampleJsonClass
            {
                accountNumber = 1001,
                accountHolderName = "Example Name",
                currentBalance = 5000
            };

            return Json(JsonSerializer.Serialize(exampleAccount));
        }

        [Route("/account-statement")]
        public VirtualFileResult GetAccountStatement()
        {
            return new VirtualFileResult("/PDF/dummy.pdf", "application/pdf");
        }
    }
}
