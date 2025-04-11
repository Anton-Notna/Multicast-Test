using System.Collections.Generic;

namespace Game.Core.Models
{
    public class LevelModel
    {
        public int Id { get; }
        public IReadOnlyList<IReadOnlyList<string>> Words { get; }

        public LevelModel(int id, IReadOnlyList<IReadOnlyList<string>> words)
        {
            Id = id;
            Words = words;
        }
    }
}