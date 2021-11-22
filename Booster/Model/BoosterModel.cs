using Agate.MVC.Base;

namespace Agate.Game.Booster
{
    public class BoosterModel : BaseModel, IBoosterModel
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

        public void SetName(string name)
        {
            this.Name = name;
            SetDataAsDirty();
        }
        public void SetDescription(string description)
        {
            this.Description = description;
            SetDataAsDirty();
        }
        public void SetPrice(double price)
        {
            this.Price = price;
            SetDataAsDirty();
        }
    }
}
