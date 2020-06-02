
namespace POCO
{
  public class Message
    {
        public int Id { set; get; }
        public string MessageBody { set; get; }
        public string ToUser { set; get; }
        public string FromUser { set; get; }
        public string MessageIcon { set; get; }
        public int UserId { set; get; }
    }
}
