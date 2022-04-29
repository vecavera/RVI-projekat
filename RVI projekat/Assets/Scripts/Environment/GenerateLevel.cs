using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 49;
    public bool creatingSection = false;
    public int secNum;
    

    // Update is called once per frame
    void Update()
    {

        if(creatingSection == false)
        {
           
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        secNum = UnityEngine.Random.Range(0,3);
        Instantiate(section[secNum],new Vector3(0,0,zPos),Quaternion.identity);
        zPos += 49;
        yield return new WaitForSeconds(2);
        creatingSection = false;
    }
}
