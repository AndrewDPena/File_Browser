using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using File_Browser.Interfaces;
using File_Browser.Models;
using Xamarin.Forms;

namespace File_Browser.ViewModels
{
    public class ListPageViewModel :ViewModelBase
    {
        private List<FileModel> _fileList;
        private List<FileModel> _allFiles;
        private string _filterString;
        public List<FileModel> FileList
        {
            get => _fileList;
            set => SetProperty(ref _fileList, value);
        }

        public string FilterString
        {
            get => _filterString;
            set {
            SetProperty(ref _filterString, value);
            Filter();
            }
        }
        private readonly IFileManager _fileManager;

        public ListPageViewModel(string path)
        {
            _fileManager = DependencyService.Get<IFileManager>();
            _allFiles = FileList = _fileManager.GetRootFiles(path);
        }
        
        public async void CreateNewListPage(string path)
        {
            await App.NavigationService.NavigateAsync("ListPage", path);
        }public async void CreateNewDetailPage(FileModel file)
        {
            await App.NavigationService.NavigateAsync("DetailPage", file);
        }

        public void LoadNewDirectory(string path)
        {
            _allFiles = FileList = _fileManager.GetRootFiles(path);
        }

        private bool FuzzySearch(string given, string searchPattern)
        {
            if (given == null || searchPattern == null) return true;
            var s = given.ToLower();
            var newPattern = string.Join(".*", searchPattern.ToLower().ToCharArray());

            return Regex.IsMatch(s, newPattern);
        }
        private void Filter()
        {
            FileList = _allFiles.Where(s => FuzzySearch(s.FileName, _filterString)).ToList();
        }
    }
}