

namespace NHibernate.Validator.Tests.Validators
{
	public class XmlValidatorsFixture : ValidatorsFixture
	{
		public override ClassValidator GetClassValidator(System.Type type)
		{
			return ClassValidatorFactory.GetValidatorForUseXmlTest(type);
		}
	}
}
