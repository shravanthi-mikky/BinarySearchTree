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
        public int leftCount = 0, rightCount = 0;
        bool result = false;
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(item) > 0)
            {
                if (this.LeftTree == null)
                { 
                    //this.leftCount++;
                    this.LeftTree = new BST_Methods<T>(item);
                }
                   
                else
                {
                    this.LeftTree.Insert(item);
                }
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new BST_Methods<T>(item);
                    //rightCount++;
                }
                else
                    this.RightTree.Insert(item);
            }
        }
        public void Display(BST_Methods<T> bst_Methods)
        {
            if (this.LeftTree != null)
            {
                bst_Methods.leftCount++;
                this.LeftTree.Display(bst_Methods);
            }
            Console.WriteLine(this.NodeData.ToString());

            if (this.RightTree != null)
            {
                bst_Methods.rightCount++;
                this.RightTree.Display(bst_Methods);
            }

        }
        public void GetSize(BST_Methods<T> bst_Methods)
        {
            //Display(bst_Methods);
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }
        public bool IfExists(T element, BST_Methods<T> node)
        {
            if (node == null)
            {
                result = false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element in BST" + " " + node.NodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("Current element is {0} in BST", node.NodeData);
            }
            if (element.CompareTo(node.NodeData) < 0)
            {
                IfExists(element, node.LeftTree);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                IfExists(element, node.RightTree);
            }
            return result;
        }
    }
}
