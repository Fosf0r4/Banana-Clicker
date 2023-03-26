using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField] private Resources_ _resources;
    [SerializeField] private GameObject _palmShopButton;
    [SerializeField] private GameObject _factoryShopButton;

    [SerializeField] private GameObject _visualisePalms;
    [SerializeField] private GameObject _visualiseFactory;

    [SerializeField] private GameObject _lockedPalmShopButton;
    [SerializeField] private GameObject _lockedFactoryShopButton;

    public void Start()
    {
        _lockedPalmShopButton.SetActive(true);
        _lockedFactoryShopButton.SetActive(true);

        _visualisePalms.SetActive(false);
        _visualiseFactory.SetActive(false);

        _palmShopButton.SetActive(false);
        _factoryShopButton.SetActive(false);
    }

    public void Update()
    {
        if (_resources.NetWorth > 500)
        {
            _lockedPalmShopButton.SetActive(false);
            _palmShopButton.SetActive(true);
            _visualisePalms.SetActive(true);

        }

        if (_resources.NetWorth > 10000)
        {
            _lockedFactoryShopButton.SetActive(false);
            _factoryShopButton.SetActive(true);
            _visualiseFactory.SetActive(true);
        }
    }
}
