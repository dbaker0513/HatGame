using UnityEngine;

public class BubbleController : MonoBehaviour
{

    // class to control the bubble that the fish will shoot out to damage the enemies. 
    //Since this is a shoot em up style game, need to implement shoot em up functionality

    public float speed = 100000f;
    public float bubbleSpeed = 2f;
    [HideInInspector]public int bubbleTime = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveBubble();
        ShootBubble();
    }


    void MoveBubble()
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


/* honestly i just cannot for the life of me get this to work properly yet.
 is meant to send out this bubble that's stored below the fish
 when space is pressed, then bring it back. Eventually I'd add
 collision with enemies and damage to it. Want to tweak functionality
 later so the bubble 'disappears' and teleports back behind player
 anyway when i figure out how to. But shoot method has big issues with
 everything, so I'm commenting out to submit until I figure it out*/

    void ShootBubble()
    {
        /* if(Input.GetKeyDown(KeyCode.Space) && bubbleTime <= 0)
        {
            bubbleTime = 40;
        }
        if (bubbleTime >= 20) 
            {
                Vector2 curPos = gameObject.transform.position;

                // Get new position by adding to the x coordinate
                Vector2 newPos = new Vector2(curPos.x + Time.deltaTime * bubbleSpeed, curPos.y);

                // Update the player's position
                gameObject.transform.position = newPos;
                bubbleTime -= 1;
            }
        else if (bubbleTime > 0)
            {
                Vector2 curPos = gameObject.transform.position;

                // Get new position by adding to the x coordinate
                Vector2 newPos = new Vector2(curPos.x - Time.deltaTime * bubbleSpeed, curPos.y);

                // Update the player's position
                gameObject.transform.position = newPos;
                bubbleTime -= 1;
                
            }
            */
    }
}
