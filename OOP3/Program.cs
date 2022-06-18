namespace OOP3

{

    class Program
    {
        static void Main(string[] args)
        {
            //interface o classı implamente eden classın referans numarasını tutar.
           /*IhtiyacKrediManager*/ IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            /*TasitKrediManager*/ IKrediManager tasitKrediManager = new TasitKrediManager();

            /*KonutKrediManager*/IKrediManager konutKrediManager = new KonutKrediManager(); 

            ILoggerService databaseLoggerService = new DatabaseLoggerSevice();
            ILoggerService fileLoggerService = new FileLoggerSevice(); 

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(),new SmsLoggerService() );//new diyerek instance oluşturulur.

            Console.WriteLine("************************istediğini seçmeee***********");

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }


    }



}


