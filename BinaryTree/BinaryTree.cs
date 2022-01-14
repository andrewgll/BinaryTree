using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class TreeNode
    {
        public int Data { get; set; }
        public TreeNode LeftNode;
        public TreeNode RightNode;
        public void Insert(int value)
        {
            if(value >= Data)
            {
                if(RightNode == null)
                {
                    RightNode = new TreeNode { Data = value };
                }
                else
                {
                    RightNode.Insert(value);
                }
            }
            else
            {
                if(LeftNode == null)
                {
                    LeftNode = new TreeNode { Data = value };   
                }
                else
                {
                    LeftNode.Insert(value);
                }
            }
        }
        public void CLR(TreeNode node, List<int> result)
        {
            if(node != null)
            {
                result.Add(node.Data);
                CLR(node.LeftNode, result);
                CLR(node.RightNode, result);
            }
        }
        public void LCR(TreeNode node, List<int> result)
        {
            if(node != null)
            {
                LCR(node.LeftNode, result);
                result.Add(node.Data);
                LCR(node.RightNode, result);

            }
        }
    }
    public class BinaryTree
    {
        private TreeNode root;
        public void Add(int value)
        {
            if(root != null)
            {
                root.Insert(value);
            }
            else
            {
                root = new TreeNode { Data = value };
            }
        }
        public void Print()
        {
            List<int> result = new List<int>();
            root.CLR(root, result);

            result.ForEach(x => Console.Write(x + " "));
        }
        public void PrintSorted()
        {
            List<int> result = new List<int>();
            root.LCR(root, result);

            result.ForEach(x => Console.Write(x + " "));
        }
    }
}
