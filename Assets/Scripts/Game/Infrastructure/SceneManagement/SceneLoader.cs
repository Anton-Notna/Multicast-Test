using System;
using Cysharp.Threading.Tasks;
using Game.Shared.SceneManagement;
using UnityEngine.SceneManagement;
using Zenject;

namespace Game.Infrastructure.SceneManagement
{
    public class SceneLoader
    {
        public async UniTask Load<TPayload>(TPayload payload) where TPayload : IScenePayload
        {
            await SceneManager.LoadSceneAsync(payload.TargetScene);

            var context = UnityEngine.Object.FindObjectOfType<SceneContext>();
            var bootstrappers = context.GetComponentsInChildren<ISceneBootstrapper<TPayload>>();

            if (bootstrappers.Length == 0)
                throw new Exception($"No bootstrapper found for payload type: {typeof(TPayload).Name}");

            if (bootstrappers.Length > 1)
                throw new Exception($"Multiple bootstrapper found for payload type: {typeof(TPayload).Name}");

            bootstrappers[0].Bootstrap(payload);
        }
    }
}