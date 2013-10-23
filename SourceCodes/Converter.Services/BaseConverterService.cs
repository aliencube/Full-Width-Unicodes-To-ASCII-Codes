using Converter.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Converter.Services
{
    /// <summary>
    /// This represents the base converter service entity must be inherited.
    /// </summary>
    public abstract class BaseConverterService : IBaseConverterService
    {
        #region Constructors

        /// <summary>
        /// Initialises a new instance of the BaseConverterService class.
        /// </summary>
        /// <param name="helper">ConverterHelper instance.</param>
        protected BaseConverterService(IConverterHelper helper)
        {
            this.Helper = helper;
        }

        #endregion Constructors

        #region Properties

        protected IConverterHelper Helper { get; private set; }

        private IList<int> _fullWidthUnicodeRanges;

        /// <summary>
        /// Gets the full-width unicode character ranges in integer format.
        /// </summary>
        public IList<int> FullWidthUnicodeRanges
        {
            get
            {
                if (this._fullWidthUnicodeRanges == null || !this._fullWidthUnicodeRanges.Any())
                    this._fullWidthUnicodeRanges = this.Helper.ParseFullWidthUnicodeRanges();
                return this._fullWidthUnicodeRanges;
            }
        }

        private IList<int> _asciiCodeRanges;

        /// <summary>
        /// Gets the ASCII character ranges in integer format.
        /// </summary>
        public IList<int> AsciiCodeRanges
        {
            get
            {
                if (this._asciiCodeRanges == null || !this._asciiCodeRanges.Any())
                    this._asciiCodeRanges = this.Helper.ParseAsciiCodeRanges();
                return this._asciiCodeRanges;
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Converts full-width unicode characters to ASCII characters or vice versa.
        /// </summary>
        /// <param name="values">List of strings to convert.</param>
        /// <returns>Returns the list of converted strings.</returns>
        public abstract IList<string> Convert(params string[] values);

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public virtual void Dispose()
        {
        }

        #endregion Methods
    }
}