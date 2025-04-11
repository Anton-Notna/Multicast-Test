using Game.Bootstrap.SceneDefinitions;
using Game.Shared.SceneManagement;

namespace Game.Bootstrap.MainMenu
{
    public class MainMenuPayload : IScenePayload
    {
        public string TargetScene => GameScene.MainMenu.ToString();
    }
}