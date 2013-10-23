using Converter.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;

namespace Converter.Services
{
    /// <summary>
    /// This represents the converter helper entity.
    /// </summary>
    public class ConverterHelper : IConverterHelper
    {
        #region Properties

        private IList<string> _fullWidthUnicodeRanges;

        /// <summary>
        /// Gets the list of full-width unicode character ranges.
        /// </summary>
        public IList<string> FullWidthUnicodeRanges
        {
            get
            {
                if (this._fullWidthUnicodeRanges == null || !this._fullWidthUnicodeRanges.Any())
                    this._fullWidthUnicodeRanges = Split(ConfigurationManager.AppSettings["FullWidthUnicodeRanges"], ",");
                return this._fullWidthUnicodeRanges;
            }
        }

        private IList<string> _asciiCodeRanges;

        /// <summary>
        /// Gets the list of ASCII character ranges.
        /// </summary>
        public IList<string> AsciiCodeRanges
        {
            get
            {
                if (this._asciiCodeRanges == null || !this._asciiCodeRanges.Any())
                    this._asciiCodeRanges = Split(ConfigurationManager.AppSettings["AsciiCodeRanges"], ",");
                return this._asciiCodeRanges;
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Parses the full-width unicode character ranges in integer format.
        /// </summary>
        /// <returns>Returns the full-width unicode character ranges in integer format.</returns>
        public IList<int> ParseFullWidthUnicodeRanges()
        {
            return Parse(this.FullWidthUnicodeRanges);
        }

        /// <summary>
        /// Parses the ASCII character ranges in integer format.
        /// </summary>
        /// <returns>Returns the ASCII character ranges in integer format.</returns>
        public IList<int> ParseAsciiCodeRanges()
        {
            return Parse(this.AsciiCodeRanges);
        }

        /// <summary>
        /// Parses the HEX code string ranges to the list of integer ranges.
        /// </summary>
        /// <param name="ranges">List of the HEX code string ranges.</param>
        /// <returns>Returns the list of integer ranges.</returns>
        private static IList<int> Parse(IList<string> ranges)
        {
            if (ranges == null || !ranges.Any())
                return null;

            var values = new List<int>();
            foreach (var segments in ranges.Select(p => p.Split(new string[] { "-" },
                                                                StringSplitOptions.RemoveEmptyEntries)))
            {
                if (segments.Length == 1)
                    values.Add(Int32.Parse(segments[0], NumberStyles.HexNumber, CultureInfo.InvariantCulture));
                else
                    values.AddRange(Enumerable.Range(Int32.Parse(segments[0],
                                                                 NumberStyles.HexNumber,
                                                                 CultureInfo.InvariantCulture),
                                                     Int32.Parse(segments[1],
                                                                 NumberStyles.HexNumber,
                                                                 CultureInfo.InvariantCulture)));
            }
            return values;
        }

        /// <summary>
        /// Splits the given string into segments by delimiters provided.
        /// </summary>
        /// <param name="value">String value to be split.</param>
        /// <param name="delimiters">List of delimiters.</param>
        /// <returns>Returns the list of segments split.</returns>
        private static IList<string> Split(string value, string delimiters)
        {
            return Split(value, delimiters.ToCharArray()
                                          .Select(p => Convert.ToString(p))
                                          .ToArray());
        }

        /// <summary>
        /// Splits the given string into segments by delimiters provided.
        /// </summary>
        /// <param name="value">String value to be split.</param>
        /// <param name="delimiters">List of delimiters.</param>
        /// <returns>Returns the list of segments split.</returns>
        private static IList<string> Split(string value, string[] delimiters)
        {
            var segments = value.Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                                .ToList();
            return segments;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
        }

        #endregion Methods
    }
}