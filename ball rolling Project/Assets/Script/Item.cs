<<<<<<< HEAD
﻿using System.Collections;
=======
﻿
using System.Collections;
>>>>>>> tomori_yuto
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnTriggerEnter(Collider hit)
    {
        //接触対象はPlayerか
<<<<<<< HEAD
        if (hit.CompareTag("Player"))
=======
        if (hit.CompareTag("Ball"))
>>>>>>> tomori_yuto
        {
            Destroy(gameObject);
        }
    }
}
