public class Solution {
    public int CountPrimes(int n) {
        // There are no primes strictly less than 2
        if (n <= 2) return 0;

        // isComposite[i] will be true if 'i' is NOT a prime number.
        // Default values in a bool array are false.
        bool[] isComposite = new bool[n];
        int count = 0;

        for (int num = 2; num < n; num++) {
            if (!isComposite[num]) {
                count++;
                // Mark all multiples of num starting from num * num as composite
                for (long i = (long)num * num; i < n; i += num) {
                    isComposite[i] = true;
                }
            }
        }

        return count;
    }
}