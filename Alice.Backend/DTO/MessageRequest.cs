using System;
using System.Text.Json.Serialization;

namespace Alice.Backend.DTO
{
    public class MessageRequest
    {
        public Meta meta { get; set; }

        public Session session { get; set; }

        public Request request { get; set; }

        public string version { get; set; }        
    }

    public class Meta
    {
        public string locale { get; set; }

        public string timezone { get; set; }

        public string client_id { get; set; }

        public Interfaces interfaces { get; set; }
    }

    public class Interfaces
    {
        //Screen screen { get; set; }

        //Payments payments { get; set; }

        //AccountLinking account_linking { get; set; }
    }

    public class Request
    {
        public string command { get; set; }

        public string original_utterance { get; set; }

        public Nlu nlu { get; set; }

        public Markup markup { get; set; }

        public string type { get; set; }
    }

    public class Nlu
    {
        public string[] tokens { get; set; }

        public string[] entities { get; set; }

        //Intents intents { get; set; }
    }

    public class Markup
    {
        public bool dangerous_context { get; set; }
    }
}
