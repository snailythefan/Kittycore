using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//don't forget scene management!
using UnityEngine.SceneManagement;

public class CambiaEscenas : MonoBehaviour
{
    
    // Update is called once per frame
    public void LoadScene(string sceneName )
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("RestartGame");
    }
            
}