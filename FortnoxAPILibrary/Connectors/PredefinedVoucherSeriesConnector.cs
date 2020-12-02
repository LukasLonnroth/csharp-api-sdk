using FortnoxAPILibrary.Entities;

using System.Threading.Tasks;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
	/// <remarks/>
	public class PredefinedVoucherSeriesConnector : SearchableEntityConnector<PredefinedVoucherSeries, PredefinedVoucherSeries, PredefinedVoucherSeriesSearch>, IPredefinedVoucherSeriesConnector
	{


		/// <remarks/>
		public PredefinedVoucherSeriesConnector()
		{
			Resource = "predefinedvoucherseries";
		}

		/// <summary>
		/// Find a predefinedVoucherSeries based on id
		/// </summary>
		/// <param name="id">Identifier of the predefinedVoucherSeries to find</param>
		/// <returns>The found predefinedVoucherSeries</returns>
		public PredefinedVoucherSeries Get(string id)
		{
			return GetAsync(id).GetResult();
		}

		/// <summary>
		/// Updates a predefinedVoucherSeries
		/// </summary>
		/// <param name="predefinedVoucherSeries">The predefinedVoucherSeries to update</param>
		/// <returns>The updated predefinedVoucherSeries</returns>
		public PredefinedVoucherSeries Update(PredefinedVoucherSeries predefinedVoucherSeries)
		{
			return UpdateAsync(predefinedVoucherSeries).GetResult();
		}

        /// <summary>
		/// Gets a list of predefinedVoucherSeriess
		/// </summary>
		/// <returns>A list of predefinedVoucherSeriess</returns>
		public EntityCollection<PredefinedVoucherSeries> Find()
		{
			return FindAsync().GetResult();
		}

		public async Task<EntityCollection<PredefinedVoucherSeries>> FindAsync()
		{
			return await BaseFind().ConfigureAwait(false);
		}
		public async Task<PredefinedVoucherSeries> UpdateAsync(PredefinedVoucherSeries predefinedVoucherSeries)
		{
			return await BaseUpdate(predefinedVoucherSeries, predefinedVoucherSeries.Name).ConfigureAwait(false);
		}
		public async Task<PredefinedVoucherSeries> GetAsync(string id)
		{
			return await BaseGet(id).ConfigureAwait(false);
		}
	}
}
