int x = 121;
bool ketQua = Solution. IsPalindrome(x);
Console.WriteLine(ketQua);
public class Solution
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;
        if(x>=0&&x<10)
            return true;        
        int soSanh = 0;
        int trungGian = x;
        while (trungGian > 0)
        {
            soSanh = soSanh * 10 + trungGian % 10;
            trungGian /=   10;
        }
        return x == soSanh;
    }
 
  
}
