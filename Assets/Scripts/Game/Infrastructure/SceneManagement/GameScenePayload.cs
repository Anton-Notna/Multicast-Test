using Game.Shared.SceneManagement;

namespace Game.Infrastructure.SceneManagement
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