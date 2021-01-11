﻿namespace Nop.Web.Models.Catalog
{
    /// <summary>
    /// Represents a price range model
    /// </summary>
    public partial class PriceRangeModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the "from" price
        /// </summary>
        public decimal? From { get; set; }

        /// <summary>
        /// Gets or sets the "to" price
        /// </summary>
        public decimal? To { get; set; }

        #endregion
    }
}
