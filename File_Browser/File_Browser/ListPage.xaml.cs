using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_Browser.Models;
using File_Browser.ViewModels;
using Xamarin.Forms;

namespace File_Browser
{
    public partial class ListPage : ContentPage
    {
        private readonly ListPageViewModel _vm;
        public ListPage()
        {
            _vm = new ListPageViewModel("");  
            BindingContext = _vm; 
            InitializeComponent();
            
            ListView.ItemSelected += (e, s) =>
            {
                if (s.SelectedItem is FileModel file)
                {
                    if (file.IsDirectory)
                    {
                        _vm.CreateNewListPage(file.FileName);
                    }
                    else
                    {
                        _vm.CreateNewDetailPage(file);
                    }
                    //vm.CreateDetailPage(cat);
                }
                ((ListView)e).SelectedItem = null; ; 
            };
        }

        public ListPage(string path) : this()
        {
            _vm.LoadNewDirectory(path);
        }
    }
}