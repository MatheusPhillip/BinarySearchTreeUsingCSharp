using System;


namespace BinarySearchTree.Models
{
    public class TreeNode
    {

        private int data;
        private TreeNode rightNode;
        private TreeNode leftNode;
        private bool isDeleted; // soft delete variable

        public int Data
        {
            get { return data; }
        }

        public TreeNode LeftNode
        {
            get { return leftNode; }
            set { leftNode = value; }
        }// left child

        public TreeNode RightNode
        {
            get { return rightNode; }
            set { rightNode = value; }
        } // right child

        public bool IsDeleted
        {
            get { return isDeleted; }
        }

        //Node Constructor
        public TreeNode(int value)
        {
            data = value;
        }

        //Method to set soft delete
        public void Delete()
        {
            isDeleted = true;
        }

        public TreeNode Find(int value)
        {
            //this node is the starting current node
            TreeNode currentNode = this;

            // loop through this node and all of the children of this node
            while(currentNode != null)
            {
                if(value == currentNode.data && isDeleted == false)
                {
                    return currentNode;
                }
                else if(value > currentNode.data)
                {
                    currentNode = currentNode.rightNode;
                }
                else
                {
                    currentNode = currentNode.leftNode;
                }
            }
            //Node not found
            return null;
        }

        public TreeNode FindRecursive(int value)
        {
            if(value == data && isDeleted == false)
            {
                return this;
            }
            else if (value > data && rightNode != null)
            {
                return rightNode.FindRecursive(value);
            }
            else if(leftNode != null)
            {
                return leftNode.FindRecursive(value);
            }
            else
            {
                return null;
            }
        }

        public void Insert(int value)
        {
            if(value >= data)
            {
                if(rightNode == null)
                {
                    rightNode = new TreeNode(value);  
                }
                else
                {
                    rightNode.Insert(value);
                }
            }
            else
            {
                if(leftNode == null)
                {
                    leftNode = new TreeNode(value);
                }
                else
                {
                    leftNode.Insert(value);
                }
            }
            
        }

        public void InOrderTraversal()
        {
            if(leftNode != null)
            {
                leftNode.InOrderTraversal();
            }
            Console.WriteLine(data + " ");
            if(rightNode != null)
            {
                rightNode.InOrderTraversal();
            }
        }

    }
}
