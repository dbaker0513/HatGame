using UnityEngine;

public class EnemyBubble : MonoBehaviour
{
    public float speed = 20f;
    public float damage = 1f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        Destroy(gameObject, 0.5f);
    }

// deal damage to enemies
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
        
            other.GetComponent<PlayerController>().getHit(damage);
            Destroy(gameObject);
        }
    }

}
