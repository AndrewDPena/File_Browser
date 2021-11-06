using System.Collections.Generic;
using File_Browser.Interfaces;
using File_Browser.Models;
using Xamarin.Forms;

namespace File_Browser.ViewModels
{
    public class ListPageViewModel :ViewModelBase
    {
        private List<FileModel> _fileList;
        public List<FileModel> FileList
        {
            get => _fileList;
            set => SetProperty(ref _fileList, value);
        }
        private readonly IFileManager _fileManager;

        public ListPageViewModel()
        {
            _fileManager = DependencyService.Get<IFileManager>();
            FileList = _fileManager.GetRootFiles();
        }
    }
}