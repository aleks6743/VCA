using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector2 velocity;
    public Player Player;

    private void Start()
    {
        Player = Player == null ? GetComponent<Player>() : Player;
        if (Player == null)
        {
            Debug.LogError("Player not set to controller");
        }
    }

    private void Update()
    {
        
        
        if (Player != null)
        {
            bool isAnimated = false;
            if (Input.GetKey(KeyCode.D))
            {
                Player.MoveRight();
                velocity.x = 3;
                isAnimated = true;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                Player.MoveLeft();
                velocity.x = -3;
                isAnimated = true;
            } else
            {
                velocity.x = 0;
            }

           
            if (Input.GetKey(KeyCode.S))
            {
                if(!isAnimated) Player.MoveDown();
                velocity.y = -1;
            }


            else if (Input.GetKey(KeyCode.W))
            {
                if (!isAnimated) Player.MoveUp();
                velocity.y = 1;
            }
           else velocity.y = 0;

        //    Debug.Log(velocity.y);
         //   Debug.Log(velocity.x);
         //   Debug.Log(isAnimated);

            rb.velocity = velocity;
        }
       
    }

}
