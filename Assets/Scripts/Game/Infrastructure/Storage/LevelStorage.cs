using Game.Core.Models;
using Game.Core.Storage;
using System;
using System.Collections.Generic;

namespace Game.Infrastructure.Storage
{
    public class LevelStorage : ILevelStorage
    {
        public IReadOnlyList<LevelModel> Levels { get; private set; } = Array.Empty<LevelModel>();

        public void SetLevels(IReadOnlyList<LevelModel> levels)
        {
            if (levels == null || levels.Count == 0)
                throw new ArgumentException("Level list must not be null or empty");

            Levels = levels;
        }
    }
}