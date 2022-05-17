using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool paused;
    // Start is called before the first frame update
    void Start()
    {
        paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        PauseGame();
    }
    public void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            paused = !paused;
        }
        if (paused)
        {
            Time.timeScale = 0;
        }
        else if (!paused)
        {
            Time.timeScale = 1;
        }
    }
}
