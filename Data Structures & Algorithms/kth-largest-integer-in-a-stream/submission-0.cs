public class KthLargest {

    private PriorityQueue<int,int> heap;
    private int k;

    public KthLargest(int k, int[] nums) {
        
        this.k = k;
        heap = new PriorityQueue<int,int>();

        foreach(int num in nums){
            Add(num);
        }


    }
    
    public int Add(int val) {
        
        heap.Enqueue(val,val);

        if(heap.Count > k){
            heap.Dequeue();
        }

        return heap.Peek();
    }
}
