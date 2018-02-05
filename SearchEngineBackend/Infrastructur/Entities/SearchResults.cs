using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructur.Entities
{
    public class SearchResults
    {
        public int Id { get; }
        public int SearchWordId { get; set; }
        public int DocumentId { get; set; }
        
    }
}
