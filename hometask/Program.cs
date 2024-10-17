#region matrisin elementlerinuin cemi
int[,] matrix = new int[4, 4]
{
    {4,2,7,6 },
    {3,76,34,12 },
    {2,45,67,93 },
    {34,63,16,72 },
   
};


int cem = 0;
for (int i = 0; i < 4; i++)
{
    for (int t = 0; t < 4; t++)
    {
        cem += matrix[i, t];
    }

}

Console.Writeline(cem);
#endregion

int[,] matrix = new int[4, 4]
{
    {4,2,7,6 },
    {3,76,34,12 },
    {2,45,67,93 },
    {34,63,16,72},
};

int cem = 0;
int upsum = 0;
int dsum = 0;

for (int i = 0; i < 4; i++)
{
    for (int t = 0; t < 4; t++)
    {
        if (i < t)
        {
            upsum += matrix[i, t];
        }
        else if (i > t)
        {
            dsum += matrix[i, t];
        }
    }

}

cem = upsum - dsum;
Console.Writeline(cem);


int num = 7;
int faktorial = 1;
for (int i = 0; i < num;)
{

    faktorial *= num;

    num--;
}
Console.WriteLine(); (faktorial);



int[] alg = { 1, 4, 6, 2, 3, 8 };


for (int i = 0; i < alg.Length; i++)
{

    Console.WriteLine(); (alg[i]);

}