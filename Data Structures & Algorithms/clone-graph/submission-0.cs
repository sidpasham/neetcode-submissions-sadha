/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if (node == null) return null;
        // we need to map every old node to new old, 
        // because, it can be neigbour to already visited node
        var oldToNew = new Dictionary<Node, Node>();
        
        return dfs(node, oldToNew);
    }

    public Node dfs(Node oldNode, Dictionary<Node, Node> oldToNew) {
        // base case
        if (oldNode == null) {
            return null;
        }

        if(oldToNew.ContainsKey(oldNode)) {
            return oldToNew[oldNode];
        }

        Node newNode = new Node(oldNode.val);
        oldToNew[oldNode] = newNode;
        
        foreach(var n in oldNode.neighbors) {
                newNode.neighbors.Add(dfs(n, oldToNew));
        }

        return newNode;
    }
}
