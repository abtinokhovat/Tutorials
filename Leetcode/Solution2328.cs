namespace Leetcode;

public class Solution2328
{
    public static int CountPaths(int[][] grid)
    {
        int[][] directions = {new[] {0, 1}, new[] {0, -1}, new[] {1, 0}, new[] {-1, 0}};
        var m = grid.Length;
        var n = grid[0].Length;
        const int mod = 1_000_000_007;

        // Initialize dp, 1 stands for the path made by a cell itself.
        var dp = new int[m][];
        for (var i = 0; i < m; i++)
        {
            dp[i] = new int[n];
            Array.Fill(dp[i], 1);
        }

        // Sort all cells by value.
        var cellList = new int[m * n][];
        for (var i = 0; i < m; i++)
        for (var j = 0; j < n; j++)
        {
            var index = i * n + j;
            cellList[index] = new[] {i, j};
        }

        Array.Sort(cellList, (a, b) => grid[a[0]][a[1]] - grid[b[0]][b[1]]);

        // Iterate over the sorted cells, for each cell grid[i][j]: 
        foreach (var cell in cellList)
        {
            var i = cell[0];
            var j = cell[1];

            // Check its four neighbor cells, if a neighbor cell grid[currI][currJ] has a
            // larger value, increment dp[currI][currJ] by dp[i][j]
            foreach (var d in directions)
            {
                var currI = i + d[0];
                var currJ = j + d[1];
                if (currI < 0 || currI >= m || currJ < 0 || currJ >= n
                    || grid[currI][currJ] <= grid[i][j]) continue;
                dp[currI][currJ] += dp[i][j];
                dp[currI][currJ] %= mod;
            }
        }

        // Sum over dp[i][j].
        var answer = 0;
        for (var i = 0; i < m; i++)
        for (var j = 0; j < n; j++)
        {
            answer += dp[i][j];
            answer %= mod;
        }

        return answer;
    }
}