
namespace _01_Permutation_of_String;


public class Algorithm
{
    private static string Swap(string str, int i, int j)
    {
        char[] charArray = str.ToCharArray();
        (charArray[j], charArray[i]) = (charArray[i], charArray[j]);
        return new string(charArray);
    }


    public void Permute(string str, int left, int right)
    {
        if (left == right)
            Console.WriteLine(str);

        else {
            for (int i = left; i <= right; i++) {
                str = Swap(str, left, right);
                Permute(str, left + 1, right);
                str = Swap(str, left, i);
            }
        }
    }
}