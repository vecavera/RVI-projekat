using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DeathMenu: MonoBehaviour
{
    public Text scoreText;
    public Text highscore;
    public Image backgroundImg;
    private bool isShowned = false;
    private float transition = 0.0f;
    private void Start()
    {
        //highscore.text = "Highscore : " + PlayerPrefs.GetFloat("Highscore").ToString();
        gameObject.SetActive(false);
        
    }
    private void Update()
    {
        if (!isShowned)
        {
            return;
        }
        transition += Time.deltaTime;
        backgroundImg.color = Color.Lerp(new Color(0,0,0,0),Color.black,transition);
    }
    public void ToggleEndMenu(int score)
    {
       
        gameObject.SetActive(true);
        scoreText.text = (score.ToString());
        isShowned = true;
        CollectableControl.coinCount = 0;
        
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}