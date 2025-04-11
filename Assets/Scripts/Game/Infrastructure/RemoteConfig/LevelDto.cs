using Game.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Game.Infrastructure.RemoteConfig
{
    [Serializable]
    public class LevelDto
    {
        [Serializable]
        private class SerializableWord
        {
            [SerializeField, JsonProperty("clusters")]
            private List<string> _clusters;

            public IReadOnlyList<string> Clusters => _clusters;
        }

        [SerializeField, JsonProperty("id")]
        private int _id;
        [SerializeField, JsonProperty("words")]
        private List<SerializableWord> _words;

        public LevelModel AsLevelModel() => new LevelModel(_id, _words.Select(word => word.Clusters).ToList());
    }
}