﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodString
{
    public class Box<T>
        where T : IComparable<T>
    {
        public Box(List<T> items)
        {
            this.Items = items;
        }

        public List<T> Items { get; set; }

        public void Swap(int index1, int index2)
        {
            T tempVar = this.Items[index1];
            this.Items[index1] = this.Items[index2];
            this.Items[index2] = tempVar;
        }

        internal int GetGreaterThan(T element)
        {
            int count = 0;

            foreach (var item in this.Items)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    foreach (var item in this.Items)
        //    {
        //        sb.AppendLine($"{item.GetType().FullName}: {item}");
        //    }

        //    return sb.ToString().TrimEnd();
        //}
    }
}
