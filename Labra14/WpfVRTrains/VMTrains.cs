using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JAMK.IT
{
    public class TrainsVM
    {
        public static List<JAMK.IT.Train> GetTrainsAt(string station)
        {
            List<Train> trains = new List<Train>();
            if (station == "testi" || station == "")
            {
                //Vaihde1: Placebo palauttaa oikea muotoista dataa 
                // keksitään muutama juna
                Train tr = new Train();
                tr.TrainNumber = "666";
                tr.DepDate = new DateTime(2017, 3, 21);
                tr.TargetStation = "Higway to Hell";
                trains.Add(tr);
                
            }
            else
            {
                //Vaihde2: haetaan Liikenneviraston API:sta
                //muutetaan haettu json olio-kokoelmaksi
                string tmp = JAMK.IT.APTrain.GetJsonFROMLiikeVirasto(station);
                trains = JsonConvert.DeserializeObject<List<Train>>(tmp);
            }
            //palautus
            return trains;
        }
    }
}
