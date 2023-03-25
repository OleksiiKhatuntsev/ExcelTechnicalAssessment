using ExcelTestApp.Pages;

namespace ExcelTestApp.Facade
{
    public abstract class FacadeBase
    {
        private protected AddDocumentModalWindowPage AddDocumentModalWindowPage { get; }

        private protected DataSnipperDocumentViewerToolbarPage DataSnipperDocumentViewerToolbarPage { get; }

        private protected DataSnipperToolBarPage DataSnipperToolBarPage { get; }

        private protected ExcelGridPage ExcelGridPage { get; }

        private protected HomePage HomePage { get; }

        private protected DataSnipperGettingStartedWindowPage DataSnipperGettingStartedWindowPage { get; }

        protected FacadeBase()
        {
            AddDocumentModalWindowPage = new AddDocumentModalWindowPage();
            DataSnipperDocumentViewerToolbarPage = new DataSnipperDocumentViewerToolbarPage();
            DataSnipperToolBarPage = new DataSnipperToolBarPage();
            ExcelGridPage = new ExcelGridPage();
            HomePage = new HomePage();
            DataSnipperGettingStartedWindowPage = new DataSnipperGettingStartedWindowPage();
        }

    }
}
