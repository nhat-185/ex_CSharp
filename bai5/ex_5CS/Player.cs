class Player
{
    public int Money { get; private set; }

    public Player(int initialMoney) // khoi tao player voi so tien ban dau
    {
        Money = initialMoney;   // money hien tai player
    }

    public void Win(int money)  // player win
    {
        Money += money;
    }

    public void Lose(int money) // player lose
    {
        Money -= money;
    }
}