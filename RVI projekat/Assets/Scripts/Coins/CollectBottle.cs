using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBottle : MonoBehaviour
{
    public AudioSource bottleFX;
    private void OnTriggerEnter(Collider other) {
        bottleFX.Play();
        this.gameObject.SetActive(false);
    }
}
