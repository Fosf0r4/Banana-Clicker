using UnityEngine;

public class DestroyerPretender : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CollectedBanana"))
        {
           Destroy(collision.gameObject);
        }         
    }
}
