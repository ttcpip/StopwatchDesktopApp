﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using StopwatchDesktopApp.src.forms;

namespace StopwatchDesktopApp.src
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var config = Config.LoadFromFile("./config.dat");

            // Set system language as current language for the strings manager
            var currentLangName = Thread.CurrentThread.CurrentCulture.Name;
            var _lang = StringsManager.StringToLang(currentLangName);
            var lang = _lang != Language.Undefined ? _lang : Language.English;
            var stringsManager = new StringsManager(config, lang);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.Run(new FrmMain(config, stringsManager));
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Unhandled Thread Exception");
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show((e.ExceptionObject as Exception).Message, "Unhandled UI Exception");
        }
    }
}
