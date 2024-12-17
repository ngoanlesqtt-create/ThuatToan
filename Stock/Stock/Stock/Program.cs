public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int minPrice = int.MaxValue;  // Khởi tạo giá mua thấp nhất ban đầu là vô cùng lớn
        int maxProfit = 0;  // Lợi nhuận tối đa ban đầu là 0

        foreach (var price in prices)
        {
            minPrice = Math.Min(minPrice, price);  // Cập nhật giá mua thấp nhất
            int profit = price - minPrice;  // Tính lợi nhuận nếu bán vào ngày này
            maxProfit = Math.Max(maxProfit, profit);  // Cập nhật lợi nhuận tối đa
        }

        return maxProfit;  // Trả về lợi nhuận tối đa
    }
}