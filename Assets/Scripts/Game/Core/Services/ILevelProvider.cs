using Cysharp.Threading.Tasks;
using Game.Core.Models;
using System.Collections.Generic;

namespace Game.Core.Services
{
    public interface ILevelProvider
    {
        public UniTask<IReadOnlyList<LevelModel>> LoadLevelsAsync();
    }
}