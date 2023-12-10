void IsPalindrome(string str){
    for(int i=0; i<str.Length/2; i++){
        if(str[i] != str[str.Length-1-i]){
            Console.Write($"String [{str}] is not palindrome");
        }
    }
    Console.Write($"String [{str}] is palindrome");
}

string str = "racecar";
IsPalindrome(str);