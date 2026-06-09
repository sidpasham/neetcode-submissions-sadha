public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        // Edge cases
        if (position == null || position.Length == 0) {
            return 0;
        }

        int n = position.Length;
        
        // 1. Pair positions and speeds together so we can sort them properly
        // We'll use an array of tuples: (position, speed)
        (int pos, int spd)[] cars = new (int pos, int spd)[n];
        for (int i = 0; i < n; i++) {
            cars[i] = (position[i], speed[i]);
        }

        // Sort cars by position in ascending order
        Array.Sort(cars, (a, b) => a.pos.CompareTo(b.pos));

        // Use a stack to track the time it takes for fleet leaders to arrive
        Stack<double> fleetTimes = new Stack<double>();

        // 2. Loop BACKWARD through the sorted cars (from closest to target to furthest away)
        for (int i = n - 1; i >= 0; i--) {
            // Calculate time taken as a double to preserve decimal precision
            double timeToTarget = (double)(target - cars[i].pos) / cars[i].spd;

            // If the stack is empty, this car is the leader of the first fleet
            if (fleetTimes.Count == 0) {
                fleetTimes.Push(timeToTarget);
            }
            // If this car takes STRICTLY MORE time than the fleet in front of it,
            // it can never catch up. It becomes the leader of a brand new fleet!
            else if (timeToTarget > fleetTimes.Peek()) {
                fleetTimes.Push(timeToTarget);
            }
            // Note: If timeToTarget <= fleetTimes.Peek(), it catches up to the fleet 
            // in front of it, so we do nothing (it becomes part of that existing fleet).
        }

        // The number of remaining elements in the stack is our total number of fleets
        return fleetTimes.Count;
    }
}