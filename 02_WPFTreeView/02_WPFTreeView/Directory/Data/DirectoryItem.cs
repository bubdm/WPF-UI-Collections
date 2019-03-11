
namespace _02_WPFTreeView
{
    /// <summary>
    /// Information about a diretory item such as a drive, a file or a folder
    /// </summary>
    public class DirectoryItem
    {
        /// <summary>
        /// The type of this item
        /// </summary>
        public DirectoryItemType Type { get; set; }
        /// <summary>
        /// The absolute path of this item
        /// </summary>
        public string FullPath { get; set; }

        /// <summary>
        /// The name of this directory item
        /// </summary>
        public string Name => this.Type==DirectoryItemType.Drive? this.FullPath : DirectoryStructure.GetFileFolderName(this.FullPath);
    }
}
