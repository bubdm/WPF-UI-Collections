using System.Collections.Generic;
using System.Linq;


namespace _02_WPFTreeView
{
    /// <summary>
    /// A helper class to query information about directories
    /// </summary>

    public static class DirectoryStructure
    {
        #region Get the logical drives
        /// <summary>
        /// Gets all logical drives on the computer.
        /// </summary>
        /// <returns></returns>
        public static List<DirectoryItem> GetLogicalDrives()
        {
            // Get every logical drive on the local machine
            return System.IO.Directory.GetLogicalDrives().Select(drive => new DirectoryItem { FullPath = drive, Type = DirectoryItemType.Drive }).ToList();
        }
        #endregion

        /// <summary>
        /// Get the diretories top-level contents(files and folders)
        /// </summary>
        /// <param name="fullPath">The full name of the contents</param>
        /// <returns></returns>
        public static List<DirectoryItem> GetDirectoryContents(string fullPath)
        {
            // create a empty list of directories
            var items = new List<DirectoryItem>();
            #region Get Folders

            // Try and get directories from the folder
            // ignoring any issues doing so
            try
            {
                var dirs = System.IO.Directory.GetDirectories(fullPath);

                if (dirs.Length > 0)
                {
                    items.AddRange(dirs.Select(dir=> new DirectoryItem { FullPath = dir, Type =DirectoryItemType.Folder}));
                }
            }
            catch { }
           
            #endregion

            #region Get Files

            // Try and get files from the folder
            // ignoring any issues doing so
            try
            {
                var files = System.IO.Directory.GetFiles(fullPath);

                if (files.Length > 0)
                {
                    items.AddRange(files.Select(file => new DirectoryItem { FullPath = file, Type=DirectoryItemType.File}));
                }
            }
            catch { }
            return items;
            #endregion
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
