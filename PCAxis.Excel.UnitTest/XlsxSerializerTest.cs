using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCAxis.Paxiom;
using PCAxis.PxExtend;

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
		public void ShouldSerialize()
        {
            var model = PCAxis.PxExtend.PxExtend.CreatePxModel("TestFiles\\BE0101A1_20200914-143936.px");

            var ser = new XlsxSerializer();

            var stream = new MemoryStream(Encoding.UTF8.GetBytes("whatever"));
            
            try
            {
                ser.Serialize(model, stream);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            Assert.AreEqual(1, 1); 

        }


	}
}
