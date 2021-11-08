using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_Browser.Models;
using File_Browser.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace File_Browser
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        private readonly FileModel _file;
        public DetailPage(FileModel file)
        {
            this._file = file;
            var vm = new DetailPageViewModel
            {
                File = _file
            };
            BindingContext = vm;  
            InitializeComponent();
        }
    }
}