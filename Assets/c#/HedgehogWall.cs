using UnityEngine;

public class HedgehogWall : MonoBehaviour
{
    public float backDistance = 0.5f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("harinezumi"))
        {
            collision.transform.position +=
                new Vector3(-backDistance, 0, 0);
        }
    }
}
