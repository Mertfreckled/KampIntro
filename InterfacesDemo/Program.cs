namespace InterfacesDemo
{
    class Program
        //SOLID ınterface segregation yazılımcının 5 temel prensibinden ı harfi 
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
            new Worker(),
            new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

        }

        interface IWorker
        {
            void Work();
        }
        interface IEat
        {
            void Eat();
        }
        interface ISalary
        {
            void Salary();
        }

        class Worker : IWorker, ISalary, IEat
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void Salary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }


        class Manager : IEat, ISalary, IWorker
        {
            public void Eat()
            {
                throw new NotImplementedException();
            }

            public void Salary()
            {
                throw new NotImplementedException();
            }

            public void Work()
            {
                throw new NotImplementedException();
            }
        }


        class Robot : IWorker
        {
            public void Work()
            {
                throw new NotImplementedException();
            }
        }
    }


}

