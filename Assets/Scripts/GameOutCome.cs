using UnityEngine;
using TMPro;

public class GameOutCome : MonoBehaviour
{
    [SerializeField] private Resources_ _resources;
    [SerializeField] private GameObject _gameOverWindow;
    [SerializeField] private GameObject _gameWonWindow;
    [SerializeField] private TMP_Text _wonRecord;
    [SerializeField] private TMP_Text _overRecord;

    public void Start()
    {
        _gameOverWindow.SetActive(false);
        _gameWonWindow.SetActive(false);
    }

    public void DetermineOutcome()
    {
        if (_resources.Coins >= 100_000)
        {
            GameWon();
        }
        else
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        _overRecord.text = $"Рекорд: {_resources.Coins}";
        _gameOverWindow.SetActive(true);
        Time.timeScale = 0;
    }

    public void GameWon()
    {
        _wonRecord.text = $"Рекорд: {_resources.Coins}";
        _gameWonWindow.SetActive(true);
        Time.timeScale = 0;
    }


}
