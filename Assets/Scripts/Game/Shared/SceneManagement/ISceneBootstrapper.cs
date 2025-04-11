namespace Game.Shared.SceneManagement
{
    public interface ISceneBootstrapper<TPayload> where TPayload : IScenePayload
    {
        public void Bootstrap(TPayload payload);
    }
}