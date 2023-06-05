using MathLibrary19;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyMathTest
{
    [TestClass]
    public class AlgebraTest
    {
        //Алгебра1(2)
        [TestMethod]
        public void Test1Algebra5a10b()
        {
            double a = 5;
            double b = 10;
            double wait = -0.5;
            double res = Algebra2.SecondAssign(a, b);
            Assert.AreEqual(wait, res);
        }
        //Алгебра2(2)
        [TestMethod]
        public void Test2Algebra9a3b()
        {
            double a = 9;
            double b = 3;
            double wait = -3;
            double res = Algebra2.SecondAssign(a, b);
            Assert.AreEqual(wait, res);
        }
        //Алгебра3(2)
        [TestMethod]
        public void Test3Algebra49a7b()
        {
            double a = 49;
            double b = 7;
            double wait = -7;
            double res = Algebra2.SecondAssign(a, b);
            Assert.AreEqual(wait, res);
        }
        //Алгебра1(3)
        [TestMethod]
        public void Test1Algebrarr1()
        {
            double[] arr1 = { 1, 2, 3, 4 };
            double wait = 10;
            double res = Algebra2.ThirdAssign(arr1);
            Assert.AreEqual(wait, res);
        }
        //Алгебра2(3)
        [TestMethod]
        public void Test2Algebrarr2()
        {
            double[] arr2 = { 5, 6, 7, 8 };
            double wait = 26;
            double res = Algebra2.ThirdAssign(arr2);
            Assert.AreEqual(wait, res);
        }
        //Алгебра3(3)
        [TestMethod]
        public void Test3Algebrarr3()
        {
            double[] arr3 = { 1, 3, 5, 7 };
            double wait = 16;
            double res = Algebra2.ThirdAssign(arr3);
            Assert.AreEqual(wait, res);
        }
        //Алгебра1(4)
        [TestMethod]
        public void Test1Algebrarr4()
        {
            double[] arr4 = { 3, 6, 9 };
            double wait = 9;
            double res = Algebra2.FourthAssign(arr4);
            Assert.AreEqual(wait, res);
        }
        //Алгебра2(4)
        [TestMethod]
        public void Test2Algebrarr5()
        {
            double[] arr5 = { 2, 4, 6 };
            double wait = 6;
            double res = Algebra2.FourthAssign(arr5);
            Assert.AreEqual(wait, res);
        }
        //Алгебра3(4)
        [TestMethod]
        public void Test3Algebrarr6()
        {
            double[] arr6 = { 1, 5, 7 };
            double wait = 7;
            double res = Algebra2.FourthAssign(arr6);
            Assert.AreEqual(wait, res);
        }
        //Алгебра1(5)
        [TestMethod]
        public void Test3Algebrarr7()
        {
            double[] arr7 = { 9, 1, 5 };
            double wait = 5;
            double res = Algebra2.FifthAssign(arr7);
            Assert.AreEqual(wait, res);
        }
        //Алгебра2(5)
        [TestMethod]
        public void Test3Algebrarr8()
        {
            double[] arr8 = { 11, 6, 4 };
            double wait = 7;
            double res = Algebra2.FifthAssign(arr8);
            Assert.AreEqual(wait, res);
        }
        //Алгебра3(5)
        [TestMethod]
        public void Test3Algebrarr9()
        {
            double[] arr9 = { 11, 12, 13 };
            double wait = 12;
            double res = Algebra2.FifthAssign(arr9);
            Assert.AreEqual(wait, res);
        }
    }
    [TestClass]
    public class GeometryTest
    {
        //Геометрия1(1)
        [TestMethod]
        public void Test1Geometryx3y4()
        {
            double x = 3;
            double y = 4;
            double wait = 6;
            double S = Geometry2.FirstEx(x, y);
            Assert.AreEqual(wait, S);
        }
        //Геометрия2(1)
        [TestMethod]
        public void Test2Geometryx5y6()
        {
            double x = 5;
            double y = 6;
            double wait = 15;
            double S = Geometry2.FirstEx(x, y);
            Assert.AreEqual(wait, S);
        }
        //Геометрия3(1)
        [TestMethod]
        public void Test3Geometryx7y9()
        {
            double x = 7;
            double y = 9;
            double wait = 31.5;
            double S = Geometry2.FirstEx(x, y);
            Assert.AreEqual(wait, S);
        }
        //Геометрия1(2)
        [TestMethod]
        public void Test1Geometryx2y3()
        {
            double x = 2;
            double y = 3;
            double wait = 3;
            double S = Geometry2.SecondEx(x, y);
            Assert.AreEqual(wait, S);
        }
        //Геометрия2(2)
        [TestMethod]
        public void Test2Geometryx7y7()
        {
            double x = 7;
            double y = 7;
            double wait = 24.5;
            double S = Geometry2.SecondEx(x, y);
            Assert.AreEqual(wait, S);
        }
        //Геометрия3(2)
        [TestMethod]
        public void Test3Geometryx9y9()
        {
            double x = 9;
            double y = 9;
            double wait = 40.5;
            double S = Geometry2.SecondEx(x, y);
            Assert.AreEqual(wait, S);
        }
        //Геометрия1(3)
        [TestMethod]
        public void Test1Geometryx6y7()
        {
            double x = 6;
            double y = 7;
            double wait = 42;
            double S = Geometry2.ThirdEx(x, y);
            Assert.AreEqual(wait, S);
        }
        //Геометрия2(3)
        [TestMethod]
        public void Test2Geometryx8y4()
        {
            double x = 8;
            double y = 4;
            double wait = 32;
            double S = Geometry2.ThirdEx(x, y);
            Assert.AreEqual(wait, S);
        }
        //Геометрия3(3)
        [TestMethod]
        public void Test3Geometryx17y3()
        {
            double x = 17;
            double y = 3;
            double wait = 51;
            double S = Geometry2.ThirdEx(x, y);
            Assert.AreEqual(wait, S);
        }
        //Геометрия1(4)
        [TestMethod]
        public void Test1Geometryx5()
        {
            double x = 5;
            double wait = 78;
            double S = Geometry2.FourthEx(x);
            Assert.AreEqual(wait, S);
        }
        //Геометрия2(4)
        [TestMethod]
        public void Test2Geometryx4()
        {
            double x = 4;
            double wait = 50;
            double S = Geometry2.FourthEx(x);
            Assert.AreEqual(wait, S);
        }
        //Геометрия3(4)
        [TestMethod]
        public void Test3Geometryx3()
        {
            double x = 3;
            double wait = 28;
            double S = Geometry2.FourthEx(x);
            Assert.AreEqual(wait, S);
        }
        //Геометрия1(5)
        [TestMethod]
        public void Test1Geometryx4y4z4()
        {
            double x = 4;
            double y = 4;
            double z = 4;
            double wait = 16;
            double S = Geometry2.FifthEx(x,y,z);
            Assert.AreEqual(wait, S);
        }
        //Геометрия2(5)
        [TestMethod]
        public void Test2Geometryx3y3z3()
        {
            double x = 3;
            double y = 3;
            double z = 3;
            double wait = 9;
            double S = Geometry2.FifthEx(x,y,z);
            Assert.AreEqual(wait, S);
        }
        //Геометрия3(5)
        [TestMethod]
        public void Test3Geometryx5y5z5()
        {
            double x = 5;
            double y = 5;
            double z = 5;
            double wait = 25;
            double S = Geometry2.FifthEx(x,y,z);
            Assert.AreEqual(wait, S);
        }
    }
    [TestClass]
    public class TrigonometryTest
    {
        //Тригонометрия1(1)
        [TestMethod]
        public void Test1Trigonometryac10ab5()
        {
            double ac = 10;
            double ab = 5;
            double wait = 2;
            double res = Trigonometry2.FirstTask(ac,ab);
            Assert.AreEqual(wait, res);
        }
        //Тригонометрияц(1)
        [TestMethod]
        public void Test2Trigonometryac49ab7()
        {
            double ac = 49;
            double ab = 7;
            double wait = 7;
            double res = Trigonometry2.FirstTask(ac, ab);
            Assert.AreEqual(wait, res);
        }
        //Тригонометрия3(1)
        [TestMethod]
        public void Test3Trigonometryac36ab6()
        {
            double ac = 36;
            double ab = 6;
            double wait = 6;
            double res = Trigonometry2.FirstTask(ac, ab);
            Assert.AreEqual(wait, res);
        }
        //Тригонометрия1(2)
        [TestMethod]
        public void Test1Trigonometrybc6ab3()
        {
            double bc = 6;
            double ab = 3;
            double wait = 2;
            double res = Trigonometry2.SecondTask(bc, ab);
            Assert.AreEqual(wait, res);
        }
        //Тригонометрия2(2)
        [TestMethod]
        public void Test2Trigonometrybc8ab4()
        {
            double bc = 8;
            double ab = 4;
            double wait = 2;
            double res = Trigonometry2.SecondTask(bc, ab);
            Assert.AreEqual(wait, res);
        }
        //Тригонометрия3(2)
        [TestMethod]
        public void Test3Trigonometrybc9ab3()
        {
            double bc = 9;
            double ab = 3;
            double wait = 3;
            double res = Trigonometry2.SecondTask(bc, ab);
            Assert.AreEqual(wait, res);
        }
        //Тригонометрия1(3)
        [TestMethod]
        public void Test1Trigonometrybc16ab4()
        {
            double bc = 16;
            double ac = 4;
            double wait = 4;
            double res = Trigonometry2.ThirdTask(bc, ac);
            Assert.AreEqual(wait, res);
        }
        //Тригонометрия2(3)
        [TestMethod]
        public void Test2Trigonometrybc15ab3()
        {
            double bc = 15;
            double ac = 3;
            double wait = 5;
            double res = Trigonometry2.ThirdTask(bc, ac);
            Assert.AreEqual(wait, res);
        }
        //Тригонометрия3(3)
        [TestMethod]
        public void Test3Trigonometrybc81ab9()
        {
            double bc = 81;
            double ac = 9;
            double wait = 9;
            double res = Trigonometry2.ThirdTask(bc, ac);
            Assert.AreEqual(wait, res);
        }
        //Тригонометрия1(4)
        [TestMethod]
        public void Test1Trigonometrybc99ab9()
        {
            double ac = 99;
            double ab = 9;
            double wait = 11;
            double res = Trigonometry2.FourthTask(ac, ab);
            Assert.AreEqual(wait, res);
        }
        //Тригонометрия2(4)
        [TestMethod]
        public void Test2Trigonometryac110ab5()
        {
            double ac = 110;
            double ab = 5;
            double wait = 22;
            double res = Trigonometry2.FourthTask(ac, ab);
            Assert.AreEqual(wait, res);
        }
        //Тригонометрия3(4)
        [TestMethod]
        public void Test3Trigonometryac77ab7()
        {
            double ac = 77;
            double ab = 7;
            double wait = 11;
            double res = Trigonometry2.FourthTask(ac, ab);
            Assert.AreEqual(wait, res);
        }
        //Тригонометрия1(5)
        [TestMethod]
        public void Test3Trigonometryac3ab3()
        {
            double ac = 3;
            double ab = 3;
            double wait = 1;
            double res = Trigonometry2.FifthTask(ac, ab);
            Assert.AreEqual(wait, res);
        }
        //Тригонометрия2(5)
        [TestMethod]
        public void Test3Trigonometryac10ab2()
        {
            double ac = 10;
            double ab = 2;
            double wait = 5;
            double res = Trigonometry2.FifthTask(ac, ab);
            Assert.AreEqual(wait, res);
        }
        //Тригонометрия3(5)
        [TestMethod]
        public void Test3Trigonometryac12ab3()
        {
            double ac = 12;
            double ab = 3;
            double wait = 4;
            double res = Trigonometry2.FifthTask(ac, ab);
            Assert.AreEqual(wait, res);
        }
    }
}