using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;



namespace darwinBoxAttendance
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://siplayerhub.darwinbox.in/attendance");

            driver.Manage().Window.Maximize();

            FunctionalLibrary.TypeAction(driver, "UserLogin_username", "id", "SI2055");

            FunctionalLibrary.TypeAction(driver, "UserLogin_password", "id", "Sportz@123");

            FunctionalLibrary.DropDown(driver, "//*[@class='form-group db-form-group']/select", "Attendance");

            FunctionalLibrary.clickAction(driver, "login-submit", "id");

          //  string txt = FunctionalLibrary.ElementText(driver, "//span[contains(text(),'Absent')]");

         
                //string date = DateTime.Today.ToString();

                //string cdate = date.Substring(0, 2);

                //int date1 = Convert.ToInt32(cdate);


                //int Rdate = date1 - 1;

                //Console.WriteLine(Rdate);

                //Thread.Sleep(2000);

                FunctionalLibrary.waitForElement(driver, "//*[@id='attendance_request']");

                FunctionalLibrary.clickAction(driver, "attendance_request", "id");


                Thread.Sleep(2000);

                FunctionalLibrary.waitForElement(driver, "//*[@class='al-other-than-shift']/div/div");

                FunctionalLibrary.MouseOver(driver, "//*[@class='al-other-than-shift']/div/div");

                FunctionalLibrary.clickAction(driver, "//*[@class='al-other-than-shift']/div/div", "xpath");


                Thread.Sleep(2000);

                FunctionalLibrary.clickAction(driver, "//*[@class='al-other-than-shift']/div/div/div[2]/div[2]", "xpath");


                //FunctionalLibrary.clickAction(driver, "//*[@class='al-request-log-form-container']/div[1]", "xpath");

                //FunctionalLibrary.waitForElement(driver, "//a[contains(text(),'" + Rdate + "')]");

                //FunctionalLibrary.clickAction(driver, "//a[contains(text(),'" + Rdate + "')]", "xpath");

                //FunctionalLibrary.waitForElement(driver, "//input[@id='punchin-date-to']");

                //FunctionalLibrary.clickAction(driver, "//input[@id='punchin-date-to']", "xpath");

                //FunctionalLibrary.waitForElement(driver, "//a[@class='ui-state-default'][contains(text(),'" + Rdate + "')]");

                //FunctionalLibrary.clickAction(driver, "//a[@class='ui-state-default'][contains(text(),'" + Rdate + "')]", "xpath");


                FunctionalLibrary.clickAction(driver, "/html/body/div[2]/div[1]/div/div[11]/div/div/div/div[2]/form/div[1]/div[6]/div[3]/div/input", "xpath");

                FunctionalLibrary.waitForElement(driver, "/html/body/div[2]/div[1]/div/div[11]/div/div/div/div[2]/form/div[1]/div[6]/div[3]/div/div[2]/div[1]");

                FunctionalLibrary.clickAction(driver, "/html/body/div[2]/div[1]/div/div[11]/div/div/div/div[2]/form/div[1]/div[6]/div[3]/div/div[2]/div[1]", "xpath");


                Thread.Sleep(2000);

                FunctionalLibrary.TypeAction(driver, "//textarea[@id='AttendanceRequestForm_message']", "xpath", "Work form Home Request");



                FunctionalLibrary.clickAction(driver, "//input[@id='add_request_btn']", "xpath");
            
        }

        //[TestMethod]

        //public void temp()
        //{

        //    IWebDriver driver = new ChromeDriver();

        //    driver.Navigate().GoToUrl("https://siplayerhub.darwinbox.in/attendance");

        //    driver.Manage().Window.Maximize();

        //    FunctionalLibrary.TypeAction(driver, "UserLogin_username", "id", "SI2055");

        //    FunctionalLibrary.TypeAction(driver, "UserLogin_password", "id", "Sportz@123");

        //    FunctionalLibrary.DropDown(driver, "//*[@class='form-group db-form-group']/select", "Attendance");

        //    FunctionalLibrary.clickAction(driver, "login-submit", "id");

        //    //string date = DateTime.Today.ToString();

        //    //string cdate = date.Substring(0, 2);

        //    //int date1 = Convert.ToInt32(cdate);


        //    //int Rdate = date1 - 1;

        //    FunctionalLibrary.clickAction(driver, "/html/body/div[2]/div[1]/div/div[3]/section/div/div/div[1]/div[2]/div/div[2]/div[1]/a[2]","xpath");


        //    //FunctionalLibrary.MouseOver(driver, "//*[@id='2020-05-08']/parent::td/parent::tr");

        //    //string txt = FunctionalLibrary.ElementText(driver, "//*[@id='2020-05-08']/parent::td/parent::tr");

        //    //Console.WriteLine(txt);

        //    for(int i=1;i<=31;i++)
        //    {

        //        FunctionalLibrary.waitForElement(driver, "//table[@id='attendance_log']/tbody/tr[" + i + "]/td[5]/a/font/b");

        //        FunctionalLibrary.MouseOver(driver, "//table[@id='attendance_log']/tbody/tr[" + i + "]/td[5]/a/font/b");

        //        FunctionalLibrary.javaScroll(driver, "//table[@id='attendance_log']/tbody/tr[" + i + "]/td[5]/a/font/b");
        //        string txte2 = FunctionalLibrary.ElementText(driver, "//table[@id='attendance_log']/tbody/tr[" + i + "]/td[5]/a/font/b");

        //        Console.WriteLine(txte2);

        //    }
              
        //}
    }
}
