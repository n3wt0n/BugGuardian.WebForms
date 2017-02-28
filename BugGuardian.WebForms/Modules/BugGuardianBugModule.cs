using System.Threading.Tasks;
using System.Web;

namespace DBTek.BugGuardian.WebForms.Modules
{
    public class BugGuardianBugModule : BugGuardianBaseModule
    {
        /// <summary>
        /// Reports the Actual exception to VSTS/TFS via BugGuardian as Bug
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override async Task ReportException(HttpContext ctx)
        {
            var exception = ctx.Server.GetLastError();
            if (exception != null)
            {
                using (var manager = new BugGuardianManager())
                {
                    await manager.AddBugAsync(exception);
                }
            }
        }
    }
}
