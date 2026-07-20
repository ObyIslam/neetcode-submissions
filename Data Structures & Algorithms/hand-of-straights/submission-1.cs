public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        


        if(hand.Length % groupSize != 0){
            return false;
        }

        Dictionary<int, int> count = new();
        foreach(int card in hand){
            if(!count.ContainsKey(card)){
                count[card] = 0;
            }

            count[card]++;
        }

        PriorityQueue<int, int> minHeap = new();
        foreach(int card in count.Keys){
            minHeap.Enqueue(card,card);
        }

        while(minHeap.Count > 0){
            
            int first = minHeap.Peek();

            for(int i = 0; i < groupSize; i++){
                int card = first + i;

                if(!count.ContainsKey(card)){
                    return false;
                }

                count[card]--;

                if(count[card] == 0){
                    minHeap.Dequeue();
                }
            }


        }
        return true;
    }
}
