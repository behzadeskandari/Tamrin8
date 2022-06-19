using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            ///soal2 
            
            StringCompareLambda();




            ///Soal 3
            //ListOfMovies();

            ///Soal 1
            ///RunOddNumbers();

        }

        /// <summary>
        /// Soal 2
        /// </summary>
        private static void StringCompareLambda()
        {
            Console.WriteLine("Enter The First Word");
            string FirstWord = Console.ReadLine();

            Console.WriteLine("Enter The Second Word");
            string SeconWord = Console.ReadLine();


            var ValueHolder = FirstWord.ToList().Intersect(SeconWord.ToList()).ToList();
            
            var ValueHolderSecond = FirstWord.ToList().Except(SeconWord.ToList()).ToList();
            

            ValueHolder.ForEach(x => Console.WriteLine("2"));

            ValueHolderSecond.ForEach(x => Console.WriteLine("0"));

           
        }

        /// <summary>
        /// Soal 3
        /// </summary>
        private static void ListOfMovies()
        {
            List<Movie> listOne = new List<Movie>()
            {
                new Movie(){ Id=1,Name= "HarryPotter"},
                new Movie(){ Id=2,Name= "PirateofCarrabian"},
            };

            List<Movie> listTwo = new List<Movie>()
            {
                new Movie(){ Id=1, Name=" and the Philosopher's Stone"},
                new Movie(){ Id=1, Name=" and the Chamber of Secrets"},
                new Movie(){ Id=1, Name=" and the Prisoner of Azkaban"},
                new Movie(){ Id=1, Name=" and the Goblet of Fire"},
                new Movie(){ Id=1, Name=" and the Order of the Phoenix"},
                new Movie(){ Id=1, Name=" and the Half-Blood Prince"},
                new Movie(){ Id=1, Name=" and the Deathly Hallows"},
                new Movie(){ Id=2, Name="  1"},
                new Movie(){ Id=2, Name="  2"},
                new Movie(){ Id=2, Name="  3"},
                new Movie(){ Id=2, Name=" : On Stranger Tides"},
            };

            var innerJoin = listOne.Join(// outer sequence 
                      listTwo,  // inner sequence 
                      movie => movie.Id,    // outerKeySelector
                      movie2 => movie2.Id,  // innerKeySelector
                      (movie, movie2) => new  // result selector
                      {
                          movieId = movie.Id,
                          movie2Id = movie2.Id,
                          Name = movie.Name,
                          StandardName = movie.Name + movie2.Name
                      }).Where(x => x.movieId == x.movie2Id);            

            innerJoin.ToList().ForEach(p => Console.WriteLine(p.StandardName, "Name"));
        }

        /// <summary>
        /// Soal 1
        /// </summary>
        private static void RunOddNumbers()
        {
            List<int> numbers = new List<int>();
            int j = 0;

            for (int i = 0; i < 100; i++)
            {
                numbers.Add(i);
            }
            
            List<int> oddNumbers = numbers.FindAll(x => x % 2 != 0);

            oddNumbers.ForEach(x => Console.WriteLine(x));
        }
    }

    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }

    
}