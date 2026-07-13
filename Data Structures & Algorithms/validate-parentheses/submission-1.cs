public class Solution {
    public bool IsValid(string s) {

        Stack<char> stack = new();

        foreach(char c in s)
        {
            // If it is an opening bracket, store it
            if(c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else
            {
                // If there is no opening bracket to match with
                if(stack.Count == 0)
                {
                    return false;
                }

                // Look at the most recent opening bracket
                char top = stack.Peek();

                // Check if the brackets match
                if((c == ')' && top != '(') ||(c == ']' && top != '[') ||(c == '}' && top != '{'))
                {
                    return false;
                }

                // Remove the matched opening bracket
                stack.Pop();
            }
        }

        return stack.Count == 0;
    }
}