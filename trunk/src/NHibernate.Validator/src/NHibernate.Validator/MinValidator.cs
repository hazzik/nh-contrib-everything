using System;
using System.Collections;
using NHibernate.Mapping;

namespace NHibernate.Validator
{
	public class MinValidator : Validator<MinAttribute>, IPropertyConstraint
	{
		private long min;
		
		public void Apply(Property property)
		{
			IEnumerator ie = property.ColumnIterator.GetEnumerator();
			ie.MoveNext();
			Column col = (Column) ie.Current;
			col.CheckConstraint = col.Name + ">=" + min;
		}

		public override bool IsValid(object value)
		{
			if (value == null)
			{
				return true;
			}

			if (value is string)
			{
				try
				{
					return Convert.ToDecimal(value) >= Convert.ToDecimal(min);
				}
				catch(FormatException)
				{
					return false;
				}
			}
			else if (value is decimal)
			{
				return Convert.ToDecimal(value) >= Convert.ToDecimal(min);
			}
			else if (value is Int32)
			{
				return Convert.ToInt32(value) >= Convert.ToInt32(min);
			}
			else if (value is Int64)
			{
				return Convert.ToInt64(value) >= Convert.ToInt64(min);
			}
			else if (value is long)
			{
				return (long) value >= min;
			}

			return false;
		}

		public override void Initialize(MinAttribute parameters)
		{
			min = parameters.Value;
		}
	}
}