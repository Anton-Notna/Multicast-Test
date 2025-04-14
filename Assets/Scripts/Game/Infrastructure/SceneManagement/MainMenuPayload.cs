using Game.Shared.SceneManagement;

namespace Game.Infrastructure.SceneManagement
{
    public class MainMenuPayload : IScenePayload
    {
        public string TargetScene => GameScene.MainMenu.ToString();
    }
}