using CoreTools.Core;
using System.IO;

namespace CoreTools
{
    /// <summary>
    /// Provides a set of system utilities.
    /// </summary>
    public static class SystemUtils
    {
        /// <summary>
        /// Gets the current application executing file.
        /// </summary>
        /// <returns>Current application executing file.</returns>
        public static FileInfo GetExecutingFile() => new(InternalMethods.GetExecutablePath());

        /// <summary>
        /// Gets the current application executing directory.
        /// </summary>
        /// <returns>Current application executing directory.</returns>
        /// <exception cref="DirectoryNotFoundException"></exception>
        public static DirectoryInfo GetExecutingDirectory()
        {
            if (GetExecutingFile().Directory is DirectoryInfo dir) return dir;
            else throw new DirectoryNotFoundException("Unable to get the directory of the current application executable.");
        }
    }
}
