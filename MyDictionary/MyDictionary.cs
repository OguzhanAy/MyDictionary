using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Tx, Ty>
    {
        Tx[] keys;
        Ty[] values;

        public MyDictionary()
        {
            keys = new Tx[0];
            values = new Ty[0];
        }

        public void Add(Tx key, Ty value)
        {
            Tx[] tempKeyArray = keys;
            Ty[] temValueArray = values;

            keys = new Tx[keys.Length + 1];
            values = new Ty[values.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                keys[i] = tempKeyArray[i];
                values[i] = temValueArray[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
    }
}
