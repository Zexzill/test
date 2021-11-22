using Agate.MVC.Base;

namespace Agate.Game.Booster
{
    public interface IBoosterModel : IBaseModel
    {
        public string Name
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }

        public double Price
        {
            get; set;
        }
    }
}
