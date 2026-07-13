public class Solution {
    public int EvalRPN(string[] tokens) {

        Stack<int> stack = new();
        
        foreach(string token in tokens){

            int a = 0;
            int b = 0;
            

            if(token == "+" || token == "-" || token == "*" || token == "/")
            {
                a = stack.Pop();
                b = stack.Pop();

                int result = 0;
                if(token == "+")
                {
                    result = b + a;
                }
                else if(token == "-")
                {
                    result = b - a;
                }
                else if(token == "*")
                {
                    result = b * a;
                }
                else if(token == "/")
                {
                    result = b / a;
                }
                stack.Push(result);
            }
            else
            {
                stack.Push(int.Parse(token));
            }
            
            

        }

        return stack.Peek();
    }
}
