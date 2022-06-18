namespace MyDictionary
// generics hangi tipte verirsen operasyonlar o tipte çalışmasına yarıyor.< buraya type yazılır.>

{

    class Program
    {
        static void Main(string[] args)
        {

            ///*
            // 1. dictionary sınıfı içerisinde sizin belirleyeceğiniz keye göre değer saklar.
            //2. zorunluluğu var key türünü belirlemeniz şarttır.
            // */

            //Dictionary<string, int> AdYas = new Dictionary<string, int>();
            //AdYas.Add("mert", 25);
            //AdYas.Add("umut", 12);
            //AdYas.Add("özge", 24);

            //foreach (var degeroku in AdYas)
            //{
            //    Console.WriteLine(degeroku);
            //}
            ////değer sayma özelliği

            //var eleman = AdYas.Count();
            //Console.WriteLine("eleman sayısı: "+eleman);

            ////silme işlemi de var

            //AdYas.Remove("mert");

            //foreach (var degeroku in AdYas)
            //{
            //    Console.WriteLine(degeroku);
            //}

            MyDictionaryy<string,int> AdYas = new MyDictionaryy<string,int>();
            AdYas.Add("mert",25);
            

            Console.WriteLine(AdYas.Keys[0]);

            

        }


    }
    // 
   class MyDictionaryy<T, U>
   {
        // key ve value dizilerini oluşturdum.
        T[] _key;
        U[] _value;
        //geçici key ve value dizilerini oluşturdum.
        T[] _tempKey;
        U[] _tempValue;

        public MyDictionaryy()
        {
            // başlangıçta 0 boyutlu key ve value dizileri oluşturuldu.
            _key = new T[0];
            _value = new U[0];
        }

        public void Add(T key, U value)
        {// key ve value önceki değerleri geçici dizilere aktarıldı.
            _tempKey = _key;
            _tempValue = _value;



            //Her yeni key ve value degerleri eklendikce bellegin heap bolgesinde key ve value alanlari acilacak ve elemanlar icerisine yerlestirilecektir.
            _key = new T[_key.Length+1];
            _value = new U[_value.Length+1];
            //_tempKey ve _tempValue dizilerine _key ve _value dizilerini aktardım.
            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i]=_tempKey[i];

            }
            for (int i = 0; i < _tempValue.Length; i++)
            {
                _value[i] = _tempValue[i];
            }

            // Key ve Value nin son elemanları dizilere atanır.
            _key[_key.Length - 1] = key;
            _value[_value.Length - 1] = value;
        
        
        
        }


        public T[] Keys
        {
            get { return _key; }
            
        }
        public U[] Values
        {
            get { return _value; }
        }
        public int Length
        {
            get { return _key.Length; }
        }




   }
   
}
