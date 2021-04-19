using System;

namespace Constructor // Constructor bir class ilk kez yapılandırdığımızda varsıyılan olarak çalışan bloktur. Türkçesi yapıcıdır.
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id=1, FirstName="Hamit", LastName="Bozdağ", City="Manisa"};
            
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Erva";
            customer3.LastName = "Bozdağ";
            customer3.City = "Van";

            // Yukarıdaki her iki kullanım aynı iken aşağıdaki kullanım onlara göre farklıdır.

            Customer customer2 = new Customer(2, "Merve", "Bozdağ", "Osmaniye");


            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer // Burada tanımladığımız class özellik barındıran class türüdür
    {
        public Customer() // default(parametresi olmayan) constructor customer1 ve customer2 nin tanımlanma şekli için
        {
            
        }

        public Customer(int id, string firstName, string lastName, string city) // parametreli constructor customer2 nin tanımlanma şekli için
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }


    }
}
