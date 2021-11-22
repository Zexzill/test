using Agate.MVC.Base;
//using Agate.Game.Shop;
using UnityEngine.Events;

namespace Agate.Game.Booster
{
    public class BoosterController : ObjectController<BoosterController, BoosterModel, IBoosterModel, BoosterView>
    {
        public override void SetView(BoosterView view)
        {
            base.SetView(view);
        }

        //public void Buy(IShopItem<Gold> shopItem)
        //{
            //shopItem.Buy();
        //}

        public void SetName(string value)
        {
            _model.SetName(value);
        }

        public string GetName()
        {
            return _model.Name;
        }

        public void SetDescription(string value)
        {
            _model.SetDescription(value);
        }

        public void SetPrice(double value)
        {
            _model.SetPrice(value);
        }

        public void SetOnClickHandler(UnityAction callback)
        {
            //_view.SetOnClickHandler(callback);
        }
    }
}
