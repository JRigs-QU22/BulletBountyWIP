using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bounty : MonoBehaviour
{
    public int score;
    public Text TellPlay;

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

        if (collision.gameObject.tag == "Bullet") //if alien is hit by object with bottom tag
        {
            score += 30;
            TellPlay.text = "Score: $" + score;
            Destroy(gameObject); //destroy object immeadiately
            SceneManager.LoadScene("Scene_Win");
        }
    }
}
