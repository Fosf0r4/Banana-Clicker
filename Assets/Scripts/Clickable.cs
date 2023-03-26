using System.Collections;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    [SerializeField] private AnimationCurve _scaleCurve;
    [SerializeField] private float _scaleTime = 0.25f;
    [SerializeField] private Resources_ _resources;
    [SerializeField] private GameObject _hitEffectPrefab;
    [SerializeField] private TextHitEffect _textHitEffectPrefab;
    [SerializeField] private Camera _mainCamera;

    public int CoinsPerClick { get; private set; } = 1;
    public int ClicksPerSecond { get; private set; } = 1;

    private float timer = 0.0f;
    private float waitTime = 0.5f;

    public void Update()
    {
        timer += Time.deltaTime;

        if (timer > waitTime)
        {
            timer = 0.0f;
            _resources.AddCoins(CoinsPerClick, ClicksPerSecond);
        }
    }

    public void Hit()
    {
        StartCoroutine(HitAnimation());
        _resources.AddCoins(CoinsPerClick);

        Vector3 mouseWorldPosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        GameObject hitEffect = Instantiate(_hitEffectPrefab, mouseWorldPosition, Quaternion.identity);
        TextHitEffect textHitEffect = Instantiate(_textHitEffectPrefab, mouseWorldPosition, Quaternion.identity);
        textHitEffect.Init(CoinsPerClick);
    }

    private IEnumerator HitAnimation()
    {
        for (float t = 0; t < 1f; t += Time.deltaTime / _scaleTime)
        {
            float scale = _scaleCurve.Evaluate(t);
            transform.localScale = Vector3.one * scale;
            yield return null;
        }
        transform.localScale = Vector3.one;
    }

    public void AddCoinsPerClick(int value)
    {
        CoinsPerClick += value;
    }

    public void AddClicksPerSecond(int value)
    {
        ClicksPerSecond += value;
    }
}
