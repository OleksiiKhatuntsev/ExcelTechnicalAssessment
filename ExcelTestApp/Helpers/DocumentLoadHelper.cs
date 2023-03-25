using ExcelTestApp.Constants;

namespace ExcelTestApp.Helpers
{
    public static class DocumentLoadHelper
    {
        public static string GetFullPathOfTestDocument(string documentName)
        {
            return Path.Combine(Environment.CurrentDirectory, PathConstants.TestDataFolder, documentName);
        }
    }
}