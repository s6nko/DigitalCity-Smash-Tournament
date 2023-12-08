using ST_DOMAIN.Entities;

namespace ST_BLL.Interfaces
{
    public interface IPlayerRepository
    {
        Player Get(int id);
        void Update( Player player );
        void Delete( Player player );
        Player Create( Player player );
    }
}
