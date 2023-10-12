using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    
    public void TaskOnClick()
    {

        GameObject music = GameObject.Find("MUSIC MAN");
        Destroy(music);
        SceneManager.LoadScene("Main Menu");
    }
}
