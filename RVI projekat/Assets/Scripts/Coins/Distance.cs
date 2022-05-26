using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    public GameObject disDisplay;
    public int disRun;
    public bool isAddingDis = false;
    public float waitShorter = 0.95f;
    float min = 0.20f;



    // Update is called once per frame
    void Update()
    {
        if(waitShorter > min){
            waitShorter -=0.01f* Time.deltaTime;
        }
        if(isAddingDis == false){
            isAddingDis = true;
            StartCoroutine(AddingDis(waitShorter));
        }
        

        
        
    }

    IEnumerator AddingDis(float ws){
        disRun += 1;
        CollectableControl.distanceCount += 1;
        disDisplay.GetComponent<Text>().text = "" + disRun;
        yield return new WaitForSeconds(ws);
        isAddingDis = false;
    }
}
