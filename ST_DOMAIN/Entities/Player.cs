using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using ST_DOMAIN.Enums;


namespace ST_DOMAIN.Entities
{
    [Table("Players")]
    public class Player
    {
        public int PlayerId { get; set; }
        public string Nickname { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public string Password { get; set; } = null!;

        public Team PlayerTeam { get; set; }
        public DateTime DateOfBirth { get; set; }
        public EGender sex { get; set; }
        public ELevel Skill { get; set; }
        public EAuthLevel AuthLevel { get; set; }
        public int Elo { get; set; }
    }
}
