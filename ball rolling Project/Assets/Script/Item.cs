using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnTriggerEnter(Collider hit)
    {
       // 接触対象はPlayerか
        if (hit.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}

//using UnityEngine;
//using System.Collections;
//using System.Collections.Generic;

//public class Item : MonoBehaviour
//{

//    void OnCollisionEnter(Collision other)
//    {
//        if (other.gameObject.tag == "Ball")
//        {
//            Destroy(gameObject, 0.2f);
//        }
//    }
//}
