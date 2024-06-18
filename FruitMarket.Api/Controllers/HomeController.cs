//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace FruitMarket.Api.Controllers
{
    public class HomeController : RESTFulController
    {
        public ActionResult<string> Get() =>
             Ok("Helo,Mario The Princes Another Castle");
    }
}
