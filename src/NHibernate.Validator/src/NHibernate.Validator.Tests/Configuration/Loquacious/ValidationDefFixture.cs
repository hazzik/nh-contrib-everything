using System.Linq;
using System.Reflection;
using NHibernate.Validator.Cfg.Loquacious;
using NHibernate.Validator.Constraints;
using NHibernate.Validator.Mappings;
using NUnit.Framework;

namespace NHibernate.Validator.Tests.Configuration.Loquacious
{
	[TestFixture]
	public class ValidationDefFixture
	{
		private const BindingFlags membersBindingFlags =
			BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
			| BindingFlags.Static;

		[Test]
		public void ShouldAddPropertiesValidators()
		{
			var v = new ValidationDef<KnownRules>();
			v.Define(x => x.DtProp).IsInThePast();
			IClassMapping cm = v.GetMapping();
			PropertyInfo lpi = typeof (KnownRules).GetProperty("DtProp", membersBindingFlags);

			Assert.That(cm.GetMemberAttributes(lpi).Count(), Is.EqualTo(1));
			Assert.That(cm.GetMemberAttributes(lpi).First(), Is.InstanceOf<PastAttribute>());

			var kv = new KnownRulesSimpleValidationDef();
			cm = kv.GetMapping();
			Assert.That(cm.GetMemberAttributes(lpi).Count(), Is.EqualTo(1));
			Assert.That(cm.GetMemberAttributes(lpi).First(), Is.InstanceOf<PastAttribute>());
		}

		public class KnownRulesSimpleValidationDef: ValidationDef<KnownRules>
		{
			public KnownRulesSimpleValidationDef()
			{
				Define(x => x.DtProp).IsInThePast();
			}
		}

		[Test]
		public void ShouldAssignRuleArgsOptions()
		{
			PropertyInfo lpi = typeof(KnownRules).GetProperty("DtProp", membersBindingFlags);
			var v = new ValidationDef<KnownRules>();
			var expected = "{validator.past}";
			v.Define(x => x.DtProp).IsInThePast();
			var cm = v.GetMapping();
			Assert.That(cm.GetMemberAttributes(lpi).OfType<PastAttribute>().First().Message, Is.EqualTo(expected));

			v = new ValidationDef<KnownRules>();
			expected = "The date is in the past.";
			v.Define(x => x.DtProp).IsInThePast().WithMessage(expected);
			cm = v.GetMapping();
			Assert.That(cm.GetMemberAttributes(lpi).OfType<PastAttribute>().First().Message, Is.EqualTo(expected));
		}
	}
}