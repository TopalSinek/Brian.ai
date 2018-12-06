using Brian.Ai.WebApp.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Brian.Ai.Tests.Controllers
{
    public class HomeControllerTest
    {

        [Fact]
        public void IndexTest()
        {
            HomeController controller = new HomeController();
            ViewResult result = (ViewResult)controller.Index();
            Assert.Single(result.ViewData);
            Assert.Equal("Your application Index page.", result.ViewData["Message"]);
        }

        //[Fact]
        //public void ErrorTest()
        //{
        //    HomeController controller = new HomeController();
        //    ViewResult result = (ViewResult)controller.Error();
        //    Assert.Single(result.ViewData);
        //    Assert.Equal("We've encountered an error :(", result.ViewData["Message"]);
        //}

        [Fact]
        public void AboutTest()
        {
            HomeController controller = new HomeController();
            ViewResult result = (ViewResult)controller.About();
            Assert.Single(result.ViewData);
            Assert.Equal("Your application description page.", result.ViewData["Message"]);
        }

        [Fact]
        public void ContactTest()
        {
            HomeController controller = new HomeController();
            ViewResult result = (ViewResult)controller.Contact();
            Assert.Single(result.ViewData);
            Assert.Equal("Your contact page.", result.ViewData["Message"]);
        }
    }
}
