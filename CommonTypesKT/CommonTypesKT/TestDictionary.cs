using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CommonTypesKT
{
    class TestDictionary<T1, T2> : IEnumerable<TestKeyValuePairs<T1, T2>>, IEnumerator<TestKeyValuePairs<T1, T2>>
    {
        private List<TestKeyValuePairs<T1, T2>> _elementsKeeper = new List<TestKeyValuePairs<T1, T2>>();

        private int _position = -1;

        public TestKeyValuePairs<T1, T2> Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public void AddElements(T1 key, T2 value )
        {
            _elementsKeeper.Add(new TestKeyValuePairs<T1, T2>(key, value));

        }

        public void DeleteElementByKey(T1 key)
        {
            for (int i = 0; i < _elementsKeeper.Count; i++)
            {
                if (_elementsKeeper[i].ToString() == key.ToString())
                {
                    _elementsKeeper.RemoveAt(i);
                }
            }
        }
        public void DeleteElementByValue(T2 value)
        {
            for (int i = 0; i < _elementsKeeper.Count; i++)
            {
                if (_elementsKeeper[i].ToString() == value.ToString())
                {
                    _elementsKeeper.RemoveAt(i);
                }
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public TestKeyValuePairs<T1, T2> FindByKey(T1 key)
        {
            for (int i = 0; i < _elementsKeeper.Count; i++)
            {
                if (_elementsKeeper[i].ToString() == key.ToString())
                {
                    return _elementsKeeper[i];
                }
                
            }
            throw new ElemetNotFoundException();
        }

        public TestKeyValuePairs<T1, T2> FindByValue(T2 Value)
        {
            for (int i = 0; i < _elementsKeeper.Count; i++)
            {
                if (_elementsKeeper[i].ToString() == Value.ToString())
                {
                    return _elementsKeeper[i];
                }

            }
            throw new ElemetNotFoundException();
        }

        public IEnumerator<TestKeyValuePairs<T1, T2>> GetEnumerator()
        {
            return _elementsKeeper.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public bool MoveNext()
        {
            if (_position < _elementsKeeper.Count - 1)
            {
                _position++;
                return true;
            } else
            {
                return false;
            }
            
        }

        public void Reset()
        {
            _position = -1;
        }

        
    }
}
