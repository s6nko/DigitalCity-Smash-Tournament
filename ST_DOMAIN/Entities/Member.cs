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
    [Table("Members")]
    internal class Member
    {
        public int Id { get; set; }
        public string Nickname { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public string Password { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public EGender sex;
        public ELevel Skill;
        public EAuthLevel AuthLevel;
        public int Elo;
    }
}
