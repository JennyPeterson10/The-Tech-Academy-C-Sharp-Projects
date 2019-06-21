using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SetLists.Models
{
    public class SetList
    {
        public int SetListID { get; set; }
        public string Title { get; set; }

        public virtual ICollection<SongSetList> SongSetLists { get; set; }
    }
}