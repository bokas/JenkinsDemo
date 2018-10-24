using System;
using JenkinsDemo.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace JenkisDemo.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controller = new HomeController();
            Assert.IsType<ViewResult>(controller.Index());
        }
    }
}