using System.Diagnostics;
using System.ServiceProcess;
using RM.XOoutboundMessageService.Constants;
using System.Timers;
using RM.XOoutboundMessageService.ServiceInterface;
using RM.XOoutboundMessageService.ServiceImplementaion;
using System;

namespace RM.XOoutboundMessageService
{
    public partial class XOMessageService : ServiceBase
    {
        private Timer _timer;
        public XOMessageService()
        {
            InitializeComponent();
            IntitializeEventLog();
        }

        private void IntitializeEventLog()
        {
            if (!EventLog.SourceExists(Serviceconstants.EventLogSource))
                EventLog.CreateEventSource(Serviceconstants.EventLogSource, Serviceconstants.LogName);
            XomessageServiceEventLogger.Source = Serviceconstants.EventLogSource;
            XomessageServiceEventLogger.Log = Serviceconstants.LogName;
        }

        protected override void OnStart(string[] args)
        {
          
            _timer = new Timer { Interval = 1 * 5000, Enabled = true };
            _timer.Elapsed += new ElapsedEventHandler(this.ProcessXoMessages);

            XomessageServiceEventLogger.WriteEntry("Message Reader windows service started");

        }
        private void ProcessXoMessages(object sender, ElapsedEventArgs e)
        {
            try
            {
                _timer.Stop();
                IXOOutboundService _xboundServicemanager = new XoOutBoundService();
                _xboundServicemanager.SendXOOutboundMessage();
                _timer.Start();
            }
            catch (Exception ex)
            {
                XomessageServiceEventLogger.WriteEntry("Exception occured in ProcessXoMessages() method " + ex.Message);
            }

        }
        public void ProcessDebugXomessageService()
        {
            IXOOutboundService _xboundServicemanager = new XoOutBoundService();
            _xboundServicemanager.SendXOOutboundMessage();
        }

        protected override void OnStop()
        {
            {
                XomessageServiceEventLogger.WriteEntry("XOMessageService service stopped.");
            }
        }
    }
}

