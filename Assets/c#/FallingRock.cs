using UnityEngine;

public class FallingRock : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool hasFallen = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // 最初は落ちない
        rb.gravityScale = 0;
    }

    public void Fall()
    {
        if (hasFallen) return;

        hasFallen = true;
        rb.gravityScale = 1;
    }
}
