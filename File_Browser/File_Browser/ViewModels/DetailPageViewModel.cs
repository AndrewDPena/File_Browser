using File_Browser.Models;

namespace File_Browser.ViewModels
{
    public class DetailPageViewModel : ViewModelBase
    {
        private FileModel _file;
        public FileModel File
        {
            get => _file;
            set
            {
                SetProperty(ref _file, value);
            }
        }

        public DetailPageViewModel()
        {
            
        }
    }
}