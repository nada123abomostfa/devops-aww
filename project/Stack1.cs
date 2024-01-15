using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class Stack1
    {
        private int[] data;
        private int top;
        public Stack1()
        {
            data = new int[10];
            top = -1;

        }
        public int pop()
        {
            return data[top--];
        }
        public int peek()
        {
            return data[top];
        }
        public bool IsEmpty()
        {
            return top == -1;
        }
        public void push(int num)
        {
            if (top == data.Length - 1)
            {
                int[] temp = new int[data.Length + 5];
                for (int i = 0; i <= top; i++)
                {
                    temp[i] = data[i];
                }
                data = temp;
            }
            data[++top] = num;
        }
        public override string ToString()
        {
            string s = "[";
            for (int i = 0; i <= top; i++)
            {
                s += data[i];
                if (i < top)
                    s += ", ";
            }
            return s += "]";
        }
        public override bool Equals(object o)
        {
            if (o == null || !this.GetType().Equals(o.GetType()))
                return false;
            Stack1 s = (Stack1)o;//kasting
            if (top != s.top) return false;
            for (int i = 0; i <= top; i++)
            {
                if (data[i] != s.data[i])
                    return false;
            }
            return true;
        }
    }
}
