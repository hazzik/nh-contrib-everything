using System;
using System.Collections;
using NHibernate.Mapping;
using NHibernate.Validator.Engine;

namespace NHibernate.Validator
{
	[Serializable]
	public class RangeValidator : IInitializableValidator<RangeAttribute>, IPropertyConstraint
	{
		private long min;
		private long max;

		public void Initialize(RangeAttribute parameters)
		{
			max = parameters.Max;
			min = parameters.Min;
		}

		public bool IsValid(object value)
		{
			if (value == null)
			{
				return true;
			}

			if (value is string)
			{
				try
				{
					return Convert.ToDecimal(value) >= Convert.ToDecimal(min) &&
							Convert.ToDecimal(value) <= Convert.ToDecimal(max);
				}
				catch (FormatException)
				{
					return false;
				}
			}
			else if (value is decimal)
			{
				return Convert.ToDecimal(value) >= Convert.ToDecimal(min) &&
						Convert.ToDecimal(value) <= Convert.ToDecimal(max);
			}
			else if (value is Int32)
			{
				return Convert.ToInt32(value) >= Convert.ToInt32(min) &&
						Convert.ToInt32(value) <= Convert.ToInt32(max);
			}
			else if (value is Int64)
			{
				return Convert.ToInt64(value) >= Convert.ToInt64(min) &&
						Convert.ToInt64(value) <= Convert.ToInt64(max);
			}

			return false;
		}

		public void Apply(Property property)
		{
			IEnumerator ie = property.ColumnIterator.GetEnumerator();
			ie.MoveNext();
			Column col = (Column)ie.Current;

			String check = "";
			if (min != long.MinValue) check += col.Name + ">=" + min;
			if (max != long.MaxValue && min != long.MinValue) check += " and ";
			if (max != long.MaxValue) check += col.Name + "<=" + max;
			col.CheckConstraint = check;
		}
	}
}