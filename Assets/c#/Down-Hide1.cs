using UnityEngine;

public class Down_Hide1 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("harinezumi"))
        {
            gameObject.SetActive(false);
        }
    }
}