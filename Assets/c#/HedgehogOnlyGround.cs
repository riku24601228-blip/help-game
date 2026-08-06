using UnityEngine;

public class HedgehogOnlyGround : MonoBehaviour
{
    private Collider2D groundCollider;

    void Start()
    {
        groundCollider = GetComponent<Collider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Physics2D.IgnoreCollision(collision.collider, groundCollider, true);
        }
    }
}
