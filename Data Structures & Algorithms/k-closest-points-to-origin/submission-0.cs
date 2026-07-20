public class Solution {
    public int[][] KClosest(int[][] points, int k) {

        PriorityQueue<int[], int> heap = new();

        foreach(int[] point in points){
            int x = point[0];
            int y = point[1];

            int distance = x * x + y * y;

            heap.Enqueue(point, distance);
        }

        int[][] result = new int[k][];

        for(int i = 0; i < k; i++){
            result[i] = heap.Dequeue();
        }

        return result;
        
    }
}
