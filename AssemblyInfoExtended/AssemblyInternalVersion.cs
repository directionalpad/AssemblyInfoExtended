using System;

namespace System.Reflection
{
    /// <summary>
    /// Defines additional version information for the assembly manifest.
    /// </summary>
    public class AssemblyInternalVersion
    {
        public string _version;

        /// <summary>
        /// Initializes a new instance of the <see cref="AssemblyInternalVersion"/> class, specifying the internal file version.
        /// </summary>
        /// <param name="version">The internal version number of the attributed assembly.</param>
        public AssemblyInternalVersion(string version) { _version = version;  }
    }
}
