using UnityEngine;

public class Switch : MonoBehaviour
{
    public Elevator[] elevators;

    public Sprite offSprite;
    public Sprite onSprite;

    public float onOffsetY = -0.1f;

    private SpriteRenderer spriteRenderer;
    private Vector3 originalPosition;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalPosition = transform.localPosition;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (Elevator elevator in elevators)
            {
                elevator.SetMoveUp(true);
            }

            if (spriteRenderer != null && onSprite != null)
            {
                spriteRenderer.sprite = onSprite;
                transform.localPosition = originalPosition + new Vector3(0, onOffsetY, 0);
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

            if (spriteRenderer != null && offSprite != null)
            {
                spriteRenderer.sprite = offSprite;
                transform.localPosition = originalPosition;
            }
        }
    }
}
