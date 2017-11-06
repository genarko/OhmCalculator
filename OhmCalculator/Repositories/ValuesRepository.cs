using System.Collections.Generic;
using System.Web.Mvc;

namespace OhmCalculator.Repositories
{
    public class ValuesRepository
    {
        public Dictionary<string, int> a = new Dictionary<string, int>
            {                
                { "Brown", 1 },
                { "Red", 2 },
                { "Orange", 3 },
                { "Yellow", 4 },
                { "Green", 5 },
                { "Blue", 6 },
                { "Violet", 7 },
                { "Gray", 8 },
                { "White", 9 }
            };

        public Dictionary<string, int> b = new Dictionary<string, int>
            {
                { "Black", 0 },
                { "Brown", 1 },
                { "Red", 2 },
                { "Orange", 3 },
                { "Yellow", 4 },
                { "Green", 5 },
                { "Blue", 6 },
                { "Violet", 7 },
                { "Gray", 8 },
                { "White", 9 }
            };

        public Dictionary<string, int> c = new Dictionary<string, int>
            {
                { "Black", 0 },
                { "Brown", 1 },
                { "Red", 2 },
                { "Orange", 3 },
                { "Yellow", 4 },
                { "Green", 5 },
                { "Blue", 6},
                { "Violet", 7 },
                { "Gray", 8 },
                { "White", 9 },
                { "Gold", -1 },
                { "Silver", -2 }
            };


         public Dictionary<string, float> d = new Dictionary<string, float>
            {
                { "None", 0f },
                { "Brown", 0.01f },
                { "Red", 0.02f },
                { "Orange", 0.03f },
                { "Yellow", 0.04f },
                { "Green", 0.005f },
                { "Blue", 0.0025f },
                { "Violet", 0.0010f },
                { "Gray", 0.0005f },
                { "Gold", 0.05f },
                { "Silver", 0.1f }
            };

        /// <summary>
        /// Retrieves the band values from the repository based on the band parameter.
        /// </summary>
        /// <param name="band"></param>
        /// <returns></returns>
        public List<SelectListItem> RetrieveBandValues(string band)
        {
            List<SelectListItem> selectListBandValues = new List<SelectListItem>();
            Dictionary<string, int> bandValues = new Dictionary<string, int>();
            Dictionary<string, float> bandDValues = new Dictionary<string, float>();

            switch (band)
            {
                case "A":
                    bandValues = a;
                    break;
                case "B":
                    bandValues = b;
                    break;
                case "C":
                    bandValues = c;
                    break;
                case "D":
                    bandDValues = d;
                    break;                
    
            }


            if (band != "D")
            {
                foreach (KeyValuePair<string, int> entry in bandValues)
                {
                    selectListBandValues.Add(new SelectListItem() { Text = entry.Key, Value = entry.Key });
                }
            }
            else
            {
                foreach (KeyValuePair<string, float> entry in bandDValues)
                {
                    selectListBandValues.Add(new SelectListItem() { Text = entry.Key, Value = entry.Key });
                }
            }

            return selectListBandValues;
        }
       
    }
}