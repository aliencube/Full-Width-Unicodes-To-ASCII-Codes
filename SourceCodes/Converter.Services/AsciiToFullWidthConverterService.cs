using Converter.Services.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace Converter.Services
{
    public class AsciiToFullWidthConverterService : BaseConverterService
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the AsciiToFullWidthConverterService class.
        /// </summary>
        /// <param name="helper">ConverterHelper instance.</param>
        public AsciiToFullWidthConverterService(IConverterHelper helper)
            : base(helper)
        {
        }

        #endregion Constructors

        #region Properties

        #endregion Properties

        #region Methods

        /// <summary>
        /// Converts ASCII characters to full-width unicode characters.
        /// </summary>
        /// <param name="values">List of ASCII strings to convert.</param>
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
                        sb.Append(System.Convert.ToChar(this.FullWidthUnicodeRanges[this.AsciiCodeRanges.IndexOf(c)]));
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