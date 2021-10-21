using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKey : MonoBehaviour
{
    public float adRotate = 100;        //回転の速さ
    float zRotate = 0;      //z座標(上、下)への回転座標
    float xRotate = 0;      //x座標(右、左)への回転座標
    float totalMoveTime = 0f;       //スティック入力時の経過時間
    float totalMoveBackTimeX = 0f, totalMoveBackTimeZ = 0f; //ニュートラル時の経過時間
    float Decelerate = 0f;      //減速させるためのtotalMoveTimeの保存先
    float DecelerateHozon = 0f;
    int count = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float zRota = Input.GetAxis("Horizontal");
        float xRota = Input.GetAxis("Vertical");

        //上
        if (0 < xRota && xRota <= 1)
        {
            if (zRota == 0)
            {
                totalMoveTime = Mathf.Clamp(totalMoveTime += Time.deltaTime, 0, 2);
            }
            xRotate = Mathf.Clamp(xRotate + (adRotate * Time.deltaTime) * totalMoveTime, -30, 30);
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
            if (xRotate < 0)
            {

            }
        }
        //下
        if (0 > xRota && xRota >= -1)
        {
            if (zRota == 0)
            {
                totalMoveTime = Mathf.Clamp(totalMoveTime += Time.deltaTime, 0, 2);
            }
            xRotate = Mathf.Clamp(xRotate - (adRotate * Time.deltaTime) * totalMoveTime, -30, 30);
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
        }
        //左
        if (0 < zRota && zRota <= 1)
        {
            totalMoveTime = Mathf.Clamp(totalMoveTime += Time.deltaTime, 0, 2);
            zRotate = Mathf.Clamp(zRotate - (adRotate * Time.deltaTime) * totalMoveTime, -30, 30);
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
        }
        //右
        if (0 > zRota && zRota >= -1)
        {
            totalMoveTime = Mathf.Clamp(totalMoveTime += Time.deltaTime, 0, 2);
            zRotate = Mathf.Clamp(zRotate + (adRotate * Time.deltaTime) * totalMoveTime, -30, 30);
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
        }

        //加速度リセット
        if (xRota == 0 && zRota == 0)
        {
            Decelerate = totalMoveTime;
            totalMoveTime = 0f;
        }

        //ニュートラルの時戻る処理
        if (xRota == 0 && zRota == 0)
        {
            if (xRotate < 0)
            {
                //if (Decelerate != 0 && count <= 60)
                //{
                //    if (count == 0)
                //    {
                //        DecelerateHozon = ((adRotate * Time.deltaTime) * Decelerate) / 60;
                //    }
                //    xRotate = Mathf.Clamp(xRotate - ((DecelerateHozon * Time.deltaTime) * Decelerate), -30, 0);
                //    transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
                //    count++;
                //}
                //else if (count >= 60)
                //{
                totalMoveBackTimeX += Time.deltaTime;
                xRotate = Mathf.Clamp(xRotate + (adRotate * Time.deltaTime) * totalMoveBackTimeX, -30, 0);
                transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
                //}
            }
            else if (xRotate > 0)
            {
                totalMoveBackTimeX += Time.deltaTime;
                xRotate = Mathf.Clamp(xRotate - (adRotate * Time.deltaTime) * totalMoveBackTimeX, 0, 30);
                transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
            }
            if (zRotate < 0)
            {
                totalMoveBackTimeZ += Time.deltaTime;
                zRotate = Mathf.Clamp(zRotate + (adRotate * Time.deltaTime) * totalMoveBackTimeZ, -30, 0);
                transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
            }
            else if (zRotate > 0)
            {
                totalMoveBackTimeZ += Time.deltaTime;
                zRotate = Mathf.Clamp(zRotate - (adRotate * Time.deltaTime) * totalMoveBackTimeZ, 0, 30);
                transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
            }
        }
        //加速度リセット
        if (xRota != 0)
        {
            totalMoveBackTimeX = 0f;
        }
        if (zRota != 0)
        {
            totalMoveBackTimeZ = 0f;
        }
    }
}