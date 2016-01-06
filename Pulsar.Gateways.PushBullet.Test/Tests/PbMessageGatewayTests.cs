using NUnit.Framework;

namespace Pulsar.Gateways.PushBullet.Test.Tests
{
    [TestFixture]
    public class PbMessageGatewayTests
    {
        [Test]
        [Ignore("We do not want the pbDevice to go crazy if this test is executed")]
        public void Given_PushNote_NoteReturned()
        {
            var note = new PbMessageGateway().PushNoteToWindowsPhone("Test", "Test");
            Assert.IsNotNull(note);
        }
    }
}