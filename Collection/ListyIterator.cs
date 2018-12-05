using System.Text;

namespace Collection
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ListyIterator<T> : IEnumerable<T>
    {
        private T[] elements;

        private int internalIndex;

        public ListyIterator(T[] elements)
        {
            this.elements = elements;
            this.internalIndex = 0;
        }

        public bool Move()
        {
            if (this.internalIndex < this.elements.Length - 1)
            {
                internalIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            return this.internalIndex < this.elements.Length - 1;
        }

        public void Print()
        {
            if (this.elements.Length == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(this.elements[this.internalIndex]);
        }

        public void PrintAll()
        {
            StringBuilder sb = new StringBuilder();

            if (this.elements.Length == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            foreach (var element in elements)
            {
                sb.Append(element + " ");
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.elements.Length; i++)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
