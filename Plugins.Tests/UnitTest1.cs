
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Plugins.Tests
{
    [TestClass]
    public class AccountPluginTests
    {/*
        [TestMethod]
        [TestCategory("Unit Test")]
        public void TestAccountPlugin()
        {
            using (var pipeline = new PluginPipeline(
                FakeMessageNames.Create, FakeStages.PreOperation, new Entity("contact")))
            {
                var plugin = new AccountPlugin();

                try
                {
                    pipeline.Execute(plugin);
                    Assert.Fail("Exception not thrown");
                }
                catch (InvalidPluginExecutionException ex)
                {
                    Assert.IsTrue(ex.Message.Contains("Working on it")
                        , "Must throw exeception");
                }
            }
        }*/
    }
}
