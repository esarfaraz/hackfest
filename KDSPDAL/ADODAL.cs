using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDSPDAL
{
    public class ADODAL
    {
		public static string myConn = "Data Source=.;Initial Catalog=KDSP;Integrated Security=True;";
		public static DataTable GetPatientWaitings()
		{
			string SelectQuery = "select * from v_PatientWaitingList where WLStatus = 'Waiting'";
			var datatable = new DataTable();
			using (SqlConnection con = new SqlConnection(myConn))
			{
				con.Open();
				using (SqlCommand com = new SqlCommand(SelectQuery, con))
				{
					using (SqlDataAdapter adapter = new SqlDataAdapter(com))
					{
						adapter.Fill(datatable);
					}
				}
			}
			return datatable;
		}

		public static DataTable GetAppointments(string TherapyType)
		{
			string SelectQuery = "select T.TherapistFullName, ts.ScheduleDate, ts.StartTime, ts.EndTime from TherapistSchedule ts, Therapists t " +
			"where ts.TherapistId = t.id and ts.ScheduleDate > getdate() and ts.Status = 'Available'";
			if (TherapyType == "OT")
            {
				SelectQuery += " and t.OTTherapist='Y' ";

			}
			else if (TherapyType== "PT")
            {
				SelectQuery += " and t.PTTherapist='Y' ";
			}
			else if (TherapyType == "ST")
			{
				SelectQuery += " and t.STTherapist='Y' ";
			}

			SelectQuery +="order by ts.ScheduleDate, ts.StartTime";
			var datatable = new DataTable();
			using (SqlConnection con = new SqlConnection(myConn))
			{
				con.Open();
				using (SqlCommand com = new SqlCommand(SelectQuery, con))
				{
					using (SqlDataAdapter adapter = new SqlDataAdapter(com))
					{
						adapter.Fill(datatable);
					}
				}
			}
			return datatable;
		}


		public static DataTable GetAppointmentsByTherapist(string TherapistId)
		{
			string SelectQuery = "select T.TherapistFullName, ts.ScheduleDate, ts.StartTime, ts.EndTime from TherapistSchedule ts, Therapists t " +
			$"where ts.TherapistId = t.id and ts.ScheduleDate > getdate() and t.Id ={TherapistId}";
			SelectQuery += "order by ts.ScheduleDate, ts.StartTime";
			var datatable = new DataTable();
			using (SqlConnection con = new SqlConnection(myConn))
			{
				con.Open();
				using (SqlCommand com = new SqlCommand(SelectQuery, con))
				{
					using (SqlDataAdapter adapter = new SqlDataAdapter(com))
					{
						adapter.Fill(datatable);
					}
				}
			}
			return datatable;
		}
	}
}
