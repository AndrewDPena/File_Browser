using System;

namespace File_Browser.Models
{
    public class FileModel
    {
        public string FullPath { get; set; }
        
        public string FileName { get; set; }
        
        public DateTime LastEdited { get; set; }
        
        public bool IsDirectory { get; set; }
    }
}