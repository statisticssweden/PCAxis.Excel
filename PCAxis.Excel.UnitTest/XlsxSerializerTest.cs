using System;
using System.IO;
using System.Text;
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

        [TestMethod]
        [DeploymentItem("TestFiles\\BE0101A1_20200914-143936.px")]
		public void ShouldSerializeCommaSeparated()
        {
            var model = PxExtend.PxExtend.CreatePxModel("TestFiles\\BE0101A1_20200914-143936.px");

            var ser = new XlsxSerializer();

            var stream = new MemoryStream();

            try
            {
                ser.Serialize(model, stream);

                MemoryStream destination = new MemoryStream();
                stream.CopyTo(destination);
                string actual = Encoding.UTF8.GetString(stream.ToArray());
                Assert.IsTrue(actual.Length >= 1);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }
    

        [TestMethod]
        [DeploymentItem("TestFiles\\BE0101A1.px")]
        public void ShouldSerialize()
        {
            var model = PxExtend.PxExtend.CreatePxModel("TestFiles\\BE0101A1.px");

            var ser = new XlsxSerializer();

            var stream = new MemoryStream();

            try
            {
                ser.Serialize(model, stream);
                
                MemoryStream destination = new MemoryStream();

                stream.CopyTo(destination);

                string actual = Encoding.UTF8.GetString(stream.ToArray());

                Assert.IsTrue(actual.Length >= 1 );
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }
    }

}



