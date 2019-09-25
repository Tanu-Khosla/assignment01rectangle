using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment01;

//using Assignment01;
namespace Assignment01Tests
{
    public class RectangleTest
    {
        [Test]
        public void GetRectangleLength_InputLength8_expectedResultEquals8()
        {
            //Arrange
            int l = 8;
            int w = 4;
            int expectedoutput = l;
            Rectangle result = new Rectangle(l,w);

            //Act
            int actualoutput = result.GetLength();
            //Assert
            Assert.AreEqual(expectedoutput, actualoutput);
        }

        private static Rectangle GetResult(int l, int w)
        {
            return new Rectangle(l, w);
        }

        [Test]
        public void SetRectangleLength_InputLength9_expectedResultEquals9()
        {
            //Arrange
            int l = 9;
            int w = 6;
            int expectedoutput = l;
             Rectangle result = new Rectangle(l, w);

            //Act
            int actualoutput = result.GetLength();
            //Assert
            Assert.AreEqual(expectedoutput, actualoutput);
        }

        [Test]
        public void GetRetangleWidth_InputWidth10_expectedResultEquals10()
        {
            //Arrange
            int l = 15;
            int w = 10;
            int expectedoutput = w;
            // Rectangle result = new Rectangle(l, w);

            //Act
            // int actualoutput = result.GetWidth();

            //Assert
            // Assert.AreEqual(expectedoutput, actualoutput);
        }
        [Test]
        public void SetRectangleWidth_InputWidth9_expectedResultEquals9()
        {
            //Arrange
            int l = 18;
            int w = 9;
            int expectedoutput = w;
            Rectangle result = new Rectangle(l, w);

            //Act
            int actualoutput = result.SetWidth(w);

            //Assert
            //Assert.AreEqual(expectedoutput, actualoutput);
        }

        [Test]
        public void GetRectanglrPerimeter_Length30Width15_expectedResultEquals75()
        {
            //Arrange
            int l = 30;
            int w = 15;
            int p = 2 * (l + w);
            int expectedoutput = p;
             Rectangle result = new Rectangle(l, w);

            //Act
             int actualoutput =result.GetPerimeter();

            //Assert
           Assert.AreEqual(expectedoutput, actualoutput);
        }
        [Test]
        public void GetRectangleArea_Length12Width11_expectedResultEquals132()
        {
            //Arrange
            int l = 12;
            int w = 10;
            int a = (l * w);
            int expectedoutput = a;
            Rectangle result = new Rectangle(l, w);

            //Act
            int actualoutput = result.GetArea(l,w);

            //Assert
            Assert.AreEqual(expectedoutput, actualoutput);
        }




    }
}
