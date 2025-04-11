using Game.Bootstrap.SceneDefinitions;
using Game.Shared.SceneManagement;

namespace Game.Bootstrap.Game
{
    public class GameScenePayload : IScenePayload
    {
        public string TargetScene => GameScene.Game.ToString();

        public object Level { get; }

        public GameScenePayload(object level)
        {
            Level = level;
        }
    }
}