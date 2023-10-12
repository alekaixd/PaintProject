using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public GameObject levelClearedScreen;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.CompareTag("Player"))
        {
            levelClearedScreen.SetActive(true);
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
