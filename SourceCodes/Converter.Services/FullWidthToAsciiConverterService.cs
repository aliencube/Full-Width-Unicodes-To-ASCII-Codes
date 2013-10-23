using Converter.Services.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace Converter.Services
{
    /// <summary>
    /// This represents the service entity to convert full-width unicode characters to ASCII characters.
    /// </summary>
    public class FullWidthToAsciiConverterService : BaseConverterService
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the FullWidthToAsciiConverterService class.
        /// </summary>
        /// <param name="helper">ConverterHelper instance.</param>
        public FullWidthToAsciiConverterService(IConverterHelper helper)
            : base(helper)
        {
        }

        #endregion Constructors

        #region Properties

        #endregion Properties

        #region Methods

        /// <summary>
        /// Converts full-width unicode characters to ASCII characters.
        /// </summary>
        /// <param name="values">List of full-width unicode strings to convert.</param>
        /// <returns>Returns the list of converted strings.</returns>
        public override IList<string> Convert(params string[] values)
        {
            var results = new List<string>();
            foreach (var value in values)
            {
                var sb = new StringBuilder();
                foreach (var c in value)
                {
                    try
                    {
                        sb.Append(System.Convert.ToChar(this.AsciiCodeRanges[this.FullWidthUnicodeRanges.IndexOf(c)]));
                    }
                    catch
                    {
                        sb.Append(c);
                    }
                }
                results.Add(sb.ToString());
            }
            return results;
        }

        #endregion Methods
    }
}