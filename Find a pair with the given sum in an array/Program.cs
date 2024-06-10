int[] nums = [8, 7, 2, 5, 3, 1];
int[][] pair = {};
int targ = 10;


Func<int, int, int, int> elemento = (target, num, index) => {
    for (int i = index + 1; i < nums.Length; i++)
    { 
        if((num + nums[i]) == target)
           return nums[i];
    }
    return 0;
};

for (int i = 0; i < nums.Length; i++)
{
    var elSeg = elemento(targ, nums[i], i);
    if(elSeg != 0)
        pair = pair.Append([nums[i], elSeg]).ToArray();
}

for (int i = 0; i < pair.Length; i++)
{
    for (int j = 0; j < pair[i].Length; j++)
    {
        Console.WriteLine(pair[i][j]);
    }
}