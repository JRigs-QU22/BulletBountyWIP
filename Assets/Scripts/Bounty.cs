using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bounty : MonoBehaviour
{
    public GameObject kneeText;
    public int score;
    public Text TellPlay;

    int hits;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Bullet") //if alien is hit by object with bullet tag
        {
            hits++;
            //TellPlay.text = "Score: $" + score;
            if (hits > 0)
            {
                kneeText.SetActive(true);  //display text
                //Destroy(kneeText, 2f);
            }
            if (hits > 3)
            {
                Destroy(gameObject); //destroy object immeadiately
                SceneManager.LoadScene("Scene_Win");
            }
        }
    }
}
