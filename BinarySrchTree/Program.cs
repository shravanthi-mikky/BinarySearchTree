// See https://aka.ms/new-console-template for more information
using BinarySrchTree;

Console.WriteLine("Binary Search Tree!");

BST_Methods<int> bs1 = new(56);
bs1.Insert(30);
bs1.Insert(70);
bs1.Display();
bs1.GetSize();