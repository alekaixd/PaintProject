using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class NextLevel : MonoBehaviour
{
    public GameObject levelClearedScreen;
    public GameObject player;
    public int stars;
    public GameObject[] starObjects;


    private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.CompareTag("Player"))
        {
            levelClearedScreen.SetActive(true);
            starObjects[0].SetActive(false);
            starObjects[1].SetActive(false);
            starObjects[2].SetActive(false);
            if (stars >= 1)
            {
                Debug.Log(stars);
                starObjects[0].SetActive(true);
            }
            if (stars >= 2)
            {
                Debug.Log(stars);
                starObjects[1].SetActive(true);
            }
            if (stars >= 3)
            {
                Debug.Log(stars);
                starObjects[2].SetActive(true);
            }
        }
    
}

    public void LoadNextLevel()
    {
        var currentscene = SceneManager.GetActiveScene();
        if (currentscene == SceneManager.GetSceneByName("Level 1"))
        {
            SceneManager.LoadScene("Level 2");
        }
        if (currentscene == SceneManager.GetSceneByName("Level 2"))
        {
            SceneManager.LoadScene("Level 3");
        }
        if (currentscene == SceneManager.GetSceneByName("Level 3"))
        {
            GameObject.Find("MUSIC MAN").GetComponent<MusicClass>().StopMusic();
            SceneManager.LoadScene("Endscreen");
        }
    }
}
