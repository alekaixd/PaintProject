using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] private Scene MainMenu, Level_1, Level_2, Level_3, EndScreen;
private void OnTriggerEnter2D(Collider2D collision)
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
