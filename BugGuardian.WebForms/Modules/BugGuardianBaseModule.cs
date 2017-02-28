using DBTek.BugGuardian.WebForms.Helpers;
using System;
using System.Threading.Tasks;
using System.Web;

namespace DBTek.BugGuardian.WebForms.Modules
{
    /// <summary>
    /// Thanks to Marco Minerva (@marcominerva, https://github.com/marcominerva)
    /// for the suggestion on the async implementation
    /// </summary>
    public abstract class BugGuardianBaseModule : IHttpModule
    {
        public BugGuardianBaseModule()
        {
            //SetUp the BugGuardian configuration
            Factories.ConfigurationFactory.SetConfiguration(ConfigurationHelper.Url,
                ConfigurationHelper.Username,
                ConfigurationHelper.Password,
                ConfigurationHelper.CollectiontName,
                ConfigurationHelper.ProjectName,
                ConfigurationHelper.AvoidMultipleReport);
        }

        public void Init(HttpApplication httpApplication)
            => httpApplication.AddOnEndRequestAsync(OnBegin, OnEnd);

        private IAsyncResult OnBegin(object sender, EventArgs e, AsyncCallback asyncCallback, object extraData)
        {
            var taskCompletionSource = new TaskCompletionSource<object>(extraData);

            ReportException(HttpContext.Current)
                .ContinueWith(t =>
                {
                    if (t.IsFaulted)
                        taskCompletionSource.SetException(t.Exception.InnerExceptions);
                    else
                        taskCompletionSource.SetResult(null);

                    asyncCallback?.Invoke(taskCompletionSource.Task);
                });

            return taskCompletionSource.Task;
        }

        public abstract Task ReportException(HttpContext ctx);

        private void OnEnd(IAsyncResult asyncResult)
        {
            var task = asyncResult as Task;
            task?.Wait();
        }

        public void Dispose()
        {
            // Left blank because we don't have to do anything.
        }
    }
}
