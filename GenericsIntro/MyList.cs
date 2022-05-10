using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
     class MyList<T>
    {
        T[] items; // T burada string,int...
        //constructor class bir yerde newler sen aşağıdaki otomatik çalışır.
        public MyList()
        {
            items = new T[0]; // MyList new yapıldığında ilk çalıştırılan bu olacak.
        }
        


        public void Add(T item)// burada kullanılan T string,int ne istersek o olur demek.
        {
            T[] tempArray = items; // new yeni referans numarası alıp eskisini sildiği için eskideki değerleri tutmayı sağladık.
            items = new T[items.Length+1];
            // tempArray de tutulan eski adresli verileri yenide almak için aşağıdaki yaparız.
            for (int i = 0; i < length; i++)
            {
                items[i] = tempArray[i];
            }
                    
            items[items.Length-1] = item;
        }

    }
}
