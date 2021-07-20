using EntidadesCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;


namespace UnitTestEntidades
{
    [TestClass]
    public class Entidades_Tests
    {
        #region Product Tests
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
        #endregion

        #region Exeption Tests
        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void SqlConnectionExeption_InvalidPath()
        {
            // arrange
            List<Product> lista = null;
            // pasamos una ruta invalida
            string connectionString = "Data Source=INVALIDO;Initial Catalog=Products;Integrated Security=True";
            // assert
            lista = SQL<Product>.QueryBD(connectionString, "Select * from Notebooks");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidQueryException))]
        [DataRow(null, "prueba")]
        [DataRow(null, null)]
        public void InvalidQueryExeption_WrongQuery(List<string> param1, string param2)
        {
            // arrange
            Thinkpad notebook = new Thinkpad("Thinkpad T430", 3000, EScreenSize.LargeScreen, 1, true);
            Factory.listaProductos.Add(notebook);
            List<string> thinkpadProperties;
            thinkpadProperties = Factory.GetProperties(Factory.listaProductos, "Thinkpad");
            // assert
            string query = SQL<Thinkpad>.BuildInsertQuery(param1, param2);
        }

        [TestMethod]
        [ExpectedException(typeof(NullPathException))]
        public void SerializeXmlExeption_NullPath()
        {
            Thinkpad notebook = new Thinkpad();
            Serializator<Thinkpad> serializer = new Serializator<Thinkpad>();
            bool output = serializer.SaveXML(null, notebook);
        }

        [TestMethod]
        [ExpectedException(typeof(NullPathException))]
        public void DeserializeXmlExeption_NullPath()
        {
            Thinkpad notebook = null;
            Serializator<Thinkpad> serializer = new Serializator<Thinkpad>();
            notebook = serializer.OpenXML(null, notebook);
        }
        #endregion

        #region ExtensionMethod Test
        [TestMethod]
        public void ListExtensionMethod_False()
        {
            // arrange
            bool contais = true;
            List<Product> productos = new List<Product>()
            {
                new Thinkpad("Thinkpad T420", 2300, EScreenSize.MediumScreen, 0, false),
                new Thinkpad("Thinkpad T450", 4000, EScreenSize.LargeScreen, 1, true),
            };
            // act
            contais = productos.ContainsType("MechanicalKeyboard");
            // assert
            Assert.IsFalse(contais);
        }
        [TestMethod]
        public void ListExtensionMethod_True()
        {
            // arrange
            bool contais = false;
            List<Product> productos = new List<Product>()
            {
                new Thinkpad("Thinkpad T420", 2300, EScreenSize.MediumScreen, 0, false),
                new MechanicalKeyboard("Poker3", 1500, EKeyboardSize.Small),
                new Thinkpad("Thinkpad T450", 4000, EScreenSize.LargeScreen, 1, true),
                new MechanicalKeyboard("XD75", 3900, EKeyboardSize.Tenkeyless)
            };
            // act
            contais = productos.ContainsType("MechanicalKeyboard");
            // assert
            Assert.IsTrue(contais);
        }
        #endregion
    }
}
