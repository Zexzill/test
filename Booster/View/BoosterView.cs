using Agate.MVC.Base;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Agate.Game.Booster
{
    public class BoosterView: ObjectView<IBoosterModel>
    {
        [SerializeField] protected Text _name;
        [SerializeField] protected Text _description;
        [SerializeField] protected Text _price;

        [SerializeField] protected Button _buyButton;
        protected override void InitRenderModel(IBoosterModel model)
        {
            _name.text = model.Name;
            _description.text = model.Description;
            _price.text = model.Price.ToString("F2");
        }

        protected override void UpdateRenderModel(IBoosterModel model)
        {

        }

        public void SetOnClickHandler(UnityAction callback)
        {
            _buyButton.onClick.AddListener(callback);
        }
    }
}
