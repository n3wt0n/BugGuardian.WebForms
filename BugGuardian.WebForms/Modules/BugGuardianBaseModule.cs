using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace DBTek.BugGuardian.WebForms.Modules
{
    public abstract class BugGuardianBaseModule : IHttpModule
    {
        public void Init(HttpApplication httpApplication)
        {
            httpApplication.Error += new EventHandler(Report);
        }

        public abstract void Report(object sender, EventArgs e);

        public void Dispose()
        {
            // Left blank because we dont have to do anything.
        }
    }
}
