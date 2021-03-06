using System;
using System.Reflection;

using NHibernate.Type;
using NHibernate.UserTypes.SqlTypes;

using NUnit.Framework;

namespace NHibernate.UserTypes.SqlTypes.Tests
{
	[TestFixture]
	public class SerializabilityFixture
	{
		public static void CheckITypesInAssembly(Assembly assembly)
		{
			foreach (System.Type type in assembly.GetTypes())
			{
				if (type.IsClass && !type.IsAbstract && typeof(IType).IsAssignableFrom(type))
				{
					Assert.IsTrue(type.IsSerializable, "Type {0} should be serializable", type);
				}
			}
		}

		[Test]
		public void SqlTypes()
		{
			CheckITypesInAssembly(typeof(SqlInt32Type).Assembly);
		}
	}
}