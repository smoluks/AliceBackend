namespace Alice.Backend.DTO
{
    public class MessageResponce
    {
        public MessageResponce(string text, Session session)
        {
            this.session = session;
            this.response = new Response()
            {
                text = text
            };
        }

        public string version { get; set; } = "1.0";

        public Session session { get; set; }

        public Response response { get; set; }
    }

    public class Response
    {
        public string text { get; set; }

        public bool end_session { get; set; }
    }
}
