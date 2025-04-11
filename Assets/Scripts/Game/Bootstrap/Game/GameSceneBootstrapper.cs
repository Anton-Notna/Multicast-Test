using Game.Shared.SceneManagement;
using Zenject;

namespace Game.Bootstrap.Game
{
    public class GameSceneBootstrapper : MonoInstaller, ISceneBootstrapper<GameScenePayload>
    {
        private GameScenePayload _payload;

        public void Bootstrap(GameScenePayload payload)
        {
            _payload = payload;
        }

        public override void InstallBindings()
        {
            Container.BindInstance(_payload.Level).AsSingle();
        }
    }
}