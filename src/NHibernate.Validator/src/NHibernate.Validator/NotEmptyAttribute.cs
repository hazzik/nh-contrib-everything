using System;

namespace NHibernate.Validator
{
    /// <summary>
	/// Check that a String is not empty (not null and length > 0)
	/// or that a Collection (or array) is not empty (not null and length > 0)
	/// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    [ValidatorClass(typeof(NotEmptyValidator))]
	public class NotEmptyAttribute : Attribute, IHasMessage
    {
        private string message = "{validator.notEmpty}";

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}