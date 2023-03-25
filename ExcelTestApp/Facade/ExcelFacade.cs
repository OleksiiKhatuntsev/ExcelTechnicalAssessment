namespace ExcelTestApp.Facade
{
    public class ExcelFacade : FacadeBase
    {
        public void CreateFileAndOpenDataSnipperTab()
        {
            HomePage.BlankWorkbookButton.Click();
            DataSnipperToolBarPage.DataSnipperNavigationButton.Click();
            DataSnipperGettingStartedWindowPage.GettingStartedLabel.WaitForDisplayed();
        }

        public string GetDataFromCell(string columnLetter = "A", int rowId = 1)
        {
            return ExcelGridPage.ExcelCellByColumnAndRow(columnLetter, rowId).GetText();
        }
        
    }
}
