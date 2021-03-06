using System.Threading.Tasks;
using Fortnox.SDK.Connectors.Base;
using Fortnox.SDK.Entities;
using Fortnox.SDK.Interfaces;
using Fortnox.SDK.Search;
using Fortnox.SDK.Utility;

// ReSharper disable UnusedMember.Global

namespace Fortnox.SDK.Connectors
{
	/// <remarks/>
	public class SupplierInvoiceFileConnectionConnector : SearchableEntityConnector<SupplierInvoiceFileConnection, SupplierInvoiceFileConnection, SupplierInvoiceFileConnectionSearch>, ISupplierInvoiceFileConnectionConnector
	{

		/// <remarks/>
		public SupplierInvoiceFileConnectionConnector()
		{
			Resource = "supplierinvoicefileconnections";
		}

		/// <summary>
		/// Find a supplierInvoiceFileConnection based on id
		/// </summary>
		/// <param name="id">Identifier of the supplierInvoiceFileConnection to find</param>
		/// <returns>The found supplierInvoiceFileConnection</returns>
		public SupplierInvoiceFileConnection Get(string id)
		{
			return GetAsync(id).GetResult();
		}

		/// <summary>
		/// Creates a new supplierInvoiceFileConnection
		/// </summary>
		/// <param name="supplierInvoiceFileConnection">The supplierInvoiceFileConnection to create</param>
		/// <returns>The created supplierInvoiceFileConnection</returns>
		public SupplierInvoiceFileConnection Create(SupplierInvoiceFileConnection supplierInvoiceFileConnection)
		{
			return CreateAsync(supplierInvoiceFileConnection).GetResult();
		}

		/// <summary>
		/// Deletes a supplierInvoiceFileConnection
		/// </summary>
		/// <param name="id">Identifier of the supplierInvoiceFileConnection to delete</param>
		public void Delete(string id)
		{
			DeleteAsync(id).GetResult();
		}

		/// <summary>
		/// Gets a list of supplierInvoiceFileConnections
		/// </summary>
		/// <returns>A list of supplierInvoiceFileConnections</returns>
		public EntityCollection<SupplierInvoiceFileConnection> Find(SupplierInvoiceFileConnectionSearch searchSettings)
		{
			return FindAsync(searchSettings).GetResult();
		}

		public async Task<EntityCollection<SupplierInvoiceFileConnection>> FindAsync(SupplierInvoiceFileConnectionSearch searchSettings)
		{
			return await BaseFind(searchSettings).ConfigureAwait(false);
		}
		public async Task DeleteAsync(string id)
		{
			await BaseDelete(id).ConfigureAwait(false);
		}
		public async Task<SupplierInvoiceFileConnection> CreateAsync(SupplierInvoiceFileConnection supplierInvoiceFileConnection)
		{
			return await BaseCreate(supplierInvoiceFileConnection).ConfigureAwait(false);
		}
		public async Task<SupplierInvoiceFileConnection> GetAsync(string id)
		{
			return await BaseGet(id).ConfigureAwait(false);
		}
	}
}
