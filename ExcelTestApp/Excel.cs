using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;

namespace ExcelTestApp
{
    public class Excel
    {

        public static WindowsDriver<WindowsElement> AppiumSetUp()
        {
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("app", @"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE");
            appiumOptions.AddAdditionalCapability("deviceName", "WindowsPC");
            appiumOptions.AddAdditionalCapability("platformName", "Windows");

            // Create the WindowsDriver instance
            WindowsDriver<WindowsElement> driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/wd/hub"), appiumOptions);
            // driver.Manage().Window.Maximize();

            return driver;
        }

        public void startAppium()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/ C C:\Appium\node.exe C:\Appium\node_modules\appium\bin\appium.js--address 127.0.0.1--port 4723--automation - name Appium--log - no - color";
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
