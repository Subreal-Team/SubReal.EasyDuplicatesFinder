using NUnit.Framework;
using SubReal.EasyDublicateFinder;

namespace win.edf.UnitTests
{
    [TestFixture]
    class EdfFilesTests
    {
        [Test]
        public void IsSourceFolderExists_BadFolderPath_ReturnsFalse()
        {
            EdfFiles edf = new EdfFiles();
            bool result = edf.IsSourceFolderExists(@"Z:\-FOlderISNOTEXIST");
            Assert.False(result);
        }

        [Test]
        public void IsSourceFolderExists_ExistedFolderPath_ReturnsTrue()
        {
            EdfFiles edf = new EdfFiles();
            bool result = edf.IsSourceFolderExists(@"C:\Windows");
            Assert.True(result);
        }
    }
}
