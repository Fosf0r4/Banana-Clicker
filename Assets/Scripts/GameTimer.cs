using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    [SerializeField] private TMP_Text _timerText;
    [SerializeField] private GameOutCome _gameOutCome;

    public float Time { get; private set; } = 300;

    public void Start()
    {
        _timerText.text = Time.ToString();
    }

    public void Update()
    {
        Time -= UnityEngine.Time.deltaTime;
        _timerText.text = Mathf.Round(Time).ToString();

        if (Time <= 0)
        {
            _gameOutCome.DetermineOutcome();
        }
    }
}
