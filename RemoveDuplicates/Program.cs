using System.Collections.Generic;
int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
int k = RemoveDuplicates( nums);
//Console.WriteLine(k);
static int RemoveDuplicates(int[] nums)
{
    SortedSet<int> result=new SortedSet<int>() ;

    for(int i=0;i<nums.Length; i++)
        result.Add(nums[i]);
    return result.Count;
}