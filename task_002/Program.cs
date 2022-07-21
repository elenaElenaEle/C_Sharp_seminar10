// 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.
// n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са,
// ав, ва, ви, ив, св, вс

string[] Words (string[] alf, int num)
{
    if (num == 0) 
    {
        string[] res = new string[1];
        res[0] = "";
        return res;
    };
    string[] temp = Words(alf, num - 1); 
    string[] result = new string[temp.Length * alf.Length];
    int index = 0;
    for (int i = 0; i < temp.Length; i++)
    {
        for (int j = 0; j < alf.Length; j++)
        {
            result[index] = temp[i] + alf[j];
            index++; 
        }
    }
    return result;
 }

string[] alfabet = {"а", "и", "с", "в"};
Console.WriteLine("Введите колтчество букв в слове: ");
int n = int.Parse(Console.ReadLine());

string[] result = Words(alfabet, n);
for (int i = 0; i < result.Length; i++)
{
Console.Write(i + " " + result[i] + " ");
Console.WriteLine();
}