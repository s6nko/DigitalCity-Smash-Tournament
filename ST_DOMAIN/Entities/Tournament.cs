using ST_DOMAIN.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_DOMAIN.Entities
{
    [Table("Tournament")]
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Place { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public DateTime EndSignUpsDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public EStatus Status { get; set; }
        public int CurrPlayers;
        public int MinPlayers;
        public int MaxPlayers;
        public int MinElo;
        public int MaxElo;
        public int CurrRound;
        public int MaxRounds;
        public EGender? GenderOnly;
    }
}
