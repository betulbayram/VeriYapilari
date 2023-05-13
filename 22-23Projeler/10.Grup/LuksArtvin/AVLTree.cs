public class AVLNode
{
    public int Height { get; set; } = default!;
    public Tour Tour { get; set; } = default!;
    public AVLNode Left { get; set; } = default!;
    public AVLNode Right { get; set; } = default!;

    public AVLNode(Tour tour)
    {
        Tour = tour;
        Height = 1;
    }
}

public class AVLTree
{
    private AVLNode root = default!;

    private int Height(AVLNode node)
    {
        if (node == null)
            return 0;
        return node.Height;
    }

    private int NewHeight(AVLNode left, AVLNode right)
    {
        return Math.Max(Height(left), Height(right)) + 1;
    }

    private int BalanceFactor(AVLNode node)
    {
        if (node == null)
            return 0;
        return Height(node.Left) - Height(node.Right);
    }

    private AVLNode TurnLeft(AVLNode node)
    {
        AVLNode newRoot = node.Right;
        AVLNode newLeft = newRoot.Left;

        newRoot.Left = node;
        node.Right = newLeft;

        node.Height = NewHeight(node.Left, node.Right);
        newRoot.Height = NewHeight(newRoot.Left, newRoot.Right);

        return newRoot;
    }

    private AVLNode TurnRight(AVLNode node)
    {
        AVLNode newRoot = node.Left;
        AVLNode newRight = newRoot.Right;

        newRoot.Right = node;
        node.Left = newRight;

        node.Height = NewHeight(node.Left, node.Right);
        newRoot.Height = NewHeight(newRoot.Left, newRoot.Right);

        return newRoot;
    }

    public void Add(Tour tour)
    {
        root = AddRecursive(root, tour);
    }

    private AVLNode AddRecursive(AVLNode node, Tour tour)
    {
        if (node == null)
        {
            return new AVLNode(tour);
        }

        if (tour.ID < node.Tour.ID)
        {
            node.Left = AddRecursive(node.Left, tour);
        }
        else if (tour.ID > node.Tour.ID)
        {
            node.Right = AddRecursive(node.Right, tour);
        }
        else
        {
            // Numara zaten mevcut, isteğe bağlı olarak burada bir işlem yapabilirsiniz
            return node;
        }

        node.Height = NewHeight(node.Left, node.Right);

        int balanceFactor = BalanceFactor(node);

        if (balanceFactor > 1) // Sol alt-ağır
        {
            if (tour.ID < node.Left.Tour.ID)
            {
                return TurnRight(node);
            }
            else
            {
                node.Left = TurnLeft(node.Left);
                return TurnRight(node);
            }
        }
        else if (balanceFactor < -1) // Sağ alt-ağır
        {
            if (tour.ID > node.Right.Tour.ID)
            {
                return TurnLeft(node);
            }
            else
            {
                node.Right = TurnRight(node.Right);
                return TurnLeft(node);
            }
        }

        return node;
    }

    public void Delete(int ID)
    {
        root = DeleteRecursive(root, ID);
    }

    private AVLNode DeleteRecursive(AVLNode node, int ID)
    {
        if (node == null)
        {
            return null;
        }

        if (ID < node.Tour.ID)
        {
            node.Left = DeleteRecursive(node.Left, ID);
        }
        else if (ID > node.Tour.ID)
        {
            node.Right = DeleteRecursive(node.Right, ID);
        }
        else
        {
            // Silinecek düğümü bulduk

            if (node.Left == null || node.Right == null)
            {
                // En az bir çocuk olmayan durum
                AVLNode temp = null;
                if (node.Left == null)
                {
                    temp = node.Right;
                }
                else
                {
                    temp = node.Left;
                }

                if (temp == null)
                {
                    // Hiçbir çocuk yok, düğümü doğrudan silme
                    node = null;
                }
                else
                {
                    // Bir çocuk var, çocuğu düğümün yerine getirme
                    node = temp;
                }
            }
            else
            {
                // İki çocuğu olan durum

                AVLNode minNode = GetMin(node.Right);
                node.Tour = minNode.Tour;
                node.Right = DeleteRecursive(node.Right, minNode.Tour.ID);
            }
        }

        // Düğümü silip ağacı yeniden dengeleme
        if (node != null)
        {
            node.Height = 1 + Math.Max(Height(node.Left), Height(node.Right));
            int balanceFactor = BalanceFactor(node);

            if (balanceFactor > 1 && BalanceFactor(node.Left) >= 0)
            {
                // Sol-Sol durumu
                return TurnRight(node);
            }

            if (balanceFactor > 1 && BalanceFactor(node.Left) < 0)
            {
                // Sol-Sağ durumu
                node.Left = TurnLeft(node.Left);
                return TurnRight(node);
            }

            if (balanceFactor < -1 && BalanceFactor(node.Right) <= 0)
            {
                // Sağ-Sağ durumu
                return TurnLeft(node);
            }

            if (balanceFactor < -1 && BalanceFactor(node.Right) > 0)
            {
                // Sağ-Sol durumu
                node.Right = TurnRight(node.Right);
                return TurnLeft(node);
            }

             return node;
        }
        return null;
    }

    private AVLNode GetMin(AVLNode node)
    {
        AVLNode current = node;

        while (current.Left != null)
        {
            current = current.Left;
        }

        return current;
    }

    public Tour Search(int ID)
    {
        return SearchRecursive(root, ID);
    }

    private Tour SearchRecursive(AVLNode node, int ID)
    {
        if (node == null)
        {
            return null;
        }

        if (ID < node.Tour.ID)
        {
            return SearchRecursive(node.Left, ID);
        }
        else if (ID > node.Tour.ID)
        {
            return SearchRecursive(node.Right, ID);
        }
        else
        {
            return node.Tour;
        }
    }

    public void SaveTourInformation()
    {
        string fileName = "tour-information.txt";
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            SaveTourInformationRecursive(root, writer);
        }
    }

    private void SaveTourInformationRecursive(AVLNode node, StreamWriter writer)
    {
        if (node != null)
        {
            SaveTourInformationRecursive(node.Left, writer);
            writer.WriteLine(node.Tour);
            SaveTourInformationRecursive(node.Right, writer);
        }
    }

    public void LoadTourInformation()
    {
        string fileName = "tour-information.txt";
        string[] rows = File.ReadAllLines(fileName);

        foreach (string row in rows)
        {
            Tour tour = Tour.Parse(row);
            Add(tour);
        }
    }

}