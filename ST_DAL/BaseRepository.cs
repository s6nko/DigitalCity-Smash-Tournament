using ST_DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_DAL
{
    public class BaseRepository<T>
    {
        T Get(id);
        void Update();
        void Delete();
        T Create( Player player );
    }
}
