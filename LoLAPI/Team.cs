using Newtonsoft.Json;
using System.Collections.Generic;

namespace LoLAPI
{
    public class Team
    {
        [JsonProperty(PropertyName = "win")]
        public bool Win { get; private set; }
        public List<Participant> TeamMembers { get; set; }

        public Team()
        {
            TeamMembers = new List<Participant>();
        }

    }
}
