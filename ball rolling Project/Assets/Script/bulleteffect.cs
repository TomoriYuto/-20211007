using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulleteffect : MonoBehaviour
{
    public GameObject bullethit;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Instantiate(bullethit, this.transform.position, Quaternion.identity); //パーティクル用ゲームオブジェクト生成
        }
    }
}
