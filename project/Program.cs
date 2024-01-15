namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack1 s = new Stack1();
            Stack1 temp = new Stack1();
            Stack1 s2 = new Stack1();
            s.push(5);
            s.push(3);
            s.push(9);
            Console.WriteLine(s.peek());
            Console.WriteLine(s.pop());
            Console.WriteLine(s.peek());
            s.push(8);
            Console.WriteLine(s);
            while (!s.IsEmpty())
            {
                Console.Write(s.peek() + " ");
                temp.push(s.pop());
            }
            Console.WriteLine();
            while (!temp.IsEmpty())
            {
                s.push(temp.pop());
            }
            Console.WriteLine(s);
            s2.push(5);
            s2.push(3);
            s2.push(8);
            Console.WriteLine(s2.Equals(s2));
        }
    }
    
}