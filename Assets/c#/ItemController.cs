using UnityEngine;

public class ItemController : MonoBehaviour
{
    private bool collected = false;

    private void Start()
    {
        BoxCollider2D collider = GetComponent<BoxCollider2D>();

        if (collider != null)
        {
            collider.isTrigger = true;
        }

        gameObject.tag = "Item";
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (collected) return;

        if (other.CompareTag("Player"))
        {
            collected = true;

            Debug.Log("アイテムを取得した！");

            if (GameManager.Instance != null)
            {
                GameManager.Instance.CollectItem();
            }
            else
            {
                Debug.LogError("GameManagerが見つかりません！");
            }

            Destroy(gameObject);
        }
    }
}
