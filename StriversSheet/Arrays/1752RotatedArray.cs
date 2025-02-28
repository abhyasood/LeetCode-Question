//Given an array nums, return true if the array was originally sorted in non-decreasing order, then rotated some number of positions (including zero). Otherwise, return false.

//There may be duplicates in the original array.

// Note: An array A rotated by x positions results in an array B of the same length such that B[i] == A[(i+x) % A.length] for every valid index i.

namespace ArraysLeetcode
{
    public static class SortedRotatedArray {
    public static bool Check(int[] nums) {
        int count =0;
        int n = nums.Length;
        for (int i = 0; i<n ; i++){
            //here we are checking the number of drops
            if(nums[i]>nums[(i+1)%n]){
                count++;
            }
            if(count>1) return false;
        }
        return true;
    }
}
}