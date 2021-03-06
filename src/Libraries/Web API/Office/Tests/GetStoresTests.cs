// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Office.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Office.Tests
{
    public class GetStoresTests
    {
        public static GetStoresController Fixture()
        {
            GetStoresController controller = new GetStoresController(new GetStoresRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetStoresController.Annotation());
            Assert.NotNull(actual);
        }
    }
}