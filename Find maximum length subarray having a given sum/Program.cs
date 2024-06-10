
int[] nums = [5, 6, -5, 5, 3, 5, 3, -2, 0];
int targ = 8;
int[][] subArrays = {};
int[] largestArray = {};
int aux = 0;


Func<int, int, int> subarraySum = (target, index) => {
    int[] vetAux = [];
    int soma = 0;
    for (int i = index; i < nums.Length; i++)
    {
        vetAux = vetAux.Append(nums[i]).ToArray();
        soma += nums[i];    
        if(target == soma)
        {
            subArrays = subArrays.Append(vetAux).ToArray();
            return 1;
        }
    }
    return 0;
};

for (int i = 0; i < nums.Length; i++)
{
    subarraySum(targ, i);       
}

for (int i = 0; i < subArrays.Length; i++)
{
   if(subArrays[i].Length > aux)
   {
       aux = subArrays[i].Length;
       for (int j = 0; j < subArrays[i].Length; j++)
       {
           largestArray = largestArray.Append(subArrays[i][j]).ToArray();
       }
   }
}

Console.Write("The longest subarray is:");

for (int i = 0; i < largestArray.Length; i++)
{
    Console.Write(" "+ largestArray[i]);
}

Console.Write($" having lenght {largestArray.Length}");
