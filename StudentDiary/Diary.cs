using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    public class Diary
    {
        //Stan (zmienne - w klasie nazywa się to pola)
        List<float> ratings = new List<float>();                    //Lista typu float z ocenami
                                                                    //new List<float>() - wyjątek null reference - zmienna niezainicjowana
        
        //Zachowania
        public void AddRating(float rating)     //Metoda publiczna, która nie zwraca wartości (typ void)
        {
            ratings.Add(rating);                //Dodaje ocenę (rating) do listy ratings
        }

        public float CalculateAverage()
        {
            float sum = 0, avg = 0;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            avg = sum / ratings.Count();        //Count to ilość elementów w kolekcji

            return avg;
        }

        public float GiveMaxRating()
        {
            return ratings.Max();               //Metoda max zwraca największą zawartość na liście
        }

        public float GiveMinRating()
        {
            return ratings.Min();
        }
    }
}
