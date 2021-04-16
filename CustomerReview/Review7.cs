using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace CustomerReview
{
    class Review7
    {
        private string _path = "review.txt";
        public string ReviewerName { get; set; }
        public string ReviewerEmail { get; set; }
        public string ReviewerPhone { get; set; }
        public int FoodRating { get; set; }
        public int ServiceRating { get; set; }

        public int EnvironmentRating { get; set; }
        public string Suggestions { get; set; }
        public object JsonConverter { get; private set; }

        public string SaveReview(Review7 Data) {
            string str = JsonConvert.SerializeObject(Data,
                Formatting.None);
            Utility.WriteToTextFile(_path, str);
            return "success";
        }
        public List<Review7> List()
        {
            string d = Utility.ReadFromTextFile(_path);
            if (d != null)
            {
                List<Review7> lst = JsonConvert.DeserializeObject<List<Review7>>(d);
                return lst;
            }
            return null;
        }
    }
}
