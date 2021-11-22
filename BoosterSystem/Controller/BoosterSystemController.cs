using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using System.Collections.Generic;
using Agate.Game.BoosterContainer;
using Agate.Game.Database;

namespace Agate.Game.BoosterSystem
{
    public class BoosterSystemController : GroupController<BoosterSystemController>
    {
        private BoosterContainerController _boosterContainerController;

        protected override IController[] GetSubControllers()
        {
            return new IController[]
            {
                new BoosterContainerController()
            };
        }

        public IEnumerator InitContainer(BoosterContainerView view)
        {
            yield return _boosterContainerController.InitContainer(view);
        }

        public List<BoosterData> OnSave()
        {
            BoosterData obj = new BoosterData();
            return null;
        }
    }
}
