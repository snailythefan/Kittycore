using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//don't forget scene management!
using UnityEngine.SceneManagement;

public class CambiaEscenas : MonoBehaviour
{
    public Animator transition;

    public float transTime = 1f;

    public AudioSource click;

    
    // Update is called once per frame
    public void LoadNextLevel()
    {
        click.Play();
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        
    }

    IEnumerator LoadLevel (int levelIndex)
    {
        //play animation
        transition.SetTrigger("Start"); //this activates our animation trigger called "Start"

        //wait
        yield return new WaitForSeconds(transTime);

        //loadScene
        SceneManager.LoadScene(levelIndex);
        Debug.Log("GameStart");
    }
            
}