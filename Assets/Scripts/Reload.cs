using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour
{
    public AudioSource cock; //allows insert of audio source
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1)) //set gun control to true on right click, and play cocking sound
        {
            gameObject.GetComponent<Gun>().enabled = true; 
            cock.Play();
        }
    }
}
