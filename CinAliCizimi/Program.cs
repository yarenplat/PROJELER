using System.Globalization;

char[,] dotMatris = new char[60, 60];
for (int i = 0; i < dotMatris.GetLength(0); i++)
{
    for (int j = 0; j < dotMatris.GetLength(1); j++)
    {
        dotMatris[i, j] = ' ';
    }
}
//Kafa Çizimi
KafaCiz();
GovdeCizimi();
Uzuvlar(0);
EkranaYaz();
/*
 * 30,10
 * 40,20
 * 30,30
 * 20,20
 */
void KafaCiz(int x = 10, int y = 10)
{
    int sayac1 = 0;
    for (int i = 10; i >= -10; i -= 2)
    {
        int sayac2 = 20;
        for (int j = -10; j <= 10; j++)
        {
            int hesap = (int)Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2));
            if (hesap == 10)
            {
                dotMatris[sayac1, sayac2] = '.';
            }
            sayac2++;

        }
        sayac1++;

    }
}
//Gövde Çizimi

void GovdeCizimi()
{
    for (int i = 0; i < 15; i++)
    {
        dotMatris[10 + i, 30 ] = '.';

    }
}



void Uzuvlar(int param)
{
    //sağ kol
    for (int i = 0; i < 10; i++)
    {
        dotMatris[10 + i, 30 + i] = '.';
    }
    //sol kol
    for (int i = 0; i < 10; i++)
    {
        dotMatris[10 + i, 30 - i] = '.';
    }
    //sağ bacak
    //sağ bacak
    for (int i = 0; i < 10; i++)
    {
        dotMatris[25 + i, 30 + i] = '.';
    }
    //sol bacak
    for (int i = 0; i < 10; i++)
    {
        dotMatris[25 + i, 30 - i] = '.';
    }
}

//Ekrana Yaz
void EkranaYaz(bool isClear = true)
{
    if (isClear) Console.Clear();
    for(int i=0; i<dotMatris.GetLength(0); i++)
    {
        for(int j=0; j< dotMatris.GetLength(1); j++)
        {
            Console.Write(dotMatris[i,j]);
        }
        Console.WriteLine();
    }
}
