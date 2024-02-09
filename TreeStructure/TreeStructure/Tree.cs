using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeStructure
{
    public class Tree<T>
    {
        private T value;
        private IList<Tree<T>> children;

        public T Value { get; set; }
        public IList<Tree<T>> Children { get; private set; }

        public Tree(T value, params Tree<T>[] children)
        {
            this.Value = value;
            this.Children = new List<Tree<T>>();

            foreach (var child in children)
            {
                this.Children.Add(child);
            }
        }
        public void PrintTheTree(int inception = 0)
        {
            Console.Write(new string(' ',2*inception));
            Console.WriteLine(this.Value);
            foreach (var child in this.Children)
                child.PrintTheTree(inception + 1);
            
        }
    }
}
