using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class DataBase
    {
        public DataSet ExDatataBase_returnDataSet(SqlCommand cmd)
        {

            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            int i = 0;
            string sql = null;

            connetionString = ConfigurationManager.AppSettings["con"].ToString();

            connection = new SqlConnection(connetionString);

            try
            {
                connection.Open();
                command = new SqlCommand();
                command = cmd;
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();


                return ds;
            }
            catch (Exception ex)
            {

            }
            return ds;
        }
    }

}
