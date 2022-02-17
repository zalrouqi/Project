using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Project
{
    class program
    {
        public static void Main()
        {
            Car car1 = new Car(){Model = "BMW",ModelYear = 2018, CarColor = "Black", IdOfCarOwer = 102 };
            Car car2 = new Car(){Model = "Toyta", ModelYear = 2020, CarColor = "White", IdOfCarOwer = 177};
            Car car3 = new Car(){Model = "Hyundai",ModelYear = 2021, CarColor = "silver", IdOfCarOwer = 189};

            List<Car> ListCar = new List<Car>();
            ListCar.Add(car1);
            ListCar.Add(car2);
            ListCar.Add(car3);

            People p1 = new People() { Name = "Ahmed" , id = 102};
            People p2 = new People() { Name = "Sara" , id = 189 };
            People p3 = new People() { Name = "ibrahim" , id = 177 };

            List<People> ListPeople = new List<People>();
            ListPeople.Add(p1);
            ListPeople.Add(p2);
            ListPeople.Add(p3);

            foreach (Car car in ListCar)
            {
                foreach(People people in ListPeople)
                {
                    if (car.IdOfCarOwer == people.id)
                    {
                        Console.WriteLine("Car Model : {0} , Model Year : {1} , The Coler : {2} , Owner of Car :m {3} ," +
                            " Name of Owner {4}" , car.Model, car.ModelYear, car.CarColor, car.IdOfCarOwer , people.Name);
                    }
                }

                
            }


        }
        }

     class People
    {
        public int id { get; set; }
        public string Name { get; set; }

      

    }
    class Car
    {
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string CarColor { get; set; }
        public int IdOfCarOwer { get; set; }

       
       




    }

    class Jewelry
    {
     public double wight ;
     

    }
    class Gold : Jewelry
    {

    }
    class silver : Jewelry
    {

    }

    class Wapons
    {
        public int license;


    }

}