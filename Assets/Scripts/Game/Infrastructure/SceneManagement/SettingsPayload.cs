using Game.Shared.SceneManagement;

namespace Game.Infrastructure.SceneManagement
{
    public class SettingsPayload : IScenePayload
    {
        public string TargetScene => GameScene.Settings.ToString();
    }
}