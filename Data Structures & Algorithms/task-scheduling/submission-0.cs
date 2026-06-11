public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        // Edge cases
        if (tasks == null || tasks.Length == 0) {
            return 0;
        }

        // 1. Count frequencies of each task
        int[] frequencies = new int[26];
        foreach (char task in tasks) {
            frequencies[task - 'A']++;
        }

        // 2. Max-Priority Queue: Tracks the remaining frequency of tasks.
        // C# PriorityQueue is a Min-Heap by default, so we pass negative frequencies
        // to prioritize the highest remaining frequencies first.
        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();
        foreach (int freq in frequencies) {
            if (freq > 0) {
                maxHeap.Enqueue(freq, -freq); 
            }
        }

        // 3. Cooldown Queue: Tracks (remaining_frequency, available_at_cycle_time)
        Queue<(int remainingFreq, int availableTime)> cooldownQueue = new Queue<(int, int)>();
        
        int time = 0;

        // Keep running as long as we have tasks to process in the heap OR waiting in cooldown
        while (maxHeap.Count > 0 || cooldownQueue.Count > 0) {
            time++; // Advance CPU clock by 1 cycle

            // Check if the task at the front of the cooldown queue is ready to be re-queued
            if (cooldownQueue.Count > 0 && cooldownQueue.Peek().availableTime == time) {
                int readyFreq = cooldownQueue.Dequeue().remainingFreq;
                maxHeap.Enqueue(readyFreq, -readyFreq);
            }

            // If we have tasks available in our heap, execute the highest frequency one
            if (maxHeap.Count > 0) {
                int remainingFreq = maxHeap.Dequeue() - 1;

                // If the task still has executions left, send it to the cooldown queue
                if (remainingFreq > 0) {
                    // It can be executed again at: current time + n cooldown cycles
                    cooldownQueue.Enqueue((remainingFreq, time + n + 1));
                }
            }
            // Note: If maxHeap is empty but cooldownQueue has items, the CPU sits IDLE 
            // during this cycle, and the loop continues to advance time.
        }

        return time;
    }
}
