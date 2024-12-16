public class Solution
{
    private void DFS(char[][] grid, int row, int col)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;

        if (row < 0 || col < 0 || row > rows || col > cols) return;

        grid[row][col] = '0';

        DFS(grid, row - 1, col);
        DFS(grid, row + 1, col);
        DFS(grid, row, col + 1);
        DFS(grid, row, col - 1);
    }

    public int NumIslands(char[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int numIslands = 0;

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                if (grid[i][j] == '1')
                {
                    numIslands++;
                    DFS(grid, i, j);
                }

        return numIslands;
    }
}
