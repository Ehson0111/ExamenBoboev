using ExamenBoboev;
using System.Reflection.PortableExecutable;
namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {

        /// <summary>
        /// Коректный ввод данных 
        /// </summary>
        [TestMethod]
        public void NMax()
        {

            double[] d = { 22, 234, -2, 24, 3 };

            int result = MaxMin.NMin(d, d.Length);
            int resultmax = MaxMin.NMax(d, d.Length);

            Assert.AreEqual(2, result); // Проверка индекса минимального элемента
            Assert.AreEqual(1, resultmax); // Проверка индекса максимального элемента

        }



        ///// <summary>
        ///// Максимальное число 
        ///// </summary>
        //[TestMethod]
        //public void NMax_Is_Actually_Max()
        //{
        //    double[] A = { 1.0, 7.0, 3.0 };
        //    int index = MaxMin.NMax(A, A.Length);
        //    Assert.IsTrue(A[index] == 7.0);
        //}


        /// <summary>
        /// Пустые значение 
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Max()
        {
            double[] A = { };
            var index = MaxMin.NMax(A, A.Length);
            //int resultmax = MaxMin.NMax(d, d.Length);
 
        }


        /// <summary>
        /// 0.1 не на нулевой позиции
        /// </summary>
        [TestMethod]
        public void NMin_Not_Incorrect_Index()
        {
            double[] A = { 4.4, 2.2, 0.1 };
            int result = MaxMin.NMin(A, A.Length);
            Assert.AreNotEqual(0, result); 
        }
    }
}



