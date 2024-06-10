
int[] binaries = [0, 0, 1, 0, 1, 0, 0 ];
int[][] subArrays = {};

Func<int, int> findSubArray = (index) => 
{
    int[] vetAux = [];
    var qtdUm = 0;
    var qtdZero = 0;
    for (int i = index; i < binaries.Length; i++)
    { 
        if(binaries[i] == 0)
        {
            qtdZero++;
        } else
        {
            qtdUm++;
        }

        if(qtdZero == qtdUm || qtdUm == 2 || qtdZero == 2)
        {
            vetAux = vetAux.Append(binaries[i-1]).ToArray();
            vetAux = vetAux.Append(binaries[i]).ToArray();    
        }
    }

    if(vetAux.Length != 0 && vetAux.Length > 2)
    {
        subArrays = subArrays.Append(vetAux).ToArray();
        return 1;
    }

    return 0;
};


for (int i = 0; i < binaries.Length; i++)
{
    findSubArray(i);
}

for (int i = 0; i < subArrays.Length; i++)
{
    for (int j = 0; j < subArrays[i].Length; j++)
    {
        Console.Write($"{subArrays[i][j]}");
    }
}

//https://kingrayhan.medium.com/500-data-structures-and-algorithms-practice-problems-and-their-solutions-b45a83d803f0
//https://www.techiedelight.com/sort-array-containing-0s-1s-2s-dutch-national-flag-problem/