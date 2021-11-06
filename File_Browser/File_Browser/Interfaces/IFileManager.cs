using System.Collections.Generic;
using File_Browser.Models;

namespace File_Browser.Interfaces
{
    public interface IFileManager
    {
        List<FileModel> GetRootFiles();
    }
}