using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_Browser.ViewModels;
using Xamarin.Forms;

namespace File_Browser
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            var vm = new ListPageViewModel();  
            BindingContext = vm; 
            InitializeComponent();
        }
    }
}