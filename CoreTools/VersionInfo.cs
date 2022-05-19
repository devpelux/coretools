﻿namespace CoreTools
{
    /// <summary>
    /// Provides version informations about the <see cref="CoreTools"/> package.
    /// </summary>
    public static class VersionInfo
    {
        /// <summary>
        /// Gets the current <see cref="CoreTools"/> version code.
        /// </summary>
        public static string VersionCode => typeof(VersionInfo).Assembly.GetName().Version?.ToString() ?? string.Empty;
    }
}
