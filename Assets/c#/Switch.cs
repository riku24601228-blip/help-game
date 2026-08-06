using UnityEngine;

public class Switch : MonoBehaviour
{
    public Elevator[] elevators;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (Elevator elevator in elevators)
            {
                elevator.SetMoveUp(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (Elevator elevator in elevators)
            {
                elevator.SetMoveUp(false);
            }
        }
    }
}
