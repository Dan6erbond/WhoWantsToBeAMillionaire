﻿using System.Collections.Generic;
using WhoWantsToBeAMillionaire.Models.Lifecycle.Games;

namespace WhoWantsToBeAMillionaire.Models.Data.Games
{
    public class GameSpecification : ISpecification<Game>
    {
        private readonly int? _userId;
        private readonly int? _gameId;
        
        public GameSpecification(int? userId = null, int? gameId = null)
        {
            _userId = userId;
            _gameId = gameId;
        }

        public bool Specificied(Game item)
        {
            if (_userId != null && _userId != item.UserId)
            {
                return false;
            }
            
            if (_gameId != null && _gameId != item.GameId)
            {
                return false;
            }

            return true;
        }
    }
}