using ST_BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ST_DOMAIN.Entities;

namespace ST_BLL.Services
{
    public class PlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService( IPlayerRepository playerRepository )
        {
            _playerRepository = playerRepository;
        }

        public void Delete(int id)
        {
            Player? player = _playerRepository.Get(id);
            if ( player != null )
            {
                _playerRepository.Delete(player);
            }
        }

        public Player Register(string nickname, string password, string email)
        {
            return _playerRepository.Create(new Player
            {
                Nickname = nickname ,
                Password = password ,
                Mail = email
            });
        }
    

    }
}
