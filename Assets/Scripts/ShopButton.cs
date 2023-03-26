using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Resources_ _resources;
    [SerializeField] private int _price;
    [SerializeField] private float coeffPrice = 1.8f;
    [SerializeField] private Clickable _ñlickable;
    [SerializeField] private TMP_Text _buttonText;

    public void Update()
    {
        _buttonText.text = $"{_price}";
    }

    private void Start()
    {
        _button.onClick.AddListener(Buy);
    }

    public void Buy()
    {
        if (_resources.TryBuy(_price))
        {
            _ñlickable.AddCoinsPerClick(1);
            _price = Mathf.RoundToInt(_price * coeffPrice);
        }
    }
}
