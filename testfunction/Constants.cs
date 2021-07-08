using System;
using System.Collections.Generic;
using System.Text;

namespace testfunction
{
    public class Constants
    {
        public const string ConnectionString = "Data Source=52.142.49.205;Initial Catalog=testdb;User ID=testadmin;Password=test@12345678";
        public const string SqlQuery ="SELECT * FROM sys.dm_os_wait_stats WHERE waiting_tasks_count > 0 ORDER BY wait_time_ms DESC";

		// Update customerId to your Log Analytics workspace ID
		public const string customerId = "8ed7b686-a493-4bc7-bc1f-76df6f5cd9d8";

		// For sharedKey, use either the primary or the secondary Connected Sources client authentication key   
		public const string sharedKey = "gRc+rTsuDeGIg7iEPF7du/UntAKztE7m+6yY2kJ1ZWiv1Kv+fuRO41Bs+IjUWS8rlF4lx8Yci3/BMSn6grxY4w==";

		// LogName is name of the event type that is being submitted to Azure Monitor
		public const string LogName = "DemoExample";

		// You can use an optional field to specify the timestamp from the data. If the time field is not specified, Azure Monitor assumes the time is the message ingestion time
		public const string TimeStampField = "";
	}
}
