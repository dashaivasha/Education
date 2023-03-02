using System.IO;
using userinyerfaceTests.Constants;

namespace userinyerfaceTests.PageObjects.Utils
{
    internal class PhotoFile
    {
        public static string GetFullPath()
        {
            var fileName = FilePaths.PhotoAvatar;
            var path = Path.GetFullPath(fileName);

            return path;
        }
    }
}
