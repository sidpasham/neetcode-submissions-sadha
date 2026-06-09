public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        // Edge cases
        
        List<(int p, int s)> cars = new List<(int p, int s)>();

        for(int i = 0; i < position.Length; i++) {
            cars.Add(new (position[i], speed[i]));
        }

        cars.Sort((a, b) => a.p.CompareTo(b.p));

        Stack<double> times = new Stack<double>();

        // from backward
        for(int i = cars.Count() - 1; i >= 0; i--) {
            var timeToTarget = (double)(target - cars[i].p) / (cars[i].s);

            // already reach target
            if(times.Count() == 0) {
                times.Push(timeToTarget);
                // if its already forward, then its a new leader
            } else if (timeToTarget > times.Peek()) {
                times.Push(timeToTarget);
            }
        }

        return times.Count();
    }
}