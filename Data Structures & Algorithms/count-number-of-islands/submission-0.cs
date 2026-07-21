public class Solution {
    public int NumIslands(char[][] grid) {
        
        int islands = 0;
        
        for(int r = 0; r < grid.Length; r++){

            for(int c = 0; c < grid[0].Length; c++){

                if(grid[r][c] == '1'){
                    islands++;
                    DFS(grid, r, c);
                }
            }
        }

        return islands;

    }

    private void DFS(char[][] grid, int r, int c)
    {
        if(r < 0 || r >= grid.Length ||
        c < 0 || c >= grid[0].Length ||
        grid[r][c] == '0')
        {
            return;
        }

        grid[r][c] = '0';

        DFS(grid, r - 1, c); // up
        DFS(grid, r + 1, c); // down
        DFS(grid, r, c - 1); // left
        DFS(grid, r, c + 1); // right
    }
}
