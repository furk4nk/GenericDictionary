using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictionary
{
    public class MyDictionary<Tkey, Tvalue>
    {
        private Tkey[] _keyArray;
        private Tvalue[] _valueArray;

        private Tkey[] tempKeyArray;
        private Tvalue[] tempValueArray;
        public MyDictionary()
        {
            _keyArray = new Tkey[0];
            _valueArray = new Tvalue[0];
        }

        public void Add(Tkey key, Tvalue value)
        {
            tempKeyArray = _keyArray;
            tempValueArray = _valueArray;

            _keyArray = new Tkey[_keyArray.Length +1];
            _valueArray = new Tvalue[_valueArray.Length +1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                _keyArray[i] = tempKeyArray[i];
                _valueArray[i] = tempValueArray[i];
            }

            _keyArray[^1] = key;
            _valueArray[^1] = value;
        }

        public Tkey[] Keys
        {
            get { return _keyArray; }
        }
        public Tvalue[] Values
        {
            get { return _valueArray; }
        }
    }
}
