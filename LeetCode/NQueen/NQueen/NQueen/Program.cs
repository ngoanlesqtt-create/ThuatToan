public class Solution
{
    private int count = 0; // To keep track of the number of solutions


    public int TotalNQueens(int n)
    {
        bool[] columns = new bool[n];
        bool[] d1 = new bool[2 * n - 1]; 
        bool[] d2 = new bool[2 * n - 1]; 

        Backtrack(0, n, columns, d1, d2);
        return count;
    }

    private void Backtrack(int row, int n, bool[] columns, bool[] d1, bool[] d2)
    {
        if (row == n)
        {
            count++;
            return;
        }

        for (int col = 0; col < n; col++)
        {
        
            if (columns[col] || d1[row - col + n - 1] || d2[row + col])
                continue;

      
            columns[col] = d1[row - col + n - 1] = d2[row + col] = true;

        
            Backtrack(row + 1, n, columns, d1, d2);

            columns[col] = d1[row - col + n - 1] = d2[row + col] = false;
        }
    }
}