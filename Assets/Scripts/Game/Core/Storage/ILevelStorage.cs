using Game.Core.Models;
using System.Collections.Generic;

namespace Game.Core.Storage
{
    public interface ILevelStorage
    {
        IReadOnlyList<LevelModel> Levels { get; }

        void SetLevels(IReadOnlyList<LevelModel> levels);
    }
}