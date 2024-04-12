using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTree
{
    public class Tree<T>
    {
        public T Value { get; set; }
        public Tree<T> Parent { get; set; }
        public List<Tree<T>> Children { get; set; }

        public Tree(T value, params Tree<T>[]children)
        {
            this.Value = value;
            this.Children = new List<Tree<T>>();
            foreach (var child in children)
            {
                this.Children.Add(child);
                this.Parent = this;
            }
        }

        public void PrintTheTree(int inception = 0) 
        {
            Console.Write(new string(' ',inception*4));
            Console.WriteLine(this.Value);
            foreach (var item in this.Children)
                item.PrintTheTree(inception + 1);
            
        }

        public IEnumerable<T> OrderDFS() 
        {
            List<T> order = new List<T>();
            this.DFS(this, order);
            return order;
        }

        private void DFS(Tree<T> tree, List<T> order) 
        {
            foreach (var child in tree.Children)
            {
                this.DFS(child, order);
            }
            order.Add(tree.Value);
        }

    }
}
