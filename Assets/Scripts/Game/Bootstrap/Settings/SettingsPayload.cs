using Game.Bootstrap.SceneDefinitions;
using Game.Shared.SceneManagement;

namespace Game.Bootstrap.Settings
{
    public class SettingsPayload : IScenePayload
    {
        public string TargetScene => GameScene.Settings.ToString();
    }
}