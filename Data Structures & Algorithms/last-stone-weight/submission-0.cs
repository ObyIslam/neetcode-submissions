public class Solution {
    public int LastStoneWeight(int[] stones) {
        
        PriorityQueue<int,int> heap = new PriorityQueue<int,int>(
            Comparer<int>.Create((a,b) => b.CompareTo(a))
        );

        foreach(int stone in stones){
            heap.Enqueue(stone,stone);
        }

        while(heap.Count > 1){
            int first = heap.Dequeue();
            int second = heap.Dequeue();

            if(first != second){
                heap.Enqueue(first - second, first - second);
            }
        }

        if(heap.Count == 0){
            return 0;
        }

        return heap.Peek();
    }
}
