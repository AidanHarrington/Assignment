using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Manager : MonoBehaviour {
    
    public  void LoadLevel(string levelName)
    {
        print("Loading Level " + levelName);
        //loads the scene
        SceneManager.LoadScene(levelName);
    }

    public void brickDestroy()
    {
        if (Brick.breakableCount <= 0)
        {
            LoadNextLevel();
        }
    }

    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
