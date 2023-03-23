using UnityEngine;
using TMPro;
public class Resources_ : MonoBehaviour
{
    public int Coins { get; private set; }
    [SerializeField] private int _price;
    [SerializeField] private TMP_Text _coinsCounter;

    public void Update()
    {
        _coinsCounter.text = $"Бананов: {Coins}";
    }

    public void AddCoins()
    {
        Coins += _price;
    }
}
