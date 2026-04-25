public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        // edgecases
        int rows = matrix.Length - 1;
        int cols = matrix[0].Length - 1;
        int toprow = 0;
        int botrow = rows;
        int midrow = 0;

        while(toprow <= botrow) {
            // to avoid overflow and calculate mid
            midrow = toprow + (botrow - toprow)/2;
            if(target < matrix[midrow][0]) {
                botrow = midrow -1;
            } else if (target > matrix[midrow][cols]) {
                toprow = midrow + 1;
            } else {
                // lock midrow
                break;
            }
        }

        int l = 0;
        int r = cols;

        while(l <= r) {
            int m = l + (r -l)/2;
            if(target < matrix[midrow][m]) {
                r = m - 1;
            } else if (target > matrix[midrow][m]) {
                l = l+1;
            } else {
                return true;
            }
        }

        return false;        
    }
}
