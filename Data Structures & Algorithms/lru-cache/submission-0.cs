public class Node {
    public int Key;
    public int Value;
    public Node Prev;
    public Node Next;
    
    public Node (int key, int val) {
        Key = key;
        Value = val;
        Prev = null;
        Next = null;
    }
}

public class LRUCache {
    public int capacity;
    public Dictionary<int, Node> cache;
    public Node left;
    public Node right;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        cache = new Dictionary<int, Node>();
        left = new Node(0, 0);
        right = new Node(0, 0);
        left.Next = right;
        right.Prev = left;
    }
    
    public int Get(int key) {
        // if key not exists return -1
        if (!cache.ContainsKey(key)) {
            return -1;
        }
        // get the value from cache
        Node node = cache[key];
        // remove key node
        Remove(node);
        
        // insert new Node
        Insert(node);

        // return val
        return node.Value;
    }
    
    public void Put(int key, int value) {
        // if key contains, first remove element
        if(cache.ContainsKey(key)) {
            Node node = cache[key];
            Remove(node);
        }

        // create a new Node
        Node newNode = new Node(key, value);
        // update cache
        cache[key] = newNode;
        // Insert the Node
        Insert(newNode);

        // if capacity is reached
        if (cache.Count() > capacity) {
            // remove left node
            Node lru = left.Next;
            Remove(lru);
            // remove from cache
            cache.Remove(lru.Key);
        }
    }

    public void Insert(Node node) {
        // insert towards right
        Node temp = right.Prev;
        temp.Next = node;
        node.Prev = temp;
        node.Next = right;
        right.Prev = node;
    }

    public void Remove(Node node) {
        Node prev = node.Prev;
        Node next = node.Next;

        prev.Next = next;
        next.Prev = prev;
    }
}
