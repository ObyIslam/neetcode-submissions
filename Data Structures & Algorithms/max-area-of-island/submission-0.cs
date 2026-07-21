public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        

        int maxArea = 0;

        for(int r = 0; r < grid.Length; r++){
            for(int c = 0; c < grid[0].Length; c++){

                if(grid[r][c] == 1){
                    int area = DFS(grid, r, c);
                    maxArea = Math.Max(maxArea, area);
                }
            }
        }

        return maxArea;
    }

    private int DFS(int[][] grid, int r, int c)
    {
        if(r < 0 || r >= grid.Length ||
        c < 0 || c >= grid[0].Length ||
        grid[r][c] == 0)
        {
            return 0;
        }

        grid[r][c] = 0;

        return 1
         + DFS(grid, r - 1, c) // up
         + DFS(grid, r + 1, c) // down
         + DFS(grid, r, c - 1) // left
         + DFS(grid, r, c + 1); // right
    }
}
