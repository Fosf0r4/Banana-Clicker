using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UnitShop : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Resources_ _resources;
    [SerializeField] private int _count;
    [SerializeField] private int _price;
    [SerializeField] private int reward;
    [SerializeField] private float coeffPrice = 1.8f;
    [SerializeField] private Clickable _�lickable;
    [SerializeField] private TMP_Text _buttonText;
    [SerializeField] private TMP_Text _countText;

    public void Update()
    {
        _buttonText.text = $"+ {reward} ����(��)/c\r\n����: {_price}";
        _countText.text = _count.ToString();
    }

    private void Start()
    {
        _button.onClick.AddListener(Buy);
    }

    public void Buy()
    {
        if (_resources.TryBuy(_price))
        {
            _count += 1;
            _�lickable.AddClicksPerSecond(reward);
            _price = Mathf.RoundToInt(_price * coeffPrice);
        }
    }
}
