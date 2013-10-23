using System;
using System.Collections.Generic;

namespace Converter.Services.Interfaces
{
    /// <summary>
    /// This provides interfaces to the ConverterHelper class.
    /// </summary>
    public interface IConverterHelper : IDisposable
    {
        #region Properties

        /// <summary>
        /// Gets the list of full-width unicode character ranges.
        /// </summary>
        IList<string> FullWidthUnicodeRanges { get; }

        /// <summary>
        /// Gets the list of ASCII character ranges.
        /// </summary>
        IList<string> AsciiCodeRanges { get; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Parses the full-width unicode character ranges in integer format.
        /// </summary>
        /// <returns>Returns the full-width unicode character ranges in integer format.</returns>
        IList<int> ParseFullWidthUnicodeRanges();

        /// <summary>
        /// parses the ASCII character ranges in integer format.
        /// </summary>
        /// <returns>Returns the ASCII character ranges in integer format.</returns>
        IList<int> ParseAsciiCodeRanges();

        #endregion Methods
    }
}