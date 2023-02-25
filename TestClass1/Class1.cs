using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnitDemonstration1;

namespace TestClass1
{
    public class TriangleTest

    {

        [TestFixture]

        public class TriangleTest1

        {

            [Test]





            public void inputOutput()

            {

                //Arrange 

                int first_angle = 60;

                int second_angle = 60;

                int third_angle = 60;



                string expected = "The triangle is valid.";



                string actual = Triangle.ValidTriangle(first_angle, second_angle, third_angle);



                //Assert 

                Assert.AreEqual(expected, actual);









            }

        }

    }
}
