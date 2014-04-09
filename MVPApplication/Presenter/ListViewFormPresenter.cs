using System.IO;
using System.Linq;
using MVPApplication.Model;
using MVPApplication.View;

namespace MVPApplication.Presenter
{
    public class ListViewFormPresenter
    {
        private readonly IView _listView;
        private readonly IDataModel _model;

        public ListViewFormPresenter(IView pView, IDataModel pModel)
        {
            _listView = pView;
            _model = pModel;

            _listView.MoveToSourceRequested += _listView_DestinationUpdated;
            _listView.MoveToDestinationRequested += _listView_SourceListUpdated;
            _listView.AllCleared += _listView_AllCleared;
            _listView.FolderSelected += _listView_FolderSelected;
        }

        void _listView_FolderSelected(object sender, StringEventArgs e)
        {
            if (_model.SourceFiles.ContainsKey(e.value)) return;
            
            var files = Directory.GetFiles(e.value);
            _model.SourceFiles.Add(e.value, files.ToList());
            _listView.UpdateSource(_model.SourceFiles);
        }

        void _listView_AllCleared(object sender, System.EventArgs e)
        {
            _model.SourceFiles.Clear();
            _model.DestinationFiles.Clear();
            _listView.UpdateSource(_model.SourceFiles);
            _listView.UpdateDestination(_model.DestinationFiles);
        }

        void _listView_SourceListUpdated(object sender, StringListEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        void _listView_DestinationUpdated(object sender, StringListEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
