using System.Linq;
int FindN(int[] arr, int target)
{
    int low = 0;
    int high = arr.Length - 1;
    while (low < high)
    {
        int mid = low + (high - low) / 2;
        if (arr[mid] == target)
        {
            return mid;
        }
        else if (arr[mid] < target)
        {
            low = mid + 1;
        }
        else
        {
            high = mid - 1;
        }
    }
    return -1;
}
int[] arr = { 1, 23, 55, 2, 334, 27 };
Array.Sort(arr);
int target = 23;
int result = FindN(arr, target);
Console.WriteLine("index of n: " + result);

string LongToBinary(long n)
{
    string result = "";
    while (n > 0)
    {
        result = (n % 2) + result;
        n /= 2;
    }
    return result;
}
Console.WriteLine(LongToBinary(32));
// with recursion
//string LongToBinaryRecursion(long n)
//{
//    if (n == 0)
//    {
//        return "0";
//    }
//    else if (n == 1)
//    {
//        return "1";
//    }
//    else
//    {
//        return LongToBinaryRecursion(n / 2) + (n % 2);
//    }
//}
//Console.WriteLine(LongToBinaryRecursion(32));


//bool CheckVowelOrReturnSymbol(char symbol)
//{
//    char lowerSymbol = char.ToLower(symbol);

//    if (lowerSymbol == 'a' || lowerSymbol == 'e' || lowerSymbol == 'i' || lowerSymbol == 'o' || lowerSymbol == 'u' ||
//        lowerSymbol == 'ა' || lowerSymbol == 'ე' || lowerSymbol == 'ი' || lowerSymbol == 'ო' || lowerSymbol == 'უ')
//    {
//        return true;
//    }
//    return false;
//}
//Console.WriteLine(CheckVowelOrReturnSymbol('ა'));

//with linq
//bool CheckVowelOrReturnSymbol(char symbol)
//{
//    char lowerSymbol = char.ToLower(symbol);

//    string vowels = "aeiouაეიოუ";
//    return vowels.Contains(lowerSymbol);
//}

// with binary search

char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'ა', 'ე', 'ი', 'ო', 'უ' };
char find = 'ა';
Array.Sort(vowels);

bool BinarySearchVowels(char[] vowels, char find)
{
    int left = 0;
    int right = vowels.Length - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (vowels[mid] == find)
        {
            return true;
        }
        else if (vowels[mid] < find)
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }
    return false;
}

bool res = BinarySearchVowels(vowels, find);
Console.WriteLine(res);
