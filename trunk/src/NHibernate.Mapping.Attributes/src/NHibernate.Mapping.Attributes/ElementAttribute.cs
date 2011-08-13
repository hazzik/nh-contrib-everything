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
	public class ElementAttribute : BaseAttribute
	{
		
		private int _length = -1;
		
		private string _formula = null;
		
		private bool _unique = false;
		
		private int _scale = -1;
		
		private bool _notnull = false;
		
		private string _node = null;
		
		private int _precision = -1;
		
		private bool _notnullspecified;
		
		private string _type = null;
		
		private string _column = null;
		
		private bool _uniquespecified;
		
		/// <summary> Default constructor (position=0) </summary>
		public ElementAttribute() : 
				base(0)
		{
		}
		
		/// <summary> Constructor taking the position of the attribute. </summary>
		public ElementAttribute(int position) : 
				base(position)
		{
		}
		
		/// <summary> </summary>
		public virtual string Column
		{
			get
			{
				return this._column;
			}
			set
			{
				this._column = value;
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
		public virtual string Type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		
		/// <summary> </summary>
		public virtual System.Type TypeType
		{
			get
			{
				return System.Type.GetType( this.Type );
			}
			set
			{
				if(value.Assembly == typeof(int).Assembly)
					this.Type = value.FullName.Substring(7);
				else
					this.Type = HbmWriterHelper.GetNameWithAssembly(value);
			}
		}
		
		/// <summary> </summary>
		public virtual int Length
		{
			get
			{
				return this._length;
			}
			set
			{
				this._length = value;
			}
		}
		
		/// <summary> </summary>
		public virtual int Precision
		{
			get
			{
				return this._precision;
			}
			set
			{
				this._precision = value;
			}
		}
		
		/// <summary> </summary>
		public virtual int Scale
		{
			get
			{
				return this._scale;
			}
			set
			{
				this._scale = value;
			}
		}
		
		/// <summary> </summary>
		public virtual bool NotNull
		{
			get
			{
				return this._notnull;
			}
			set
			{
				this._notnull = value;
				_notnullspecified = true;
			}
		}
		
		/// <summary> Tells if NotNull has been specified. </summary>
		public virtual bool NotNullSpecified
		{
			get
			{
				return this._notnullspecified;
			}
		}
		
		/// <summary> </summary>
		public virtual bool Unique
		{
			get
			{
				return this._unique;
			}
			set
			{
				this._unique = value;
				_uniquespecified = true;
			}
		}
		
		/// <summary> Tells if Unique has been specified. </summary>
		public virtual bool UniqueSpecified
		{
			get
			{
				return this._uniquespecified;
			}
		}
	}
}
