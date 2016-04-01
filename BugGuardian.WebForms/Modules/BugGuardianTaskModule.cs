﻿using System;
using System.Web;

namespace DBTek.BugGuardian.WebForms.Modules
{
    public class BugGuardianTaskModule : BugGuardianBaseModule
    {
        /// <summary>
        /// Reports the Actual exception to VSTS/TFS via BugGuardian as Task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void Report(object sender, EventArgs e)
        {
            using (var creator = new Creator())
            {
                ///Implemented as synchronous because Asp.net 4 doesn't support async http modules
                creator.AddTask(HttpContext.Current?.Server?.GetLastError());
            }
        }
    }
}