using UnityEngine;

public class HedgehogController : MonoBehaviour
{
    public float fallThreshold = -3f;

    void Update()
    {
        CheckFall();
    }

    private void CheckFall()
    {
        if (transform.position.y < fallThreshold)
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.GameOver();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (GameManager.Instance != null)
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}
