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

    public void Play()
    {
        SceneManager.LoadScene("Scene_LevelPick");  
    }

    public void Options()
    {
        SceneManager.LoadScene("Scene_Options");
    }

    public void OverWorld()
    {
        SceneManager.LoadScene("Scene_OverWorld");
    }
    
    public void LoadLevel()
    {
        SceneManager.LoadScene("Scene_Level1");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Scene_Start");
    }
}
