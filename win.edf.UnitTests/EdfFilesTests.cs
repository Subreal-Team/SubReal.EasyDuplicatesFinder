using System.IO;
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
            var edf = new EdfFiles(@"Z:\-FOlderISNOTEXIST");
            var result = edf.GetFiles();
            Assert.False(result);
        }

        [Test]
        public void IsSourceFolderExists_ExistedFolderPath_ReturnsTrue()
        {
            var edf = new EdfFiles(Directory.GetCurrentDirectory());
            var result = edf.GetFiles();

            Assert.True(result);
            Assert.AreEqual(17, edf.FullListFiles.Count);
        }
    }
}
