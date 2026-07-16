using UnityEngine;

public class Elevator : MonoBehaviour
{
    public Transform upPoint;
    public Transform downPoint;
    public float speed = 2f;

    private bool isUp = false;

    void Update()
    {
        if (isUp)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                upPoint.position,
                speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                downPoint.position,
                speed * Time.deltaTime);
        }
    }

    public void SetMoveUp(bool value)
    {
        isUp = value;
    }
}
