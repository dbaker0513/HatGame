using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5f;
    public float top = 3.5f;
    public float bottom = -2.5f;
    public GameObject enemyBubblePrefab;
    public bool direction = true;
    public float shootTimer = 0;
    public float health = 5;
    public bool dead = false;
    public int count = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
        Shoot();
    }

    void MoveEnemy()
    {
        
        if(direction)
        {
            // Get the current position of the player
            Vector2 curPos = gameObject.transform.position;

            // Get new position by subtracting from the x coordinate
            Vector2 newPos = new Vector2(curPos.x, curPos.y + Time.deltaTime * speed);

            // Update the player's position
            gameObject.transform.position = newPos;
        }
        else
        {
            // Get the current position of the player
            Vector2 curPos = gameObject.transform.position;

            // Get new position by subtracting from the x coordinate
            Vector2 newPos = new Vector2(curPos.x, curPos.y - Time.deltaTime * speed);

            // Update the player's position
            gameObject.transform.position = newPos;
        }
        
        if (transform.position.y >= top)
    {
        direction = false;
    }
    if (transform.position.y <= bottom)
    {
        direction = true;
    }
    

    }

    void Shoot()
    {
        shootTimer += 1;
        if (shootTimer >= 120)
        {
            shootTimer = 0;
            Instantiate(enemyBubblePrefab, transform.position, Quaternion.identity);
        }
    }

    // made public so other scripts can access it
    // deals a specific number of damage to the enemy, and destroys when health runs out
    public void getHit(float damage)
    {
        health -= damage;

        if(health <= 0)
        {
            count += 1;
            Destroy(gameObject);
        }
        
    }

}

