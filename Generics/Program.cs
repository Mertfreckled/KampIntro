namespace Generics
    // generics hangi tipte verirsen operasyonlar o tipte çalışmasına yarıyor.< buraya type yazılır.>

{

    class Program
    {
        static void Main(string[] args)
        {

            List<string> sehirler = new List<string>();

            sehirler.Add("ankara");
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            sehirler.Add("ankara");

            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
           

            sehirler2.Add( "ankara");
            sehirler2.Add("ankara");
            sehirler2.Add("ankara");
            sehirler2.Add("ankara");
            sehirler2.Add("ankara");
            sehirler2.Add("ankara");

            Console.WriteLine(sehirler2.Count);
        }

        
    }
    
    class MyList<T> // T yerine başka birşey yazılabilir. Type demek. generic class //***1***
    {
        //başlangıçta 0 elemanlı array olması için T[0] constructors yaptık 
        T[] _array;
        T[] _tempArray; // geçici array yani eleman sayısını 1 artırmadan öncekilerin adresini tutmak için ***5***
        //************2**************
        public MyList()
        {
            _array = new T[0];     
        }



        public void Add(T item)
        {
            _tempArray = _array;//**6**
            //*************4*********
            _array = new T[_array.Length + 1]; // array e eleman eklendikçe eleman sayısını 1 arttırdık.

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i]; // ***7** burada _tempArray den tutulan değerler _array e aktarıldı.
            }
            _array[_array.Length - 1] = item; //**8** burada _array.Length - 1 array0 dan başladığı için -1 son
                                              //eleman buna item değerini yazdırıyoruz.
        }

        //***********3***********
        // T[0] _arrayinin eleman sayısını veren propfull
        public int Count
        {
            get { return _array.Length; }
           
        }

    }
}