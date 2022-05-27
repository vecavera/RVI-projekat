using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public bool isDamaging;
    public float damage = 10;

    private void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            obj.gameObject.SendMessage("TakeDamage", Time.deltaTime * damage);
        }
    }
}
