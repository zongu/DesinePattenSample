
namespace ObserverPattern.Tests
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ObserverPattern.Model;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IObserverable stanly = new Twitcher();
            stanly.ObserverableName = "史丹利";

            IObserver carter = new TwitchUser(stanly);
            stanly.Add(carter);

            IObserver gear = new TwitchUser(stanly);
            stanly.Add(gear);

            var notifyMsg = stanly.Notify();
            Assert.IsNotNull(notifyMsg);
            Assert.AreEqual(notifyMsg.Count(), 2);
            Assert.AreEqual(notifyMsg.First(), "史丹利 Online");

            stanly.ObserverableName = "肥豬王-史丹利";
            notifyMsg = stanly.Notify();
            Assert.IsNotNull(notifyMsg);
            Assert.AreEqual(notifyMsg.Count(), 2);
            Assert.AreEqual(notifyMsg.First(), "肥豬王-史丹利 Online");

            stanly.Del(gear);
            notifyMsg = stanly.Notify();
            Assert.IsNotNull(notifyMsg);
            Assert.AreEqual(notifyMsg.Count(), 1);
        }
    }
}
