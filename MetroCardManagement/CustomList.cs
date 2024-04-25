using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// Class CustomList is used to create a custom list <see cref="CustomList"/>
    /// </summary>
    /// <typeparam name="Type"></typeparam> <summary>
    /// 
    /// </summary>
    /// <typeparam name="Type"></typeparam>
    public class CustomList<Type> : IEnumerable, IEnumerator
    {
        private int _count;
        private int _capacity;
        private Type[] _array;

        public int Count { get { return _count; } }
        public int Capacity { get { return _capacity; } }

        public Type this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }

        /// <summary>
        /// Default constructor for assigning properties <see cref="CustomList"/>
        /// </summary> <summary>
        /// 
        /// </summary>
        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _array = new Type[_capacity];
        }

        /// <summary>
        /// Method to add the element into the list <see cref="CustomList"/>
        /// </summary>
        /// <param name="element"></param>
        public void Add(Type element)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            _array[_count] = element;
            _count++;
        }

        /// <summary>
        /// Method to grow the size of _array <see cref="CustomList"/>
        /// </summary>
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

        /// <summary>
        /// Methods to add the list of elements to the customlist <see cref="CustomList"/>
        /// </summary>
        /// <param name="elements"></param>
        public void AddRange(CustomList<Type> elements)
        {
            _capacity = _count + elements.Count + 4;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            int k = 0;
            for (int i = _count; i < _count + elements.Count; i++)
            {
                temp[i] = elements[k];
                k++;
            }
            _array = temp;
            _count += elements.Count;
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

        public object Current { get { return _array[position]; } }


    }
}