using CoreTools.Core.Services;
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
        public static DirectoryInfo? GetExecutingDirectory() => GetExecutingFile().Directory;
    }
}
