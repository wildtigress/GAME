using UnityEngine;

public class BasketController : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * move * speed * Time.deltaTime);

        // Clamp position within screen bounds
        float xPosition = Mathf.Clamp(transform.position.x, -8f, 8f);
        transform.position = new Vector2(xPosition, transform.position.y);
    }
}
