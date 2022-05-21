using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5; 
    public float leftRigthSpeed = 4;
    public float maxSpeed = 40;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        if(moveSpeed < maxSpeed){
            moveSpeed += 0.2f * Time.deltaTime;
        }
        transform.Translate(Vector3.forward * Time.deltaTime*moveSpeed,Space.World);
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            if(this.gameObject.transform.position.x > LevelBoundary.leftSide){

                transform.Translate(Vector3.left * Time.deltaTime * leftRigthSpeed);
            }
        }
        
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            if(this.gameObject.transform.position.x < LevelBoundary.rightSide){
               
                transform.Translate(Vector3.right * Time.deltaTime * leftRigthSpeed);
            }
        }
       
        /*if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
            moveSpeed = 15;
        }
        else{
            moveSpeed = 5;
        }*/
    }
}
