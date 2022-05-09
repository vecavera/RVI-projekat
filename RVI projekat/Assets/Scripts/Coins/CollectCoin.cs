using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource coinFX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        coinFX.Play();
        CollectableControl.coinCount += 1;
        this.gameObject.SetActive(false);
    }
}
