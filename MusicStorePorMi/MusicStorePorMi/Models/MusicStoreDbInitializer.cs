using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStorePorMi.Models
{
    public class MusicStoreDbInitializer 
        : System.Data.Entity.DropCreateDatabaseAlways<MusicStorePorMiContext>
    {
        protected override void Seed(MusicStorePorMiContext context)
        {
            context.Artists.Add(new Artist { Name = "Al Di Meola" });
            context.Genres.Add(new Genre { Name = "Jazz" });
            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Rush" },
                Genre = new Genre { Name = "Rock" },
                Price = 9.99m,
                Title = "Caravan"
            });
            base.Seed(context);
        }
    }
}