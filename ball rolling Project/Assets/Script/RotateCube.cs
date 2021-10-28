using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    float adRotate = 29f;        //回転の速さ

    float zRotate = 0;      //z座標(上、下)への回転座標
    float xRotate = 0;      //x座標(右、左)への回転座標

    float totalMoveTime = 0f;       //スティック入力時の経過時間
    float totalMoveBackTimeX = 0f, totalMoveBackTimeZ = 0f; //ニュートラル時の経過時間

    float DecelerateXP = 0f;    //X+ 方向
    float DecelerateXM = 0f;    //X- 方向
    float DecelerateZP = 0f;    //Z+ 方向
    float DecelerateZM = 0f;    //Z- 方向

    float DecelerateHozon = 0f;
    int count = 0;      //未使用
    int f = 0;

    // Use this for initialization
    void Start()
    {
        Application.targetFrameRate = 60;
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
                totalMoveTime = Mathf.Clamp(totalMoveTime += Time.deltaTime, 0, 1);
            }
            xRotate = Mathf.Clamp(xRotate + (adRotate * Time.deltaTime) * totalMoveTime, -30, 30);
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
            if (xRotate > 0)
            {
                DecelerateXP = totalMoveTime;
                DecelerateHozon = DecelerateXP / 60;
            }
            else
            {
                DecelerateXM = 0;
            }
        }
        //下
        if (0 > xRota && xRota >= -1)
        {
            if (zRota == 0)
            {
                totalMoveTime = Mathf.Clamp(totalMoveTime += Time.deltaTime, 0, 1);
            }
            xRotate = Mathf.Clamp(xRotate - (adRotate * Time.deltaTime) * totalMoveTime, -30, 30);
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
            if (xRotate < 0)
            {
                DecelerateXM = totalMoveTime;
                DecelerateHozon = DecelerateXM / 60;
            }
            else
            {
                DecelerateXP = 0;
            }
        }
        //左
        if (0 < zRota && zRota <= 1)
        {
            if(zRotate != -30)
            {
                f++;
                Debug.Log(f);
            }
            totalMoveTime = Mathf.Clamp(totalMoveTime += Time.deltaTime, 0, 1);
            zRotate = Mathf.Clamp(zRotate - (adRotate * Time.deltaTime) * totalMoveTime, -30, 30);
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
            if (zRotate < 0)
            {
                DecelerateZP = totalMoveTime;
                DecelerateHozon = DecelerateZP / 60;
            }
            else
            {
                DecelerateZM = 0;
            }
        }
        //右
        if (0 > zRota && zRota >= -1)
        {
            totalMoveTime = Mathf.Clamp(totalMoveTime += Time.deltaTime, 0, 1);
            zRotate = Mathf.Clamp(zRotate + (adRotate * Time.deltaTime) * totalMoveTime, -30, 30);
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
            if (zRotate > 0)
            {
                DecelerateZM = totalMoveTime;
                DecelerateHozon = DecelerateZM / 60;
            }
            else
            {
                DecelerateZP = 0;
            }
        }
       
        //ニュートラルの時戻る処理
        if (xRota == 0 && zRota == 0)
        {
            //加速度リセット
            totalMoveTime = 0f;
            //上に戻る
            if (xRotate < 0)
            {
                //下に減速
                if (DecelerateXM > 0 && xRotate != -30)
                {
                    DecelerateXM -= DecelerateHozon;
                    xRotate = Mathf.Clamp(xRotate - ((adRotate * Time.deltaTime) * DecelerateXM), -30, 0);
                    transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
                }
                else
                {
                    DecelerateXM = 0f;
                    //上に加速
                    totalMoveBackTimeX += Time.deltaTime;
                    xRotate = Mathf.Clamp(xRotate + (adRotate * Time.deltaTime) * totalMoveBackTimeX, -30, 0);
                    transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
                }
            }
            //下に戻る
            if (xRotate > 0)
            {
                //上に減速
                if (DecelerateXP > 0 && xRotate != 30)
                {
                    DecelerateXP -= DecelerateHozon;
                    xRotate = Mathf.Clamp(xRotate + ((adRotate * Time.deltaTime) * DecelerateXP), 0, 30);
                    transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
                }
                else
                {
                    DecelerateXP = 0f;
                    //下に加速
                    totalMoveBackTimeX += Time.deltaTime;
                    xRotate = Mathf.Clamp(xRotate - (adRotate * Time.deltaTime) * totalMoveBackTimeX, 0, 30);
                    transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
                }
            }
            //左に戻る
            if (zRotate < 0)
            {
                //右に減速
                if (DecelerateZP > 0 && zRotate != -30)
                {
                    DecelerateZP -= DecelerateHozon;
                    zRotate = Mathf.Clamp(zRotate - ((adRotate * Time.deltaTime) * DecelerateZP), -30, 0);
                    transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
                }
                else
                {
                    DecelerateZP = 0f;
                    //左に加速
                    totalMoveBackTimeZ += Time.deltaTime;
                    zRotate = Mathf.Clamp(zRotate + (adRotate * Time.deltaTime) * totalMoveBackTimeZ, -30, 0);
                    transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
                }
            }
            //右に戻る
            if (zRotate > 0)
            {
                if (DecelerateZM > 0 && zRotate != 30)
                {
                    DecelerateZM -= DecelerateHozon;
                    zRotate = Mathf.Clamp(zRotate + ((adRotate * Time.deltaTime) * DecelerateZM), 0, 30);
                    transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
                }
                else
                {
                    DecelerateZM = 0f;
                    //右に加速
                    totalMoveBackTimeZ += Time.deltaTime;
                    zRotate = Mathf.Clamp(zRotate - (adRotate * Time.deltaTime) * totalMoveBackTimeZ, 0, 30);
                    transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
                }
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