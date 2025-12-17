class House
{
    public int Money { get; private set; }
    private Dice dice = new Dice();

    public House(int initialMoney)
    {
        Money = initialMoney;   // tien ban dau
    }

    public int[] RollDice()     // 3 xuc xac; 
    {
        int[] results = new int[3];
        for (int i = 0; i < 3; i++)
        {
            results[i] = dice.Roll();
        }
        return results;
    }

    public void Win(int amount)  // house win
    {
        Money += amount;
    }

    public void Lose(int amount) // house lose
    {
        Money -= amount;
    }
}
