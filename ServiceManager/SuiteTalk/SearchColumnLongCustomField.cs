//~ Generated by SearchColumnCustomFieldTemplate.tt
#pragma warning disable 1591

namespace com.celigo.net.ServiceManager.SuiteTalk
{
	public partial class SearchColumnLongCustomField
	{
		/// <summary>
		/// Gets the Internal ID.
		/// </summary>
		/// <returns>The Internal ID of the record.</returns>
		public override string GetInternalId()
		{
			return this.internalIdField;
		}

		/// <summary>
		/// Sets the Internal ID.
		/// </summary>
		/// <param name="id">The Internal ID.</param>
		public override void SetInternalId(string id)
		{
			this.internalIdField = id;
		}
	}
}
