using UnityEngine;
using System.Collections;

public class SpringVisual : MonoBehaviour
{
    public Sprite normalSprite;
    public Sprite pressedSprite;

    // どのくらい近づいたら反応するか
    public float triggerDistance = 1.0f;

    // 押されたときに下がる量
    public float pressedOffsetY = -0.1f;

    // 押された状態の時間
    public float pressedTime = 2f;

    private SpriteRenderer spriteRenderer;
    private Vector3 originalPosition;

    private bool isPressed = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalPosition = transform.localPosition;

        if (normalSprite != null)
        {
            spriteRenderer.sprite = normalSprite;
        }
    }

    void Update()
    {
        if (isPressed)
        {
            return;
        }

        GameObject player = GameObject.FindGameObjectWithTag("Player");

        GameObject[] hedgehogs =
            GameObject.FindGameObjectsWithTag("harinezumi");

        // プレイヤーが近いか
        if (player != null)
        {
            float distance =
                Vector2.Distance(transform.position, player.transform.position);

            if (distance <= triggerDistance)
            {
                PressSpring();
                return;
            }
        }

        // ハリネズミが近いか
        foreach (GameObject hedgehog in hedgehogs)
        {
            float distance =
                Vector2.Distance(transform.position, hedgehog.transform.position);

            if (distance <= triggerDistance)
            {
                PressSpring();
                return;
            }
        }
    }

    private void PressSpring()
    {
        if (isPressed)
        {
            return;
        }

        isPressed = true;

        Debug.Log("ばねが近くに反応した！");

        // 押された画像
        if (pressedSprite != null)
        {
            spriteRenderer.sprite = pressedSprite;
        }

        // Y座標を下げる
        transform.localPosition =
            originalPosition + new Vector3(0, pressedOffsetY, 0);

        StartCoroutine(ReturnNormal());
    }

    private IEnumerator ReturnNormal()
    {
        yield return new WaitForSeconds(pressedTime);

        // ノーマル画像
        if (normalSprite != null)
        {
            spriteRenderer.sprite = normalSprite;
        }

        // 元の位置
        transform.localPosition = originalPosition;

        isPressed = false;
    }
}