using System;
using System.Collections.Generic;
using System.Text;

namespace NHibernate.Validator.Tests.XmlAndAttributesMix
{
	public class Person
	{
		[NotEmpty]
		public string Name;

		[NotNull]
		[Length(Min=5, Max=25)]
		public string Address;

		private bool isMale;

		[NotNull]
		public bool IsMale
		{
			get { return isMale; }
			set { isMale = value; }
		}
	}
}
