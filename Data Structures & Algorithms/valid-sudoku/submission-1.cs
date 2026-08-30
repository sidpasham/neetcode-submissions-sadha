public class Solution {
    public bool IsValidSudoku(char[][] board) {
        if(board == null || board.Length == 0) {
            return false;
        }
        
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var boxes = new HashSet<char>[9];

        for(int i = 0; i< 9; i++) {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for(int r = 0; r < 9; r++) {
            for(int c = 0; c < 9; c++) {
                if(board[r][c] == '.') {
                    continue;
                }

                int boxIndex = (r/3) * 3 + (c/3);

                if(rows[r].Contains(board[r][c]) ||
                cols[c].Contains(board[r][c]) ||
                boxes[boxIndex].Contains(board[r][c])) {
                    return false;
                }

                rows[r].Add(board[r][c]);
                cols[c].Add(board[r][c]);
                boxes[boxIndex].Add(board[r][c]);
            }
        }

        return true;
    }
}
