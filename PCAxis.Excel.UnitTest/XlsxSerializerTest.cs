using System.IO;
using System.Text;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCAxis.Paxiom;

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
        public void ShouldSerialize()
        {
            var pxData = new PXData();
			//pxData.

   //         pxData.CurrentIndex = 2;
		
   //         pxData.Matrix = 2,2;

			
            var pxMeta = new PXMeta();

			var pxModel = new PXModel();

            //pxModel.Data = pxData;

			var ser = new XlsxSerializer();

            var stream = new MemoryStream(Encoding.UTF8.GetBytes("whatever"));

        //	var stream = 

            ser.Serialize(pxModel, stream);

			Assert.AreEqual(1,1); 

        }


	}
}
