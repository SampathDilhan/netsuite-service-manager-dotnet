//~ Geneerated by AdvancedSearchTemplate.tt
#pragma warning disable 1591
	
namespace com.celigo.net.ServiceManager.SuiteTalk
{
	public partial class EntityGroupSearchAdvanced : ISearchAdvanced
	{
        /// <summary>Gets the criteria for the Search.</summary>
        /// <returns>The criteria for the Search.</returns>
        public ISearchRecord GetCriteria() { return this.criteria; }
		
		/// <summary>
        /// Gets the criteria for the Search.
        /// </summary>
        /// <param name="create">if set to <c>true</c> create the criteria if it is null.</param>
        /// <returns>The criteria for the Search.</returns>
		public ISearchRecord GetCriteria(bool create)
		{
			if (create && this.criteria == null)
			{
				this.criteria = new EntityGroupSearch();
			}
			return this.criteria;
		}
		
		/// <summary>
        /// Sets the criteria.
        /// </summary>
        /// <param name="search">The search.</param>
        public void SetCriteria(ISearchRecord search) 
		{ 
			if (search is EntityGroupSearch)
				this.criteria = (EntityGroupSearch)search; 
			else
				throw new System.ArgumentException("Parameter should be of type EntityGroupSearch", "search");
		}

        /// <summary>Gets the columns to be returned in the results.</summary>
        /// <returns>The columns to be returned in the results.</returns>
        public SearchRow GetColumns() { return this.columns; }
		
		/// <summary>
        /// Gets the columns to be returned in the results.
        /// </summary>
        /// <param name="create">if set to <c>true</c> create the columns object if it is null.</param>
        /// <returns>
        /// The columns to be returned in the results.
        /// </returns>
		public SearchRow GetColumns(bool create)
		{
			if (create && this.columns == null)
			{
				this.columns = new EntityGroupSearchRow();
			}
			return this.columns;
		}
		
		/// <summary>
        /// Sets the return columns.
        /// </summary>
        public void SetColumns(SearchRow columns) 
		{ 
			if (columns is EntityGroupSearchRow)
				this.columns = (EntityGroupSearchRow)columns; 
			else
				throw new System.ArgumentException("Parameter should be of type EntityGroupSearchRow", "columns");
		}

        /// <summary>
        /// Gets the saved search id.
        /// </summary>
        /// <returns>The saved search ID.</returns>
        public string GetSavedSearchId() { return this.savedSearchId; }
		
        /// <summary>
        /// Sets the saved search id.
        /// </summary>
        /// <param name="savedSearchId">The saved search id.</param>
        public void SetSavedSearchId(string savedSearchId) { this.savedSearchId = savedSearchId; }

        /// <summary>
        /// Gets the saved search script id.
        /// </summary>
        /// <returns></returns>
        public string GetSavedSearchScriptId() { return this.savedSearchScriptId; }
        /// <summary>
        /// Sets the saved search script id.
        /// </summary>
        /// <param name="savedSearchScriptId">The saved search script id.</param>
        public void SetSavedSearchScriptId(string savedSearchScriptId) { this.savedSearchScriptId = savedSearchScriptId; }
	}
}
