using UnityEngine;
using Zenject;

namespace Assets.Scripts
{
    [RequireComponent(typeof(SwipeHandler))]
    public class SwipeHandlerInstaller : MonoInstaller
    {
        private SwipeHandler _swipeHandler;

        public override void InstallBindings()
        {
            _swipeHandler = GetComponent<SwipeHandler>();
            Container.Bind<SwipeHandler>().
            FromInstance(_swipeHandler).
            AsSingle().
            NonLazy();
        }
    }
}