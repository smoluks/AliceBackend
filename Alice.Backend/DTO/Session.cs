using System;
using System.Text.Json.Serialization;

namespace Alice.Backend.DTO
{
    public class Session
    {
        public int message_id { get; set; }

        public Guid session_id { get; set; }

        public Guid skill_id { get; set; }

        public User user { get; set; }

        public Application application { get; set; }

        public string user_id { get; set; }

        [JsonPropertyName("new")]
        public bool isNew { get; set; }

        public class User
        {
            public string user_id { get; set; }
        }

        public class Application
        {
            public string application_id { get; set; }
        }
    }
}
