
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
 public class UserDAL:DataBase
    {
        public DataSet D_Users_Get()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "D_Users_Get";
            return ExDatataBase_returnDataSet(cmd);
        }
    }
}
