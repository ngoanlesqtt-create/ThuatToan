public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 0) return 0;  // Không có nhà nào, không có tiền
        if (nums.Length == 1) return nums[0];  // Chỉ có một nhà, cướp tiền từ nhà đó

        // Tạo mảng dp để lưu trữ kết quả tối ưu đến từng nhà
        int[] dp = new int[nums.Length];

        // Bài toán cơ sở
        dp[0] = nums[0];  // Chỉ có một nhà, cướp nhà đầu tiên
        dp[1] = Math.Max(nums[0], nums[1]);  // Với hai nhà, cướp nhà có nhiều tiền hơn

        // Dùng vòng lặp để tính toán số tiền tối đa có thể cướp từ nhà 2 đến nhà n-1
        for (int i = 2; i < nums.Length; i++)
        {
            dp[i] = Math.Max(dp[i - 1], dp[i - 2] + nums[i]);  // Lựa chọn tối ưu
        }

        // Kết quả cuối cùng nằm ở dp[nums.Length - 1]
        return dp[nums.Length - 1];
    }
}