using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public GameObject bubblePrefab;
    public int bubbleTimer = 30;
    public int bubbleCount = 0;
      public float health = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        Shoot();
    }

    void MovePlayer()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            // Get the current position of the player
            Vector2 curPos = gameObject.transform.position;

            // Get new position by adding to the x coordinate
            Vector2 newPos = new Vector2(curPos.x + Time.deltaTime * speed, curPos.y);

            // Update the player's position
            gameObject.transform.position = newPos;
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            // Get the current position of the player
            Vector2 curPos = gameObject.transform.position;

            // Get new position by subtracting from the x coordinate
            Vector2 newPos = new Vector2(curPos.x - Time.deltaTime * speed, curPos.y);

            // Update the player's position
            gameObject.transform.position = newPos;
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            // Get the current position of the player
            Vector2 curPos = gameObject.transform.position;

            // Get new position by subtracting from the x coordinate
            Vector2 newPos = new Vector2(curPos.x, curPos.y + Time.deltaTime * speed);

            // Update the player's position
            gameObject.transform.position = newPos;
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            // Get the current position of the player
            Vector2 curPos = gameObject.transform.position;

            // Get new position by subtracting from the x coordinate
            Vector2 newPos = new Vector2(curPos.x, curPos.y - Time.deltaTime * speed);

            // Update the player's position
            gameObject.transform.position = newPos;
        }
        
    

    }
    void Shoot()
    {
        bubbleCount += 1;
        if (Input.GetKey(KeyCode.Space) && bubbleCount > bubbleTimer)
        {
            Instantiate(bubblePrefab, transform.position, Quaternion.identity);
            bubbleCount = 0;
        }
    }

    public void getHit(float damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Destroy(gameObject);
        }
        
    }

}

