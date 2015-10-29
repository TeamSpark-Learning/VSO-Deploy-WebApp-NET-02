using System.Web.Routing;
using MvcRouteTester;
using NUnit.Framework;
using TeamSpark.Demo02.Web.Controllers;

namespace TeamSpark.Demo02.Web.Test.Routes
{
	[TestFixture]
	public class HomeRoutesTest
	{
		private RouteCollection _routes;

		[TestFixtureSetUp]
		public void SetupTestFixture()
		{
			_routes = new RouteCollection();
			RouteConfig.RegisterRoutes(_routes);

			RouteAssert.UseAssertEngine(new NunitAssertEngine());
		}

		[Test]
		public void DefaultRouteTest()
		{
			_routes.ShouldMap("/").To<HomeController>(i => i.Index());
		}

		[Test]
		public void HomeDefaultRouteTest()
		{
			_routes.ShouldMap("/home").To<HomeController>(i => i.Index());
		}

		[Test]
		public void HomeIndexRouteTest()
		{
			_routes.ShouldMap("/home/index").To<HomeController>(i => i.Index());
		}

		[Test]
		public void HomeAboutRouteTest()
		{
			_routes.ShouldMap("/home/about").To<HomeController>(i => i.About());
		}

		[Test]
		public void HomeContactRouteTest()
		{
			_routes.ShouldMap("/home/contact").To<HomeController>(i => i.Contact());
		}
	}
}
