using System.Collections;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    [SerializeField] private AnimationCurve _scaleCurve;
    [SerializeField] private float _scaleTime = 0.25f;
    [SerializeField] private Resources_ _resources;
    [SerializeField] private GameObject _hitEffectPrefab;
    [SerializeField] private Camera _mainCamera;

    public void Hit()
    {
        StartCoroutine(HitAnimation());
        _resources.AddCoins();

        Vector3 mouseWorldPosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        GameObject hitEffect = Instantiate(_hitEffectPrefab, mouseWorldPosition, Quaternion.identity);
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
}
