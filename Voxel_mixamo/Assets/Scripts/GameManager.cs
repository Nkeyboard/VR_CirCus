using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public FirstPersonAIO firstpersonaio;
    public GameObject canvas;
    public GameObject titleMusic;
    public GameObject gameMusic;

    // Start is called before the first frame update
    void Start()
    {
        firstpersonaio.lockAndHideCursor = false;
        firstpersonaio.ControllerPause();
        titleMusic.SetActive(true);
        gameMusic.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canvas.activeSelf)
            {
                canvas.SetActive(false);
                titleMusic.SetActive(false);
                gameMusic.SetActive(true);
            }
            else
            {
                canvas.SetActive(true);
                titleMusic.SetActive(true);
                gameMusic.SetActive(false);
            }
        }
    }

    public void EnterGame()
    {
        firstpersonaio.lockAndHideCursor = true;
        firstpersonaio.ControllerPause();
        titleMusic.SetActive(false);
        gameMusic.SetActive(true);
    }
}
