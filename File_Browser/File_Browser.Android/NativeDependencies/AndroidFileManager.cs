using System;
using System.Collections.Generic;
using System.Linq;
using Android.Content;
using File_Browser.Interfaces;
using File_Browser.Models;
using Java.IO;
using Environment = Android.OS.Environment;

namespace File_Browser.Android.NativeDependencies
{
    public class AndroidFileManager : IFileManager
    {
        private Context _context;
        
        public AndroidFileManager(Context context)
        {
            _context = context;
        }
        
        public List<FileModel> GetRootFiles(string path)
        {
            var files = new List<FileModel>();
            var rootDir = Environment.GetExternalStoragePublicDirectory(path);
            if (rootDir != null)
            {
                var dirListFiles = rootDir.ListFiles();
                if (dirListFiles != null)
                {
                    files = (from file in dirListFiles select ToFileModel(file)).ToList();
                }
            }
            return files;
        }

        private FileModel ToFileModel(File file)
        {
            var start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var date = start.AddMilliseconds(file.LastModified()).ToLocalTime();
            var fileModel = new FileModel
            {
                FileName = file.Name,
                FullPath = file.AbsolutePath,
                LastEdited = date,
                IsDirectory = file.IsDirectory
            };
            return fileModel;
        }
    }
}