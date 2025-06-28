
class BinaryTree
{
    public Node Root;
    public BinaryTree()
    {
        Root = null;
    }

    bool isEmpty() { return Root == null; }
    Node Insert(Node root, int item)
    {
        if (root == null)
        {
            Node newnode = new Node(item);
            root = newnode;
        }
        else if (item < root.Data)
            root.Left = Insert(root.Left, item);
        else
            root.Right = Insert(root.Right, item);
        return root;
    }
    public void Insert(int item)
    {
        Root = Insert(Root, item);
    }
    public void Preorder(Node root)
    {
        if (root == null)
            return;
        Console.Write($"{root.Data}\t");
        Preorder(root.Left);
        Preorder(root.Right);
    }
    public void InOrder(Node root)
    {
        if (root == null)
            return;
        InOrder(root.Left);
        Console.Write($"{root.Data}\t");
        InOrder(root.Right);
    }
    public void PostOrder(Node root)
    {
        if (root == null)
            return;
        PostOrder(root.Left);
        PostOrder(root.Right);
        Console.Write($"{root.Data}");
    }
    public void Search(Node tree, int item)
    {
        if (item == tree.Data)
            Console.WriteLine($"item ({item}) is found ");
        else if (item < tree.Data)
            Search(tree.Left, item);
        else
            Search(tree.Right, item);
    }
    Node FindMinimum(Node root)
    {
        if (root == null)
            throw new Exception("the tree is empty");
        else if (root.Left == null)
            return root;
        else
            return FindMinimum(root.Left);
    }
    Node FindMaximum(Node root)
    {
        if (root == null)
            throw new Exception("tree is empty");
        else if (root.Right == null)
            return root;
        else
            return FindMaximum(root.Right);
    }
    Node Delete(Node root, int item)
    {
        if (root == null)
            throw new Exception("tree is empty");
        else if (item < root.Data)
            root.Left = Delete(root.Left, item);
        else if (item > root.Data)
            root.Right = Delete(root.Right, item);
        else
        {
            if (root.Left == null && root.Right == null)
                return root;
            else if (root.Left != null && root.Right == null)
            {
                root.Data = root.Left.Data;
                root.Left = null;
            }
            else if (root.Left == null && root.Right != null)
            {
                root.Data = root.Right.Data;
                root.Right = null;
            }
            else
            {
                Node maxValue = FindMaximum(root.Left);
                root.Data = maxValue.Data;
                root.Left = Delete(root.Left, maxValue.Data);
            }
        }
        return root;
    }
    public void Delete(int item)
    {
        Root = Delete(Root, item);
    }
}