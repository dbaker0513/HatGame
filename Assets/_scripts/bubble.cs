using UnityEngine;

public class Bubble : MonoBehaviour
{
    public float speed = 20f;
    public float damage = 1f;

    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;

        Destroy(gameObject, 0.5f);
    }

// deal damage to enemies
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
        
            other.GetComponent<EnemyController>().getHit(damage);
            Destroy(gameObject);
        }
    }

}
