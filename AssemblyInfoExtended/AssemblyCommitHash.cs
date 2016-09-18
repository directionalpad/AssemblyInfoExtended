using System;

namespace System.Reflection
{
    /// <summary>
    /// Defines a commit hash attribute for the assembly manifest.
    /// </summary>
    public class AssemblyCommitHash
    {
        public string _hash;

        /// <summary>
        /// Initializes a new instance of the <see cref="AssemblyCommitHash"/> class with the commit hash of the assembly being attributed.
        /// </summary>
        /// <param name="hash">The commit hash of the attributed assembly.</param>
        public AssemblyCommitHash(string hash) { _hash = hash;  }
    }
}
