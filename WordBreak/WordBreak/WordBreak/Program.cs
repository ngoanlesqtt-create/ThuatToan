public class Solution
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        HashSet<string> wordSet = new HashSet<string>(wordDict);

        // Tạo mảng DP
        int n = s.Length;
        bool[] dp = new bool[n + 1];

        // Base case: Chuỗi rỗng là hợp lệ
        dp[0] = true;

        // Duyệt qua từng chỉ số trong chuỗi
        for (int i = 1; i <= n; i++)
        {
            // Kiểm tra các substring kết thúc tại i-1
            for (int j = 0; j < i; j++)
            {
                if (dp[j] && wordSet.Contains(s.Substring(j, i - j)))
                {
                    dp[i] = true; // Cập nhật trạng thái dp[i]
                    break; // Dừng vòng lặp sớm nếu đã tìm thấy kết quả
                }
            }
        }

        // Kết quả là trạng thái tại chỉ số n
        return dp[n];
    }
}
