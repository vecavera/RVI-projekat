using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    public GameObject disDisplay;
    public int disRun;
    public bool isAddingDis = false;


    // Update is called once per frame
    void Update()
    {
        if(isAddingDis == false){
            isAddingDis = true;
            StartCoroutine(AddingDis());
        }
        
    }

    IEnumerator AddingDis(){
        disRun += 1;
        disDisplay.GetComponent<Text>().text = "" + disRun;
        yield return new WaitForSeconds(0.45f);
        isAddingDis = false;
    }
}
