﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Hw2
{
    [TestFixture]
    class ParseDataTest
    {
        [Test]
        public void ParseGroceryTest()
        {
            try
            {
                string filePath = @"C:\Users\Smruti\Documents\SMRUTI\STUDIES\Loyola\Open Source Computing\Hw2\Hw2_chicago_data_challenge\Hw2\Hw2\data\testData\Grocery_Stores_2013.csv";
                ParseData pd = new ParseData();
                Hw2.ParseData.Grocery[] groceryData = pd.ParseGrocery(filePath);
                Assert.AreEqual(groceryData[0].licenseID, "980");
            }
            catch (FileNotFoundException ex)
            {
                Assert.Fail("File Not Available");
               // Console.WriteLine("File Not available {0} ", ex.StackTrace);
            }
            catch (Exception e)
            {
                //Console.WriteLine("Problem in parsing data {0} ", e.StackTrace);
                Assert.Fail("Problem in parsing {0}", e.StackTrace);
            }

        }
        [Test]
        public void ParseFoodInspectionTest()
        {
            try
            {
                string filePath = @"C:\Users\Smruti\Documents\SMRUTI\STUDIES\Loyola\Open Source Computing\Hw2\Hw2_chicago_data_challenge\Hw2\Hw2\data\testData\Food_Inspections_Test_Grocery_2013.csv";
                ParseData pd = new ParseData();
                Hw2.ParseData.FoodInspection[] foodInspectionData = pd.ParseFoodInspection(filePath);
                Assert.AreEqual(foodInspectionData[0].storeLicenseID, "2391097");
                                              
               
            }
            catch (FileNotFoundException ex)
            {
                Assert.Fail("File Not Available");
                // Console.WriteLine("File Not available {0} ", ex.StackTrace);
            }
            catch (Exception e)
            {
                //Console.WriteLine("Problem in parsing data {0} ", e.StackTrace);
                Assert.Fail("Problem in parsing {0}", e.StackTrace);
            }

        }
        [Test]
        public void TestForNotGrocery2013()
        {
            try
            {
                string filePath = @"C:\Users\Smruti\Documents\SMRUTI\STUDIES\Loyola\Open Source Computing\Hw2\Hw2_chicago_data_challenge\Hw2\Hw2\data\testData\Food_Inspections_Test_NotGrocery_2013.csv";
                ParseData pd = new ParseData();
                Hw2.ParseData.FoodInspection[] foodInspectionData = pd.ParseFoodInspection(filePath);
                Assert.AreEqual(foodInspectionData[0].storeLicenseID, "2391097");


            }
            catch (FileNotFoundException ex)
            {
                Assert.Fail("File Not Available");
                // Console.WriteLine("File Not available {0} ", ex.StackTrace);
            }
            catch (Exception e)
            {
                //Console.WriteLine("Problem in parsing data {0} ", e.StackTrace);
                Assert.Fail("The parsed data is not a grocery store");
            }

        }
        [Test]
        public void TestForGroceryNot2013()
        {
            try
            {
                string filePath = @"C:\Users\Smruti\Documents\SMRUTI\STUDIES\Loyola\Open Source Computing\Hw2\Hw2_chicago_data_challenge\Hw2\Hw2\data\testData\Food_Inspections_Test_Grocery_Not2013.csv";
                ParseData pd = new ParseData();
                Hw2.ParseData.FoodInspection[] foodInspectionData = pd.ParseFoodInspection(filePath);
                Assert.AreEqual(foodInspectionData[0].storeLicenseID, "2391097");


            }
            catch (FileNotFoundException ex)
            {
                Assert.Fail("File Not Available");
                // Console.WriteLine("File Not available {0} ", ex.StackTrace);
            }
            catch (Exception e)
            {
                //Console.WriteLine("Problem in parsing data {0} ", e.StackTrace);
                Assert.Fail("The Grocery Store was not inspected in 2013");
            }

        }

        [Test]

        public void TestForNotGroceryNot2013()
        {
            try
            {
                string filePath = @"C:\Users\Smruti\Documents\SMRUTI\STUDIES\Loyola\Open Source Computing\Hw2\Hw2_chicago_data_challenge\Hw2\Hw2\data\testData\Food_Inspections_Test_NotGrocery_Not2013.csv";
                ParseData pd = new ParseData();
                Hw2.ParseData.FoodInspection[] foodInspectionData = pd.ParseFoodInspection(filePath);
                Assert.AreEqual(foodInspectionData[0].storeLicenseID, "2391097");


            }
            catch (FileNotFoundException ex)
            {
                Assert.Fail("File Not Available");
                // Console.WriteLine("File Not available {0} ", ex.StackTrace);
            }
            catch (Exception e)
            {
                //Console.WriteLine("Problem in parsing data {0} ", e.StackTrace);
                Assert.Fail("The parsed data is not a Grocery Store and was not inspected in the year 2013");
            }

        }

      


        public void ParseBuildingInspectionTest()
        {

        }


    }
}
