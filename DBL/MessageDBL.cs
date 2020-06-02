using DAL;
using System.Data;

namespace DBL
{
    public class MessageDBL
    {
        MessageDAL oMessageDAL = new MessageDAL();
        public POCO.Message D_Message_Insert(POCO.Message PoMessage)
        {
            DataSet ds = new DataSet();
            POCO.Message oMessage = new POCO.Message();
            ds = oMessageDAL.D_Messages_Insert(PoMessage.MessageBody, PoMessage.ToUser, PoMessage.FromUser, PoMessage.MessageIcon, PoMessage.UserId);
            if (ds.Tables.Count > 0)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    oMessage.MessageBody= ds.Tables[0].Rows[0]["MessageBody"].ToString();
                    oMessage.ToUser = ds.Tables[0].Rows[0]["ToUser"].ToString();
                    oMessage.FromUser = ds.Tables[0].Rows[0]["FromUser"].ToString();
                    oMessage.MessageIcon = ds.Tables[0].Rows[0]["MessageIcon"].ToString();
                    oMessage.UserId =(int) ds.Tables[0].Rows[0]["UserId"];

                }

            }
            return oMessage;

        }

    }
}
