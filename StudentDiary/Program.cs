using System;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();   //Tworzenie nowego obiektu
            //diary.AddRating(5);
            //diary.AddRating(8.5); - liczba z przecinkiem jest automatycznie typem double
            //diary.AddRating(8.5f);       //Narzucenie kompilatorowi, że jest to typ float
            //diary.AddRating(4.7f);

            //float avg = diary.CalculateAverage();
            //float max = diary.GiveMaxRating();
            //float min = diary.GiveMinRating();

            for (; ; )
            {
                Console.WriteLine("Podaj ocenę z zakresu 1 - 10");

                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);

                if (rating == 11)
                {
                    break;
                }
                else
                {
                    if (result && rating <= 10 && rating >= 0)
                    {

                        diary.AddRating(rating);
                    }
                }
            }

            Console.WriteLine("Średnia Twoich ocen to: " + diary.CalculateAverage());
            Console.WriteLine("Najwyższa ocena: " + diary.GiveMaxRating());
            Console.WriteLine("Najniższa ocena: " + diary.GiveMinRating());
            Console.ReadKey();
        }
    }


}
