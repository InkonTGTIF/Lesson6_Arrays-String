string GetStringFromCharArray(char [,] chars){
    string res = "";
    foreach (char elem in chars){
        res+=elem;
    }
    return res;
}

char [,] chars = {
    {'a','F','q','G','F'},
    {'v','F','u','Q','F'},
    {'H','i','B','o','w'},
    {'P','f','m','C','H'}
};

string str = GetStringFromCharArray(chars);
Console.WriteLine(str);