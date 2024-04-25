using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public class CustomList<Type> : IEnumerable, IEnumerator
    {
        private int _count;
        private int _capacity;
        private Type[] _array;

        //private Type[] _newArray;
        private int _top;

        public int Count { get { return _count; } }
        public int Capacity { get { return _capacity; } }

        public Type this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }

        // public Type this[int index1]
        // {
        //     get { return _newArray[index1]; }
        //     set { _newArray[index1] = value; }
        // }

        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _top = -1;
            _array = new Type[_capacity];
        }

        public void Add(Type element)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            if (_count != 0)
            {
                for (int i = _count; i>=0; i--)
                {
                    
                    _array[i+1]=_array[i];
                    
                }
                _array[0]=element;
                _count++;
            }
            else if(_count==0)
            {
                _array[_count] = element;

                _count++;
            }
            
        }

        void GrowSize()
        {
            _capacity *= 2;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }
        int position;
        public IEnumerator GetEnumerator()
        {
            position = -1;
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            if (position < _count - 1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get { return _array[position]; }

        }
    }
}