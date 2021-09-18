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
		string myConn = "Data Source=.;Initial Catalog=KDSP;Integrated Security=True;";
		public DataTable GetPatientWaitings()
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
	}
}
