﻿// See https://aka.ms/new-console-template for more information
using BinarySrchTree;
using System.Collections;

Console.WriteLine("Binary Search Tree!");

BST_Methods<int> bs1 = new(56);
bs1.Insert(30);
bs1.Insert(70);
bs1.Insert(22);
bs1.Insert(40);
bs1.Insert(60);
bs1.Insert(95);
bs1.Insert(11);
bs1.Insert(65);
bs1.Insert(03);
bs1.Insert(16);
bs1.Insert(63);
bs1.Insert(67);
bs1.Display();
bs1.GetSize();
bool result = bs1.IfExists(63, bs1);
Console.WriteLine(result);
