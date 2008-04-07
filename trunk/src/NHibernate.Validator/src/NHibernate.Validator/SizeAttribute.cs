namespace NHibernate.Validator
{
	using System;

	/// <summary>
	/// Size range for Arrays, Collections
	/// </summary>
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	[ValidatorClass(typeof(SizeValidator))]
	public class SizeAttribute : Attribute, IHasMessage
	{
		private int max = int.MaxValue;
		private string message = "{validator.size}";
		private int min = 0;

		public string Message
		{
			get { return message; }
			set { message = value; }
		}

		public int Min
		{
			get { return min; }
			set { min = value; }
		}

		public int Max
		{
			get { return max; }
			set { max = value; }
		}
	}
}