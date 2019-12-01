using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) //if right arrow key is pressed, move in right direction
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(4, 0);
        }
        else if (Input.GetKey(KeyCode.A)) //if left arrow key is pressed, move in left direction
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-4, 0);
        }
        else if (Input.GetKey(KeyCode.W)) //if up arrow key is pressed, move in up direction
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 4);
        }
        else if (Input.GetKey(KeyCode.S)) //if down arrow key is pressed, move in down direction
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

        if (collision.gameObject.tag == "Found") //if player collides with found tag (indicating level area)
        {
            SceneManager.LoadScene("Level_Final"); //load game level
           
        }
    }
}
