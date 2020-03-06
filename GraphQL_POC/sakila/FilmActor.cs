using System;
using System.Collections.Generic;

namespace GraphQL_POC.sakila
{
    public partial class FilmActor
    {
        public short ActorId { get; set; }
        public short FilmId { get; set; }
        public DateTimeOffset LastUpdate { get; set; }

        public Actor Actor { get; set; }
        public Film Film { get; set; }
    }
}
