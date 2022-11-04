namespace Easy {
    class TwoSum {
        /*
         Question:
        Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        You may assume that each input would have exactly one solution, and you may not use the same element twice.

        You can return the answer in any order.
        */
        public int[] Solution(int[] nums, int target) {
            int len = nums.Length;
            for (int i = 0; i < len; i++) {
                for (int j = 0; j < len; j++) {
                    if (i != j) {
                        int twosum = nums[i] + nums[j];
                        if (twosum == target) {
                            return new int[2] { i, j };
                        }
                    }
                }
            }
            return new int[0];
        }
    }
}