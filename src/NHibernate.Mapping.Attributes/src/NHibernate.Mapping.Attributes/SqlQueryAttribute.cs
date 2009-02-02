// 
// NHibernate.Mapping.Attributes
// This product is under the terms of the GNU Lesser General Public License.
//
//
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 2.0.50727.x
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
//
//
// This source code was auto-generated by Refly, Version=2.21.1.0 (modified).
//
namespace NHibernate.Mapping.Attributes
{
	
	
	/// <summary> </summary>
	[System.AttributeUsage(System.AttributeTargets.Property | System.AttributeTargets.Field, AllowMultiple=true)]
	[System.Serializable()]
	public class SqlQueryAttribute : BaseAttribute
	{
		
		private bool _readonly = false;
		
		private string _resultsetref = null;
		
		private bool _cacheablespecified;
		
		private string _cacheregion = null;
		
		private bool _readonlyspecified;
		
		private CacheMode _cachemode = CacheMode.Unspecified;
		
		private bool _cacheable = false;
		
		private bool _callable = false;
		
		private string _comment = null;
		
		private string _name = null;
		
		private long _fetchsize = -9223372036854775808;
		
		private FlushMode _flushmode = FlushMode.Unspecified;
		
		private bool _callablespecified;
		
		private string _content = null;
		
		private int _timeout = -1;
		
		/// <summary> Default constructor (position=0) </summary>
		public SqlQueryAttribute() : 
				base(0)
		{
		}
		
		/// <summary> Constructor taking the position of the attribute. </summary>
		public SqlQueryAttribute(int position) : 
				base(position)
		{
		}
		
		/// <summary> </summary>
		public virtual string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		
		/// <summary> </summary>
		public virtual string ResultSetRef
		{
			get
			{
				return this._resultsetref;
			}
			set
			{
				this._resultsetref = value;
			}
		}
		
		/// <summary> </summary>
		public virtual FlushMode FlushMode
		{
			get
			{
				return this._flushmode;
			}
			set
			{
				this._flushmode = value;
			}
		}
		
		/// <summary> </summary>
		public virtual bool Cacheable
		{
			get
			{
				return this._cacheable;
			}
			set
			{
				this._cacheable = value;
				_cacheablespecified = true;
			}
		}
		
		/// <summary> Tells if Cacheable has been specified. </summary>
		public virtual bool CacheableSpecified
		{
			get
			{
				return this._cacheablespecified;
			}
		}
		
		/// <summary> </summary>
		public virtual string CacheRegion
		{
			get
			{
				return this._cacheregion;
			}
			set
			{
				this._cacheregion = value;
			}
		}
		
		/// <summary> </summary>
		public virtual long FetchSize
		{
			get
			{
				return this._fetchsize;
			}
			set
			{
				this._fetchsize = value;
			}
		}
		
		/// <summary> </summary>
		public virtual int Timeout
		{
			get
			{
				return this._timeout;
			}
			set
			{
				this._timeout = value;
			}
		}
		
		/// <summary> </summary>
		public virtual CacheMode CacheMode
		{
			get
			{
				return this._cachemode;
			}
			set
			{
				this._cachemode = value;
			}
		}
		
		/// <summary> </summary>
		public virtual bool ReadOnly
		{
			get
			{
				return this._readonly;
			}
			set
			{
				this._readonly = value;
				_readonlyspecified = true;
			}
		}
		
		/// <summary> Tells if ReadOnly has been specified. </summary>
		public virtual bool ReadOnlySpecified
		{
			get
			{
				return this._readonlyspecified;
			}
		}
		
		/// <summary> </summary>
		public virtual string Comment
		{
			get
			{
				return this._comment;
			}
			set
			{
				this._comment = value;
			}
		}
		
		/// <summary> </summary>
		public virtual bool Callable
		{
			get
			{
				return this._callable;
			}
			set
			{
				this._callable = value;
				_callablespecified = true;
			}
		}
		
		/// <summary> Tells if Callable has been specified. </summary>
		public virtual bool CallableSpecified
		{
			get
			{
				return this._callablespecified;
			}
		}
		
		/// <summary> Gets or sets the content of this element </summary>
		public virtual string Content
		{
			get
			{
				return this._content;
			}
			set
			{
				this._content = value;
			}
		}
	}
}
