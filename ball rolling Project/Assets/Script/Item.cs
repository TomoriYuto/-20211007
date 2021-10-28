using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnTriggerEnter(Collider hit)
    {
        //接触対象はPlayerか
        if (hit.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
