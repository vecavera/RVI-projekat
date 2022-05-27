using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBottle : MonoBehaviour
{
    public AudioSource bottleFX;
    public float heal = 5;
    
    
    private void OnTriggerEnter(Collider other) {
        bottleFX.Play();
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SendMessage("HealDamage", Time.deltaTime * heal);
        }
        this.gameObject.SetActive(false);
    }
}
