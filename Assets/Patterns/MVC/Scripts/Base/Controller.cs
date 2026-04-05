using System.Collections.Generic;
using UnityEngine;

namespace Patterns.MVC
{
    public abstract class Controller<T> : MonoBehaviour where T : Model
    {
        protected List<IView> views;
        protected T model;

        private void Awake() => Initialize();
        private void OnDestroy() => UnsubscribeAllViews();

        private void Initialize()
        {
            views = new();

            ModelInitialize();
            ViewsInitialize();
        }

        protected abstract void ModelInitialize();
        protected abstract void ViewsInitialize();

        protected void InitializeView(IView view)
        {
            views.Add(view);

            view.Initialize();
            view.Subscribe();
        }

        private void UnsubscribeAllViews() => views.ForEach(x => x.Unsubscribe());

        public void Activate() => this.gameObject.SetActive(true);
        public void Deactivate() => this.gameObject.SetActive(false);
    }
}