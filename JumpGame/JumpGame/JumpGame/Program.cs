public class Solution
{
    public bool CanJump(int[] nums)
    {
        int farthest = 0; // Vị trí xa nhất có thể đến được

        // Duyệt qua mảng
        for (int i = 0; i < nums.Length; i++)
        {
            // Nếu tại chỉ số i, farthest không thể đến được, trả về false
            if (i > farthest)
            {
                return false;
            }

            // Cập nhật farthest để xem bạn có thể nhảy đến đâu từ vị trí i
            farthest = Math.Max(farthest, i + nums[i]);

            // Nếu farthest có thể đạt đến hoặc vượt qua chỉ số cuối cùng, trả về true
            if (farthest >= nums.Length - 1)
            {
                return true;
            }
        }

        // Nếu không thể đạt đến cuối cùng
        return false;
    }
}
