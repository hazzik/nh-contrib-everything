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
	public class OneToOneAttribute : BaseAttribute
	{
		
		private OuterJoinStrategy _outerjoin = OuterJoinStrategy.Unspecified;
		
		private string _access = null;
		
		private string _formula = null;
		
		private bool _constrained = false;
		
		private string _entityname = null;
		
		private bool _embedxml = true;
		
		private bool _embedxmlspecified;
		
		private string _cascade = null;
		
		private string _node = null;
		
		private string _class = null;
		
		private bool _constrainedspecified;
		
		private string _propertyref = null;
		
		private FetchMode _fetch = FetchMode.Unspecified;
		
		private string _foreignkey = null;
		
		private string _name = null;
		
		private Laziness _lazy = Laziness.Unspecified;
		
		/// <summary> Default constructor (position=0) </summary>
		public OneToOneAttribute() : 
				base(0)
		{
		}
		
		/// <summary> Constructor taking the position of the attribute. </summary>
		public OneToOneAttribute(int position) : 
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
		public virtual string Formula
		{
			get
			{
				return this._formula;
			}
			set
			{
				this._formula = value;
			}
		}
		
		/// <summary> </summary>
		public virtual string Access
		{
			get
			{
				return this._access;
			}
			set
			{
				this._access = value;
			}
		}
		
		/// <summary> </summary>
		public virtual System.Type AccessType
		{
			get
			{
				return System.Type.GetType( this.Access );
			}
			set
			{
				if(value.Assembly == typeof(int).Assembly)
					this.Access = value.FullName.Substring(7);
				else
					this.Access = HbmWriterHelper.GetNameWithAssembly(value);
			}
		}
		
		/// <summary> </summary>
		public virtual string Class
		{
			get
			{
				return this._class;
			}
			set
			{
				this._class = value;
			}
		}
		
		/// <summary> </summary>
		public virtual System.Type ClassType
		{
			get
			{
				return System.Type.GetType( this.Class );
			}
			set
			{
				if(value.Assembly == typeof(int).Assembly)
					this.Class = value.FullName.Substring(7);
				else
					this.Class = HbmWriterHelper.GetNameWithAssembly(value);
			}
		}
		
		/// <summary> </summary>
		public virtual string EntityName
		{
			get
			{
				return this._entityname;
			}
			set
			{
				this._entityname = value;
			}
		}
		
		/// <summary> </summary>
		public virtual System.Type EntityNameType
		{
			get
			{
				return System.Type.GetType( this.EntityName );
			}
			set
			{
				if(value.Assembly == typeof(int).Assembly)
					this.EntityName = value.FullName.Substring(7);
				else
					this.EntityName = HbmWriterHelper.GetNameWithAssembly(value);
			}
		}
		
		/// <summary> </summary>
		public virtual string Cascade
		{
			get
			{
				return this._cascade;
			}
			set
			{
				this._cascade = value;
			}
		}
		
		/// <summary> </summary>
		public virtual OuterJoinStrategy OuterJoin
		{
			get
			{
				return this._outerjoin;
			}
			set
			{
				this._outerjoin = value;
			}
		}
		
		/// <summary> </summary>
		public virtual FetchMode Fetch
		{
			get
			{
				return this._fetch;
			}
			set
			{
				this._fetch = value;
			}
		}
		
		/// <summary> </summary>
		public virtual bool Constrained
		{
			get
			{
				return this._constrained;
			}
			set
			{
				this._constrained = value;
				_constrainedspecified = true;
			}
		}
		
		/// <summary> Tells if Constrained has been specified. </summary>
		public virtual bool ConstrainedSpecified
		{
			get
			{
				return this._constrainedspecified;
			}
		}
		
		/// <summary> </summary>
		public virtual string ForeignKey
		{
			get
			{
				return this._foreignkey;
			}
			set
			{
				this._foreignkey = value;
			}
		}
		
		/// <summary> </summary>
		public virtual string PropertyRef
		{
			get
			{
				return this._propertyref;
			}
			set
			{
				this._propertyref = value;
			}
		}
		
		/// <summary> </summary>
		public virtual Laziness Lazy
		{
			get
			{
				return this._lazy;
			}
			set
			{
				this._lazy = value;
			}
		}
		
		/// <summary> </summary>
		public virtual string Node
		{
			get
			{
				return this._node;
			}
			set
			{
				this._node = value;
			}
		}
		
		/// <summary> </summary>
		public virtual bool EmbedXml
		{
			get
			{
				return this._embedxml;
			}
			set
			{
				this._embedxml = value;
				_embedxmlspecified = true;
			}
		}
		
		/// <summary> Tells if EmbedXml has been specified. </summary>
		public virtual bool EmbedXmlSpecified
		{
			get
			{
				return this._embedxmlspecified;
			}
		}
	}
}
