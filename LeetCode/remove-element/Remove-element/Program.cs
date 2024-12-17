int RemoveElement(int[] nums, int val)
{
    if(nums.Length==0)
        return 0;
    int j = 0;
    int length=nums.Length;
    for (int i = 0; i < length; ++i)
        if (nums[i] != val)
        {
            nums[j] = nums[i];
            j++;
        }
    return j;
}