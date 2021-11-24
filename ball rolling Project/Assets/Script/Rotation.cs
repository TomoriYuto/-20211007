using UnityEngine;
using System.Collections;
public class Rotation : MonoBehaviour
{

    float maxAngle = 60; // 最大回転角度
    float minAngle = -60; // 最小回転角度
    float speed = 0.5f; // 回転スピード(お好みで調整してください)
    void Start()
    {
    }

    void Update()
    {
        // 入力情報
        float turn = Input.GetAxis("Horizontal");
        // 現在の回転角度を0～360から-180～180に変換
        float rotateY = (transform.eulerAngles.y > 180) ? transform.eulerAngles.y - 360 : transform.eulerAngles.y;
        // 現在の回転角度に入力(turn)を加味した回転角度をMathf.Clamp()を使いminAngleからMaxAngle内に収まるようにする
        float angleY = Mathf.Clamp(rotateY + turn * speed, minAngle, maxAngle);
        // 回転角度を-180～180から0～360に変換
        angleY = (angleY < 0) ? angleY + 360 : angleY;
        // 回転角度をオブジェクトに適用
        transform.rotation = Quaternion.Euler(0, angleY, 0);
    }
}
