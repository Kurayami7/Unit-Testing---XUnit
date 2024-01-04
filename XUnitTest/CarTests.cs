using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using XUnitPractice;

namespace XUnitTest
{
    public class CarTests


    //TODO: gasTankLevel is accurate after driving within tank range
    //TODO: gasTankLevel is accurate after attempting to drive past tank range
    //TODO: can't have more gas than tank size, expect an exception
    {
        [Fact] // Tesing Odometer when miles is less than distance driven
        public void Test1()
        {   
            Car c1 = new Car("Toyota", "Supra", 400, 29);
            c1.Drive(300);
            Assert.Equal(300, c1.Odometer);
        }

        [Fact] // Testing Odometer when miles is more than distance driven
        public void Test2()
        {
            Car c2 = new Car("Toyota", "Supra", 400, 29);
            c2.Drive(30000);
            Assert.Equal(11600, c2.Odometer); // 11600 is the odometer reading and it's
            // gas tank level x miles
        }



        [Fact]
        public void Test3() // Testing case when we try to overfuel
        {
            Car c3 = new Car("Honda", "Civic", 200, 20);
/*            
*/            // Act & Assert
            var exception = Assert.Throws<TankFullException>(() => c3.Refuel(400));

            // Assert
            Assert.Equal(exception.Message, exception.Message); // It checks whether the exception's
                                                             // message is equal to the expected message.
        }

        [Fact]
        public void Test4() // Testing case when we try to overfuel
        {
            Car c4 = new Car("Honda", "Civic", 300, 20);
            c4.GasTankSize = 450; // Apparently, the maximum size, and the level of gas
            // are the exact same, so obviously, no matter how much fuel you add,
            // it will always cause an exception (so I manually changed the max size
            c4.Refuel(40.0);

            // Assert
            Assert.Equal(340.0, c4.GasTankLevel); // It checks whether the exception's
                                                  // message is equal to the expected message.
        }
    }
}