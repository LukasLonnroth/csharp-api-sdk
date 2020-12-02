using FortnoxAPILibrary.Entities;

using System.Threading.Tasks;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    /// <remarks/>
    public class CurrencyConnector : SearchableEntityConnector<Currency, Currency, CurrencySearch>, ICurrencyConnector
	{


		/// <remarks/>
		public CurrencyConnector()
		{
			Resource = "currencies";
		}
		/// <summary>
		/// Find a currency based on id
		/// </summary>
		/// <param name="id">Identifier of the currency to find</param>
		/// <returns>The found currency</returns>
		public Currency Get(string id)
		{
			return GetAsync(id).GetResult();
		}

		/// <summary>
		/// Updates a currency
		/// </summary>
		/// <param name="currency">The currency to update</param>
		/// <returns>The updated currency</returns>
		public Currency Update(Currency currency)
		{
			return UpdateAsync(currency).GetResult();
		}

		/// <summary>
		/// Creates a new currency
		/// </summary>
		/// <param name="currency">The currency to create</param>
		/// <returns>The created currency</returns>
		public Currency Create(Currency currency)
		{
			return CreateAsync(currency).GetResult();
		}

		/// <summary>
		/// Deletes a currency
		/// </summary>
		/// <param name="id">Identifier of the currency to delete</param>
		public void Delete(string id)
		{
			DeleteAsync(id).GetResult();
		}

		/// <summary>
		/// Gets a list of currencys
		/// </summary>
		/// <returns>A list of currencys</returns>
		public EntityCollection<Currency> Find()
		{
			return FindAsync().GetResult();
		}

		public async Task<EntityCollection<Currency>> FindAsync()
		{
			return await BaseFind().ConfigureAwait(false);
		}
		public async Task DeleteAsync(string id)
		{
			await BaseDelete(id).ConfigureAwait(false);
		}
		public async Task<Currency> CreateAsync(Currency currency)
		{
			return await BaseCreate(currency).ConfigureAwait(false);
		}
		public async Task<Currency> UpdateAsync(Currency currency)
		{
			return await BaseUpdate(currency, currency.Code).ConfigureAwait(false);
		}
		public async Task<Currency> GetAsync(string id)
		{
			return await BaseGet(id).ConfigureAwait(false);
		}
	}
}
