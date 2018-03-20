using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Queues
{
    class MyQueue
    {
        private ArrayList MyList;
        private double item;

        public void Enqueue(double item)
        {
            MyList.Add(item);
        }
        public void Insert(double item)
        {
            MyList.Insert(0, item);
        }
        public void Clear()
        {
            MyList.Clear();
        }
        public double Dequeue()
        {
            double value;
            value = Peek();
            MyList.RemoveAt(0);
            return value;
        }
        public double Peek()
        {
            return (double)MyList[0];
        }
        public int Count()
        {
            return MyList.Count;
        }
    }
}
