using System.Data;
using System.Data.SqlClient;
namespace DAL
{
  public  class MessageDAL:DataBase
    {
        public DataSet D_Messages_Insert(string MessageBody,string ToUser,string FromUser,string MessageIcon,int UserId)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "D_Message_Insert";
            cmd.Parameters.AddWithValue("@MessageBody", MessageBody);
            cmd.Parameters.AddWithValue("@ToUser", ToUser);
            cmd.Parameters.AddWithValue("@FromUser", FromUser);
            cmd.Parameters.AddWithValue("@MessageIcon", MessageIcon);
            cmd.Parameters.AddWithValue("@UserId", UserId);

            return ExDatataBase_returnDataSet(cmd);
        }
    }
}
