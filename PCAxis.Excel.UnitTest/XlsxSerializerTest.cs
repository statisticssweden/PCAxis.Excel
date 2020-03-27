using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PCAxis.Excel.UnitTest
{
	[TestClass]
	public class XlsxSerializerTest
	{
		[TestMethod]
		public void ShouldReturnTrueIsNumeric()
		{
			//Arrange,
			var numericVariable = "8";

			// Act
			var numericTrue = StringTests.IsNumeric (numericVariable);


			//Assert
			Assert.IsTrue(numericTrue);


		}
	}
}
