

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _02_WPFTreeView
{
    /// <summary>
    /// A helper class to query information about directories
    /// </summary>

    public static class DirectoryStructure
    {
        public static List<DirectoryItem> GetLogicalDrives()
        {
            // Get every logical drive on the local machine
            return Directory.GetLogicalDrives().Select(drive => new DirectoryItem { FullPath = drive, Tpye = DirectoryItemType.Drive }).ToList();
        }


        #region Get file folder name
        /// <summary>
        /// Find the file or folder from a full path
        /// </summary>
        /// <param name="path">the full path</param>
        /// <returns></returns>
        public static string GetFileFolderName(string path)
        {
            // C:\something\a folder
            // C:\something\file.png

            // if we have no path, return empty
            if (string.IsNullOrEmpty(path))
                return string.Empty;

            // Make all slashes back slashes
            var normalizedPath = path.Replace('/', '\\');

            // Find the last backslash in the path
            var lastIndex = normalizedPath.LastIndexOf('\\');

            // if we don't find a backslash, return the path itself
            if (lastIndex <= 0)
                return path;
            else
                // return the name after last back slash
                return path.Substring(lastIndex + 1);
        }
        #endregion
    }
}
