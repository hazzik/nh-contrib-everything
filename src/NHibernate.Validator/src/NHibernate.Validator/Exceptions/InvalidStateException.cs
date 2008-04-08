using System;
using NHibernate.Validator.Engine;

namespace NHibernate.Validator.Exceptions
{
	public class InvalidStateException : System.Exception
	{
		private static InvalidValue[] _invalidValues;

		public InvalidStateException(InvalidValue[] invalidValues)
			: this(invalidValues, invalidValues[0].GetType().Name)
		{
		}

		public InvalidStateException(InvalidValue[] invalidValues, String className)
			: base("validation failed for: " + className)
		{
			_invalidValues = invalidValues;
		}
        
		public InvalidValue[] GetInvalidValues() 
		{
			return _invalidValues;
		}
	}
}