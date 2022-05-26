using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Healthbar : MonoBehaviour
{
    public Image currentHealthbar;
    public TextMeshProUGUI ratioText;
    private float hitpoint = 100;
    private float maxHitpoint = 100;
    public DeathMenu deathMenu;
    private void Start()
    {
        UpdateHealthbar();
    }
    private void UpdateHealthbar()
    {
        float ratio = hitpoint / maxHitpoint;
        currentHealthbar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        ratioText.text = (ratio * 100).ToString("0") + '%';
    }
    private void TakeDamage(float damage)
    {
        hitpoint -= damage;
        if(hitpoint <= 0)
        {
            hitpoint = 0;
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.GetComponent<PlayerMove>().enabled = false;
            //if(PlayerPrefs.GetFloat("Highscore") < CollectableControl.coinCount)
            //PlayerPrefs.SetFloat("Highscore",(float)CollectableControl.coinCount)
            deathMenu.ToggleEndMenu(CollectableControl.coinCount, CollectableControl.distanceCount);
           
        }
        UpdateHealthbar();
    }
    private void HealDamage(float heal)
    {
        hitpoint += heal;
        if (hitpoint > maxHitpoint)
        {
            hitpoint = maxHitpoint;
        }
        UpdateHealthbar();
    }


}
