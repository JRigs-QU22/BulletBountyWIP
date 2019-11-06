using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public Text tellplay; // text field to update
    int hits; // counts how many times player gets hit

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) //if right arrow key is pressed, move in right direction
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(4, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow)) //if left arrow key is pressed, move in left direction
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-4, 0);
        }
        else if (Input.GetKey(KeyCode.Space)) //if up arrow key is pressed, move in up direction
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 10, 0), ForceMode2D.Impulse);

            Debug.Log("jump");
        }
        else if (Input.GetKey(KeyCode.DownArrow)) //if down arrow key is pressed, move in down direction
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -4);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0); //if neither is pressed, don't move at all
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "EBullet") //if alien is hit by object with bottom tag
        {
            hits++; //increase hit int by one
            tellplay.text = "Hits Taken:" + hits; //Print this to console 

            if (hits > 4) //if you get hit 5 times
            {
                Destroy(gameObject); //destroy plsyer

                SceneManager.LoadScene("Scene_Lose"); //Load lose screen
            }
        }
    }
}
