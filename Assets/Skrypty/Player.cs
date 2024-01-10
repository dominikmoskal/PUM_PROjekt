using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 direction;
    public float gravity = -38f; // Zwiêkszona wartoœæ grawitacji
    public float strength = 10f; // Zwiêkszona si³a

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * strength*3/2;
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * strength*3/2;
            }
        }

        direction.y += gravity *6 * Time.deltaTime;
        transform.position += direction *5* Time.deltaTime;
    }
}
