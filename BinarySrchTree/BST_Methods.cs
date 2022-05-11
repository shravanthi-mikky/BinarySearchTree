using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySrchTree
{
    public class BST_Methods<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BST_Methods<T> LeftTree { get; set; }
        public BST_Methods<T> RightTree { get; set; }
        public BST_Methods(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = LeftTree;
            this.RightTree = RightTree;
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(item) > 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new BST_Methods<T>(item);
                else
                    this.LeftTree.Insert(item);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BST_Methods<T>(item);
                else
                    this.RightTree.Insert(item);
            }
        }
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();

            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }
        
    }
}
