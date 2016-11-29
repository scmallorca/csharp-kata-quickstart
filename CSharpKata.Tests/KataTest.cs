using NUnit.Framework;

namespace CSharpKata.Tests
{
	[TestFixture()]
	public class Test
	{
		[TestCase(1, "1")]
		[TestCase(2, "2")]
		public void ShouldValueBeEqualResult(int value, string result)
		{
			// var kata = new Kata();
			Assert.That(value.ToString(), Is.EqualTo(result));
		}
	}
}
