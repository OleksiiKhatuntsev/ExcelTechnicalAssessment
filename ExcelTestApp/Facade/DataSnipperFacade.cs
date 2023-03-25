namespace ExcelTestApp.Facade
{
    public class DataSnipperFacade : FacadeBase
    {
        public void ClickAddDocumentAndSelectFile(string pathToFile)
        {
            DataSnipperToolBarPage.ImportDocumentsButton.Click();

            if (DataSnipperToolBarPage.DocumentsButton.WaitForDisplayed())
            {
                DataSnipperToolBarPage.DocumentsButton.Click();
            }
            AddDocumentModalWindowPage.SearchFileTextBox.SetText(pathToFile);
            AddDocumentModalWindowPage.OpenButton.Click();
        }

        public void SearchAndSnip(string textToSearch)
        {
            DataSnipperDocumentViewerToolbarPage.SearchTextBox.SetTextAndPressEnter(textToSearch);
            DataSnipperDocumentViewerToolbarPage.SnipWithPageNumber(1).Click();
        }
    }
}
