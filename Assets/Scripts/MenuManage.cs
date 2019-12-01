using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play() //function to load bounty select screen
    {
        SceneManager.LoadScene("Scene_LevelPick");
    }

    public void Options() //function to load options menu
    {
        SceneManager.LoadScene("Scene_Options");
    }

    public void OverWorld() //function to load overworld map
    {
        SceneManager.LoadScene("Final_OverWorld");
    }

    public void LoadLevel() //function to load game level
    {
        SceneManager.LoadScene("Level_Final");
    }
    public void Menu() //function to load menu
    {
        SceneManager.LoadScene("Scene_Start");
    }
    public void Credits() //function to load credits screen
    {
        SceneManager.LoadScene("Scene_Credits");
    }
    public void Controls() //creates function for control screen
    {
        SceneManager.LoadScene("Scene_ Controls");
    }
}
