int[] nums = { 1, 3, 5, 6 };
int target = 7;
int ketQua= SearchInsert(nums, target);
Console.WriteLine(ketQua);
int SearchInsert(int[] nums, int target)
{
    if (target > nums[nums.Length - 1])
    {
        return nums.Length;
    }
    int n=nums.Length;
    int i;
    for (i=0; i < n; ++i)
    {
        if(nums[i] >= target )
            return i;
    }
    return i;
}
