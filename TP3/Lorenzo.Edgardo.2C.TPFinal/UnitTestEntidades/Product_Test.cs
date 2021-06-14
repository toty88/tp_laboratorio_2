using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using EntidadesCore;

namespace UnitTestEntidades
{
    [TestClass]
    public class Product_Test
    {
        [TestMethod]

        public void IsProductDuplicated_False()
        {
            // arrange
            Random random = new Random();
            List<Product> list = new List<Product>();
            MechanicalKeyboard p1 = new MechanicalKeyboard("Poker 3", 1500, EKeyboardSize.FullSize);
            p1.Serial_Number = 10;
            list.Add(p1);
            MechanicalKeyboard p2 = new MechanicalKeyboard("Poker 3", 1600, EKeyboardSize.Small);
            p2.Serial_Number = 12;
            bool exit;
            // act
            exit = (list == p2);
            // assert
            Assert.IsFalse(exit);
        }

        [TestMethod]
        public void IsProductDuplicated_True()
        {
            // arrange
            Random random = new Random();
            List<Product> list = new List<Product>();
            MechanicalKeyboard p1 = new MechanicalKeyboard("Poker 3", 1500, EKeyboardSize.FullSize);
            p1.Serial_Number = 10;
            list.Add(p1);
            MechanicalKeyboard p2 = new MechanicalKeyboard("Poker 3", 1600, EKeyboardSize.Small);
            p2.Serial_Number = 12;
            list.Add(p2);
            bool exit;
            // act
            exit = (list == p2);
            // assert =
            Assert.IsTrue(exit);
        }
    }
}
