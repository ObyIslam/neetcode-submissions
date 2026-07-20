public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        
        int total = 0;
        int current = 0;
        int start = 0;

        for(int i = 0; i < gas.Length; i++){
            
            int fuel = gas[i] - cost[i];

            total += fuel;
            current += fuel;

            if(current < 0){
                start = i + 1;
                current = 0;
            }
        }

        if(total < 0){
            return -1;
        }

        return start;
    }
}
