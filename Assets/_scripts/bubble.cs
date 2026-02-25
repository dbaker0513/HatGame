using UnityEngine;

public class Bubble : MonoBehaviour
{
    public float speed = 20f;

    void Update()
    {
        // Move the bullet right every frame
        transform.position += Vector3.right * speed * Time.deltaTime;

        // Destroy bubble after 1 second
        Destroy(gameObject, 0.5f);
    }
}
