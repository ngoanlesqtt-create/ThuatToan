string haystack = "mississippi";
string needle = "issipi";
int ketQua = StrStr(haystack, needle);
Console.WriteLine(ketQua);
static int StrStr(string haystack, string needle)
{
    if (haystack.Length < needle.Length)
        return -1;
    int j = 0;
 
    for (int i = 0; i <= haystack.Length - needle.Length; i++)
    {
        j = 0;
        while (j < needle.Length && haystack[i + j] == needle[j]) j++;
        if (j == needle.Length) return i;
    }
    return -1;
}