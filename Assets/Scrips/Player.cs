using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Material red;
    public Material green;
    public Material blue;
    public string color;
    public GamePlayer gamePlayer;

    void Start()
    {
        this.Reset();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        int moveSpeed = 50;
        if (gamePlayer.winer.gameObject.active == false && gamePlayer.loser.gameObject.active == false)
        {
            if (Input.GetKey("up"))
            {
                // GetComponent<Rigidbody>().AddForce(vel, 0, 0);
                GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, moveSpeed));
            }

            if (Input.GetKey("down"))
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -moveSpeed));

            }
            if (Input.GetKey("left"))
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(-moveSpeed, 0, 0));

            }
            if (Input.GetKey("right"))
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(moveSpeed, 0, 0));

            }

        }
        
    }

    private void Reset () {
         Renderer renderer = GetComponent<Renderer>();
        int random = Random.Range(0,3);
        if (random == 0) {
            renderer.material = red;
            color = "red";
        } else if (random == 1) {
            renderer.material = green;
            color = "green";
        } else if (random == 2) {
            renderer.material = blue;
            color = "blue";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball") {
             Renderer renderer = GetComponent<Renderer>();
             Ball ball = collision.gameObject.GetComponent<Ball>();
            string color = ball.color;
            if (ball.color == this.color) {
                ball.Reset();
                this.Reset();
                Utils.score++;
                if(Utils.score == 10)
                {
                    gamePlayer.GameOver();
                }
            } else {
                // Ket thuc
                gamePlayer.GameOver();
               
            }
        }
    }
}
