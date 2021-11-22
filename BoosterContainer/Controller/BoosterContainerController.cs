using Agate.MVC.Base;
using System.Collections;
using Agate.Game.Booster;

namespace Agate.Game.BoosterContainer
{
    public class BoosterContainerController : ObjectController<BoosterContainerController, BoosterContainerView>
    {
        //array ini digunakan sementara untuk test
        private string[] customName = new string[]
        {
            "1-DAY TIME LEAP", 
            "7-DAY TIME LEAP",
            "14-DAY TIME LEAP",
            "30-DAY TIME LEAP",

            "Permanent Buff x2",
            "Permanent Buff x3",
            "Permanent Buff x4",
        };

        private string[] customDescription = new string[]
        {
            "Get a total of 1 day income instantly",
            "Get a total of 7 day income instantly",
            "Get a total of 14 day income instantly",
            "Get a total of 30 day income instantly",

            "Gain permanent multiplier by x2",
            "Gain permanent multiplier by x3",
            "Gain permanent multiplier by x4"
        };

        private double[] customPrice = new double[]
        {
            2,
            12,
            25,
            50,

            20,
            29,
            35
        };

        public IEnumerator InitContainer(BoosterContainerView view)
        {
            InstantiateAllBooster(view);
            yield return null;
        }

        public void InstantiateAllBooster(BoosterContainerView view)
        {
            int boosterSize = 7;//misal ada 19 booster
            int boosterCount = boosterSize;//untuk menghitung booster apabila telah terinstantiate
            int horizontalLayoutCount = 0;
            int boosterIndex = 0;

            if(boosterSize % 2 == 0)//cek apabila jumlah total booster genap / ganjil, untuk penyesuaian horizontal layout
            {
                horizontalLayoutCount = boosterSize / 2;
            }
            else
            {
                horizontalLayoutCount = (boosterSize / 2) + 1;
            }

            for(int i = 0; i < horizontalLayoutCount; i++)
            {
                view.InstantiateHorizontalLayout();
                for(int j = 0; j < 2; j++)
                {
                    boosterCount--;
                    if(boosterCount < 0)
                    {
                        break;
                    }
                    InstantiateBooster(view, boosterIndex);
                    boosterIndex++;
                }
            }
        }

        private void InstantiateBooster(BoosterContainerView view, int index)
        {
            view.InstantiateBoosterPrefab(SetBooster(index));//menggunakan ini dapat mengubah tampilan view per item booster sesuai array custom diatas
            //view.InstantiateBoosterPrefab(SetBooster());//menggunakan ini akan menampilkan booster yang sama
        }

        private BoosterController SetBooster(int index = 0)
        {
            BoosterController boosterController = new BoosterController();

            boosterController.SetName(customName[index]);
            boosterController.SetDescription(customDescription[index]);
            boosterController.SetPrice(customPrice[index]);
            boosterController.SetOnClickHandler(SetOnClickHandler);

            return boosterController;
        }

        public void SetOnClickHandler()
        {

        }
    }
}
