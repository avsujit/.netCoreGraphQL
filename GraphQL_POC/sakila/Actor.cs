using System;
using System.Collections.Generic;

namespace GraphQL_POC.sakila
{
    public partial class Actor
    {
        public Actor()
        {
            FilmActor = new HashSet<FilmActor>();
        }

        public short ActorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset LastUpdate { get; set; }

        public ICollection<FilmActor> FilmActor { get; set; }
    }
}
