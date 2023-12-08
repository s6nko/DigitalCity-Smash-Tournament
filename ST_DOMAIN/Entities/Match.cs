using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_DOMAIN.Entities
{
    [Table("Matches")]
    public class Match
    {
        public int MatchID { get; set; }
        public List<Team> Teams { get; set; }
    }
}
