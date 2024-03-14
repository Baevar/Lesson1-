int N;
string S;
Console.WriteLine("vvedite N");
S = Console.ReadLine();
N = Convert.ToInt16(S);
int i = 1;
while (i<=N)
{
    Console.Write($"{i} ");
    i++;
}