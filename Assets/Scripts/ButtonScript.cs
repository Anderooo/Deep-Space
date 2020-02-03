using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public Text playText;
    public GameObject title;

    public bool isPlay = true;

    private void Start()
    {
        //Time.timeScale = 0;
    }

    public void Play()
    {
        if(isPlay)
        {
            Time.timeScale = 1;
            playText.text = "RESTART";
            isPlay = false;
            title.SetActive(false);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
}
