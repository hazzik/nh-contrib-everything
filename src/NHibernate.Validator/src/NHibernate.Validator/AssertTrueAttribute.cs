using System;
using NHibernate.Validator.Engine;

namespace NHibernate.Validator
{
	/// <summary>
	/// The annotated element has to be true
	/// </summary>
	[Serializable]
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	[ValidatorClass(typeof (AssertTrueValidator))]
	public class AssertTrueAttribute : Attribute, IRuleArgs
	{
		private string message = "{validator.assertTrue}";

		public string Message
		{
			get { return message; }
			set { message = value; }
		}
	}
}