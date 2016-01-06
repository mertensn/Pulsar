using System.Transactions;
using NUnit.Framework;

namespace Pulsar.Test
{
    public class ScopedTestBase
    {
        private TransactionScope _scope;

        [SetUp]
        public void StartTransaction()
        {
            _scope = new TransactionScope();
        }

        [TearDown]
        public void RollbackTransaction()
        {
            _scope.Dispose();
        }
    }
}
