int[] input = [2, 5, 0, 2, 1, 4, 3, 5, 1, 0];
int[] output = [];


Func<int, int, bool> sub = (num, index) => {
    for (int i = index + 1; i < input.Length; i++)
    {
        if(num == input[i])
            return false;
    }

    return true;
};

for (int i = 0; i < input.Length; i++)
{
    var elemento = sub(input[i], i);
    if (elemento)
      output = output.Append(input[i]).ToArray();
}

Console.Write("The largest subarray is: ");
for (int i = 0; i < output.Length; i++)
{
    Console.Write(output[i]);
}