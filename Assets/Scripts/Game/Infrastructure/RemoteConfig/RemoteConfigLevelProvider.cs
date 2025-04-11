using Cysharp.Threading.Tasks;
using Game.Core.Models;
using Game.Core.Services;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Game.Infrastructure.RemoteConfig
{
    public class RemoteConfigLevelProvider : ScriptableObject, ILevelProvider
    {
        [SerializeField]
        private List<LevelDto> _localLevels;

        public async UniTask<IReadOnlyList<LevelModel>> LoadLevelsAsync()
        {
            return _localLevels.Select(level => level.AsLevelModel()).ToList();
        }
    }
}