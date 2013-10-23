using System;
using System.Collections.Generic;

namespace Converter.Services.Interfaces
{
    /// <summary>
    /// This provides interfaces to the BaseConverterService class.
    /// </summary>
    public interface IBaseConverterService : IDisposable
    {
        /// <summary>
        /// Gets the full-width unicode character ranges in integer format.
        /// </summary>
        IList<int> FullWidthUnicodeRanges { get; }

        /// <summary>
        /// Gets the ASCII character ranges in integer format.
        /// </summary>
        IList<int> AsciiCodeRanges { get; }
    }
}