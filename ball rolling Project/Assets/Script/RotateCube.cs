//Ax = Tx.localEulerAngles.x; //W,S
//Az = Tz.localEulerAngles.z; //A,D

//Transform Tx, Tz;
//float Ax, Az;
//Tx = GetComponent<Transform>();
//Tz = GetComponent<Transform>();using UnityEngine;

using UnityEngine;

public class RotateCube : MonoBehaviour
{
    [SerializeField]
    private GameObject aCube;
    [SerializeField]
    private GameObject bCube;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            aCube.transform.localRotation *= Quaternion.Euler(0, 30, 0); //45度回転!
        }

        if (Input.GetMouseButtonDown(1))
        {
            var aPos = aCube.transform.localPosition;
            var bPos = bCube.transform.localPosition;
            aCube.transform.localPosition = bPos;
            bCube.transform.localPosition = aPos;
        }
    }
}
