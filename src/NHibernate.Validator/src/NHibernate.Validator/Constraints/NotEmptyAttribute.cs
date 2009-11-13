using System;
using NHibernate.Validator.Engine;

namespace NHibernate.Validator.Constraints
{
	/// <summary>
	/// Check that a String is not empty (length > 0)
	/// or that a IEnumerable is not empty (Count > 0)
	/// </summary>
	/// <remarks>
	/// To validate for NotNull and Not Empty use NotNullNotEmptyAttribute.
	/// </remarks>
	[Serializable]
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
	[ValidatorClass(typeof (NotEmptyValidator))]
	public class NotEmptyAttribute : EmbeddedRuleArgsAttribute, IRuleArgs
	{
		private string message = "{validator.notEmpty}";

		#region IRuleArgs Members

		public string Message
		{
			get { return message; }
			set { message = value; }
		}

		#endregion
	}
}