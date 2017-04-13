using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFO_Buffer
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Queue<T>
    {
        List<T> list = new List<T>();
        public void Enqueue(T item)
        {
            list.Add(item);
        }

        public string Dequeue()
        {
            if (list.Count() != 0)
            {
                string tmp = list[0].ToString();
                list.RemoveAt(0);
                return tmp;
            }
            else throw new EmptyList();
        }
        public string PrintResult()
        {
            string Output = string.Empty;
            foreach (var item in list)
            {
                Output += item.ToString() + "\n"; 
            }
            return Output;
        }
        public int Count()
        {
            return list.Count;
        }

        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        public T GetLast()
        {
           return list.Last();
        }

    }

    public class EmptyList: System.Exception
    {

    }
}
