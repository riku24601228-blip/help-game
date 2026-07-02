using Unity.VisualScripting;
using UnityEngine;

public class Down_Hide : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            gameObject.SetActive(false);
        }
    }
}
