using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Change : MonoBehaviour
{
    public string levelName;
    
    public void GotoLevel() 
    {
        SceneManager.LoadScene(levelName);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GotoLevel();
    }
}
