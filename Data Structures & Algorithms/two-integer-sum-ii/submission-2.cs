public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var front = 0;
        var back = numbers.Length - 1;

        while (front < back)
        {
            if (numbers[front] + numbers[back] == target)
            {
                return [front + 1, back + 1];
            }
            if (numbers[front] + numbers[back] < target)
            {
                front++;
            }
            else
            {
                back--;
            }
        }
        return [-1, -1];
    }
}
