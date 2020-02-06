
namespace ChainOfResponsibilityPattern.Tests
{
    using ChainOfResponsibilityPattern.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class AbsenseFormHelperTests
    {
        [TestMethod]
        public void TeamLeaderNormalCaseTest()
        {
            var result = AbsenseFormHelper.ByNormalCase("Carter", 3);
            Assert.AreEqual(result.Signer, SignerType.TeamLeader);
            Assert.AreEqual(result.Result, ResultType.Success);
        }

        [TestMethod]
        public void TeamLeaderDesignPattenCaseTest()
        {
            var result = AbsenseFormHelper.ByDesignPattenCase("Carter", 3);
            Assert.AreEqual(result.Signer, SignerType.TeamLeader);
            Assert.AreEqual(result.Result, ResultType.Success);
        }

        [TestMethod]
        public void ManagerNormalCaseTest()
        {
            var result = AbsenseFormHelper.ByNormalCase("Carter", 7);
            Assert.AreEqual(result.Signer, SignerType.Manager);
            Assert.AreEqual(result.Result, ResultType.Success);
        }

        [TestMethod]
        public void ManagerDesignPattenCaseTest()
        {
            var result = AbsenseFormHelper.ByDesignPattenCase("Carter", 7);
            Assert.AreEqual(result.Signer, SignerType.Manager);
            Assert.AreEqual(result.Result, ResultType.Success);
        }

        [TestMethod]
        public void BossNormalCaseTest()
        {
            var result = AbsenseFormHelper.ByNormalCase("Carter", 30);
            Assert.AreEqual(result.Signer, SignerType.Boss);
            Assert.AreEqual(result.Result, ResultType.Success);
        }

        [TestMethod]
        public void BossDesignPattenCaseTest()
        {
            var result = AbsenseFormHelper.ByDesignPattenCase("Carter", 30);
            Assert.AreEqual(result.Signer, SignerType.Boss);
            Assert.AreEqual(result.Result, ResultType.Success);
        }
    }
}
