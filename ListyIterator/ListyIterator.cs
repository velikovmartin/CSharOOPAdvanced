namespace ListyIterator
{
    using System;

    public class ListyIterator<T>
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
    }
}
