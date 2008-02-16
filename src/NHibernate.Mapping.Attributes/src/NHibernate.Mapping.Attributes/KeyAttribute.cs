// 
// NHibernate.Mapping.Attributes
// This product is under the terms of the GNU Lesser General Public License.
//
//
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 2.0.50727.1433
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
	[System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Interface | System.AttributeTargets.Property | System.AttributeTargets.Field, AllowMultiple=true)]
	[System.Serializable()]
	public class KeyAttribute : BaseAttribute
	{
		
		private string _column = null;
		
		private string _propertyref = null;
		
		private string _foreignkey = null;
		
		/// <summary> Default constructor (position=0) </summary>
		public KeyAttribute() : 
				base(0)
		{
		}
		
		/// <summary> Constructor taking the position of the attribute. </summary>
		public KeyAttribute(int position) : 
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
	}
}
