using System.Data;
using System.Collections.Generic;
using DAL;

namespace DBL
{
   public class UserDBL
    {
        UserDAL oUserDAL = new UserDAL();
        public List<POCO.User> D_Users_Get()
        {
            DataSet ds = new DataSet();
            POCO.User oUser = new POCO.User();
            List<POCO.User> oLUser = new List<POCO.User>();
            ds = oUserDAL.D_Users_Get();
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow dr in table.Rows)
                {
                    oUser = new POCO.User();
                    oUser.Name = dr["Name"].ToString();
                    oLUser.Add(oUser);
                }

            }
            return oLUser;

        }
    }
}
