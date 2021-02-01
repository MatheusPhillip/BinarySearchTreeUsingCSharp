using System;


namespace BinarySearchTree.Models
{
    class BinaryTree
    {
        private TreeNode root;


        public void Insert(int data)
        {
            if(root != null)
            {
                root.Insert(data);
            }
            else
            {
                root = new TreeNode(data);
            }
            Console.WriteLine("The value " + data + " was successfully inserted on tree!");
        }

        public void inOrderTraversal()
        {
            if(root != null)
            {
                root.InOrderTraversal();
            }
            else
            {
                Console.WriteLine("Tree Is Empty");
            }
        }
    }
}
