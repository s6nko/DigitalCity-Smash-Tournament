using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_DOMAIN.Entities
{
    [Table("Teams")]
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public List<Player>? Players { get; set; }
        public Player TeamOwner { get; set; }
        public int PlayerCount { get; set; }
    }
}
