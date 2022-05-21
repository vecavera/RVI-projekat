using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    private bool muted = false;
    public Text buttonText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void QuitGame()
    {
        Application.Quit();
        SceneManager.LoadScene("QuitScene");
    }
    public void onButtonPress(){
        if(muted == false){
            muted = true;
            AudioListener.pause = true;
            buttonText.text = "Sound off";
        }
        else{
            muted = false;
            AudioListener.pause = false;
            buttonText.text = "Sound on";
        }
    }
}
