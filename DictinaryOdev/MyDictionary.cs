using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryOdev
{

    public class MyDictionary<T1,T2>
    {

        public List<T1> tKey;
        public List<T2> tValue;
     
        public MyDictionary()
        {
            tKey = new List<T1>();
            tValue = new List<T2>();

        }

        public void Add(T1 key,T2 value)
        {
            tKey.Add(key);
            tValue.Add(value);

        }

         
    }

}
