using UnityEngine;

public class Switch : MonoBehaviour
{
    public Elevator elevator;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            elevator.SetMoveUp(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            elevator.SetMoveUp(false);
        }
    }
}
