using UnityEngine;

public class RockTrigger : MonoBehaviour
{
    public FallingRock rock;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") ||
            other.GetComponent<HedgehogController>() != null)
        {
            rock.Fall();
        }
    }
}
