using System;

namespace Algorithms {
    public static class Program {
        public static void Main(string[] args) {
            foreach (string arg in args) {
                if (arg.ToUpper().Equals("TWO-SUM")) {
                    Two_Sum();
                } else if (arg.ToUpper().Equals("ADD-TWO-NUMS")) {
                    Add_Two_Nums();
                } else {
                    Console.WriteLine($"Argument {arg} is invalid");
                }
            }
        }

        private static void Two_Sum() {
            int[] case_1_arr = { 2, 7, 11, 15 };
            int[] case_1 = new Easy.TwoSum().Solution(case_1_arr, 9);
            Console.WriteLine($"Case 1: arr[2, 7, 11, 15] target: 9\nOutput: [{case_1[0]}, {case_1[1]}]");

            int[] case_2_arr = { 3, 2, 4 };
            int[] case_2 = new Easy.TwoSum().Solution(case_2_arr, 6);
            Console.WriteLine($"Case 1: arr[2, 7, 11, 15] target: 9\nOutput: [{case_2[0]}, {case_2[1]}]");

            int[] case_3_arr = { 3, 3 };
            int[] case_3 = new Easy.TwoSum().Solution(case_3_arr, 6);
            Console.WriteLine($"Case 1: arr[2, 7, 11, 15] target: 9\nOutput: [{case_3[0]}, {case_3[1]}]");
        }

        private static void Add_Two_Nums() {
            Medium.AddTwoNumbers.ListNode l1 = new Medium.AddTwoNumbers.ListNode(
                2, 
                new Medium.AddTwoNumbers.ListNode(
                    4, 
                    new Medium.AddTwoNumbers.ListNode(3)
                )
            );
            Medium.AddTwoNumbers.ListNode l2 = new Medium.AddTwoNumbers.ListNode(
                5, 
                new Medium.AddTwoNumbers.ListNode(
                    6, 
                    new Medium.AddTwoNumbers.ListNode(4)
                )
            );
            var result = new Medium.AddTwoNumbers().Solution(l1, l2);
            string ans = "Final Node [";
            int i = 0;
            while (result != null) {
                if (i != 0) {
                    ans += ",";
                } else {
                    i++;
                }
                ans += $"{result.val}";
                result = result.next;
            }
            ans += "]";
            Console.WriteLine(ans);
        }
    }
}