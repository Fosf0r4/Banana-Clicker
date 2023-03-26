using UnityEngine;
using TMPro;

public class Resources_ : MonoBehaviour
{
    [SerializeField] private Clickable _clickable;
    [SerializeField] private TMP_Text _coinsCounter;
    [SerializeField] private TMP_Text _coinsPerSecond;

    public int Coins { get; private set; }
    public int CoinsPerSecond { get; private set; }
    public int NetWorth { get; private set; }

    public void Update()
    {
        CoinsPerSecond = _clickable.ClicksPerSecond * _clickable.CoinsPerClick;

        _coinsCounter.text = $"Бананов: {Coins}";
        _coinsPerSecond.text = $"в секунду: {CoinsPerSecond}";
    }

    public void AddCoins(int value)
    {
        Coins += value;
        NetWorth += value;
    }

    public void AddCoins(int value, int clicks)
    {
        Coins += value * clicks;
        NetWorth += value * clicks;
    }

    public bool TryBuy(int price)
    {
        if (Coins >= price)
        {
            Coins -= price;
            return true;
        }
        else
        {
            return false;
        }
    }
}
