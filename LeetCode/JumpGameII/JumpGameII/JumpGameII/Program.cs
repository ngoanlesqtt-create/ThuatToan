public class Solution
{
    public int Jump(int[] nums)
    {
        int n = nums.Length;
        if (n == 1) return 0;  // Nếu mảng chỉ có 1 phần tử, không cần nhảy

        int jumps = 0;          // Số bước nhảy
        int farthest = 0;       // Vị trí xa nhất có thể nhảy tới
        int endOfCurrentJump = 0; // Vị trí cuối cùng của bước nhảy hiện tại

        for (int i = 0; i < n - 1; i++)  // Duyệt qua mảng đến phần tử cuối cùng
        {
            // Cập nhật vị trí xa nhất có thể nhảy tới
            farthest = Math.Max(farthest, i + nums[i]);

            // Nếu đã đi hết phạm vi của bước nhảy hiện tại
            if (i == endOfCurrentJump)
            {
                jumps++;  // Tăng số bước nhảy
                endOfCurrentJump = farthest;  // Cập nhật phạm vi bước nhảy tiếp theo

                // Nếu phạm vi hiện tại có thể đến chỉ số cuối cùng, dừng lại
                if (endOfCurrentJump >= n - 1)
                    break;
            }
        }

        return jumps;
    }
}