using System;
using Xamarin.Forms;

namespace File_Browser.Models
{
    public class FileModel
    {
        public string FullPath { get; set; }
        
        public string FileName { get; set; }

        public string ImageName => IsDirectory ? "icfolder" : "icfile";
        
        public DateTime LastEdited { get; set; }
        
        public bool IsDirectory { get; set; }
        
        public long Size { get; set; }
    }
}