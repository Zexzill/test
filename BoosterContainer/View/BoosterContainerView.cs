using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.UI;
using Agate.Game.Booster;

namespace Agate.Game.BoosterContainer
{
    public class BoosterContainerView : BaseView
    {
        [SerializeField] protected BoosterView _view;
        [SerializeField] protected HorizontalLayoutGroup _horizontalLayoutPrefab;
        [SerializeField] protected VerticalLayoutGroup _verticalLayout;
        [SerializeField] protected RectTransform _verticalLayoutRectTransform;

        protected HorizontalLayoutGroup _lastInstantiatedHorizontalLayout;
        protected BoosterView _lastInstantiatedBoosterPrefab;

        public void InstantiateHorizontalLayout()
        {
            _lastInstantiatedHorizontalLayout = Instantiate(_horizontalLayoutPrefab, transform);
            _lastInstantiatedHorizontalLayout.transform.SetParent(_verticalLayout.transform);
            
            float horizontalLayoutHeight = _horizontalLayoutPrefab.GetComponent<RectTransform>().sizeDelta.y;

            _verticalLayoutRectTransform.sizeDelta += new Vector2(0, horizontalLayoutHeight);
        }

        public void InstantiateBoosterPrefab(BoosterController controller)
        {
            controller.SetView(_view);
            _lastInstantiatedBoosterPrefab = Instantiate(_view, transform);
            _lastInstantiatedBoosterPrefab.transform.SetParent(_lastInstantiatedHorizontalLayout.transform);
        }
    }
}
