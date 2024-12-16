public class Solution
{
    public static int MajorityElement(int[] nums)
    {
        int candidate = 0;
        int count = 0;

        // Thuật toán Boyer-Moore Voting
        foreach (var num in nums)
        {
            if (count == 0) candidate = num;  // Nếu count bằng 0, chọn số hiện tại làm candidate

            count += (num == candidate) ? 1 : -1;  // Nếu số bằng candidate, tăng count; nếu không giảm count
        }

        return candidate;  // Trả về candidate sau khi vòng lặp kết thúc
    }

}