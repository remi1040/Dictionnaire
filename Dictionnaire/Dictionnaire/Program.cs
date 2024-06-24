class Program
{
    public static void Main(string[] args)
    {
        Dictionary<char,string> dic = new Dictionary<char,string>();

        dic['a'] = "abruti";
        dic['b'] = "boulot";
        dic['c'] = "carrée";

        dic.Remove('c');

        foreach (string c in dic.Values) { 
        Console.WriteLine(c);}
    }
}
