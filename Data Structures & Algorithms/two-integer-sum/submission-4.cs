public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> expectedDict = new();
        for (int i = 0; i < nums.Length; i++) {
            expectedDict[target - nums[i]] = i;
        }
        for (int i = 0; i < nums.Length; i++){
            if(expectedDict.ContainsKey(nums[i])){
                if(expectedDict[nums[i]] == i){
                    continue;
                }
                else if(expectedDict[nums[i]] < i)
                {
                    return [expectedDict[nums[i]], i];
                }
                return [i, expectedDict[nums[i]]];
            }
        }
        return [];
    }
}
