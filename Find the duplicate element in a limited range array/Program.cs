int[] vetor = [1, 2, 3, 4, 2];

Func<int, int, bool> duplicate = (num, index) => {
    
    for (int i = index + 1; i < vetor.Length; i++)
    {
        if(num == vetor[i])
            return true;
    }

    return false;
};

for (int i = 0; i < vetor.Length; i++)
{
    var elemento = duplicate(vetor[i], i);
    if(elemento != false)
       Console.WriteLine($"The duplicate element is: {vetor[i]}");
}
