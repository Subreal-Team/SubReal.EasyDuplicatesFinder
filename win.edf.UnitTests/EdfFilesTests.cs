using NUnit.Framework;
using SubReal.EasyDuplicateFinder;

namespace win.edf.UnitTests
{
    [TestFixture]
    internal class EdfFilesTests
    {
        [Test]
        public void IsSourceFolderExists_BadFolderPath_ReturnsFalse()
        {
            var edf = new EdfFiles();
            var result = edf.IsSourceFolderExists(@"Z:\-FOlderISNOTEXIST");
            Assert.False(result);
        }

        [Test]
        public void IsSourceFolderExists_ExistedFolderPath_ReturnsTrue()
        {
            var edf = new EdfFiles();
            var result = edf.IsSourceFolderExists(@"C:\Windows");
            Assert.True(result);
        }
    }
}
