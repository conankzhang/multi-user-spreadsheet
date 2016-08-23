﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//bharath gunasekaran 
namespace SS
{
    /// <summary>
    /// Keeps track of how many top-level forms are running
    /// </summary>
    class DemoApplicationContext : ApplicationContext
    {
        // Number of open forms
        private int formCount = 0;

        // Singleton ApplicationContext
        private static DemoApplicationContext appContext;

        /// <summary>
        /// Private constructor for singleton pattern
        /// </summary>
        private DemoApplicationContext()
        {
        }

        /// <summary>
        /// Returns the one DemoApplicationContext.
        /// </summary>
        public static DemoApplicationContext getAppContext()
        {
            if (appContext == null)
            {
                appContext = new DemoApplicationContext();
            }
            return appContext;
        }

        /// <summary>
        /// Runs the form
        /// </summary>
        public void RunForm()
        {

            // One more form is running
            formCount++;
            new Thread(() =>
                {
                    Form1 newform = new Form1();
                    newform.FormClosed += (o, e) => { if (--formCount <= 0) ExitThread(); };
                    newform.ShowDialog();
                }
            ).Start();
            // When this form closes, we want to find out

            // Run the form
            //         form.ActiveControl = form;

        }



        public int getFormCount()
        {
            return formCount;
        }

    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DemoApplicationContext appContent = DemoApplicationContext.getAppContext();
            appContent.RunForm();
            Application.Run(appContent);
        }
    }
}
