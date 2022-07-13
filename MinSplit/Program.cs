static int MinSplit(int amount)
{
    int[] coins = new int[5] { 50, 20, 10, 5, 1 };
    int count = 0;
    foreach (int coin in coins)
    {
        count += amount / coin;
        amount %= coin;
        if (amount == 0)
            break;
    }
    return count;
}
Console.WriteLine(MinSplit(337));