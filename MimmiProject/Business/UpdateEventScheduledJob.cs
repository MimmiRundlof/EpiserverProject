using System;
using System.Globalization;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.PlugIn;
using EPiServer.Scheduler;
using EPiServer.ServiceLocation;
using MimmiProject.Models.Pages;

namespace MimmiProject.Business
{
    [ScheduledPlugIn(DisplayName = "UpdateEventScheduledJob")]
    public class UpdateEventScheduledJob : ScheduledJobBase
    {
        private readonly IContentRepository _repo = ServiceLocator.Current.GetInstance<IContentRepository>();



        private bool _stopSignaled;

        public UpdateEventScheduledJob()
        {
            IsStoppable = true;
        }

        /// <summary>
        /// Called when a user clicks on Stop for a manually started job, or when ASP.NET shuts down.
        /// </summary>
        public override void Stop()
        {
            _stopSignaled = true;
        }

        /// <summary>
        /// Called when a scheduled job executes
        /// </summary>
        /// <returns>A status message to be stored in the database log and visible from admin mode</returns>
        public override string Execute()
        {
            //Call OnStatusChanged to periodically notify progress of job for manually started jobs
            OnStatusChanged(String.Format("Starting execution of {0}", this.GetType()));


            var page = new PageReference(1109);


            EventPage eventPage = _repo.Get<EventPage>(page).CreateWritableClone() as EventPage;


            if (eventPage != null)
            {
                var date = new DateTime(2019,7,9,10,00,00);
                eventPage.Heading = "Fredags-event!!";
                eventPage.Date = date;
                _repo.Save(eventPage, EPiServer.DataAccess.SaveAction.Publish,
                EPiServer.Security.AccessLevel.NoAccess);


            }

                //For long running jobs periodically check if stop is signaled and if so stop execution
                if (_stopSignaled)
            {
                return "Stop of job was called";
            }

            return "Change to message that describes outcome of execution";
        }
    }
}
