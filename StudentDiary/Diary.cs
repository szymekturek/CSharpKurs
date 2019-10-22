using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }

        //Zmienne
        List<float> ratings; // = new List<float>();

        

        //Metody
        public void AddRating(float rating)
        {
            ratings.Add(rating);

        }
        public float CalculateAverage()
        {
            float sum = 0, avg = 0;

            foreach (var item in ratings)
            {
                sum += item;
            }

            avg = sum / ratings.Count;
            return avg;
        }
        public float GiveMaxRating()
        {
            return ratings.Max();
        }

        public float GiveMinRating()
        {
            return ratings.Min();
        }

        public int DiaryCount()
        {
            return ratings.Count();
        }
    }
}
