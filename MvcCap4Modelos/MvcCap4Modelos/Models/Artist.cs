using System.Collections.Generic;

namespace MvcCap4Modelos.Models
{
    public class Artist
    {
        public virtual int GenreId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}