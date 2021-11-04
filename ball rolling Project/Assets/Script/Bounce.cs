//using UnityEngine;

//public class Bounce : MonoBehaviour
//{
//    /// <summary>
//    /// 跳ね返す強さの変数
//    /// </summary>
//    [SerializeField]
//    private float bounce = 10f;

//    /// <summary>
//    /// 衝突した時
//    /// </summary>
//    /// <param name="collision"></param>
//    /// 

//    private void OnCollisionEnter(Collision collision)
//    {
//        // 当たった相手のRigidbodyのx軸方向に力を加える。
//        // 今回はx軸のマイナス方向に力を加えて跳ね返す。
//        collision.rigidbody.AddForce(-bounce, 0f, 0f, ForceMode.Impulse);

//    }
//}
//using UnityEngine;

//// Rigidbodyがアタッチされていない場合はアタッチする
//[RequireComponent(typeof(Rigidbody))]
//public class Bounce : MonoBehaviour
//{
//	[SerializeField]
//	[Tooltip("跳ね返すときの速さ")]
//	private float bounceSpeed = 30.0f;

//	[SerializeField]
//	[Tooltip("跳ね返す単位ベクトルにかける倍数")]
//	private float bounceVectorMultiple = 2f;

//	/// <summary>
//	/// 衝突した時
//	/// </summary>
//	/// <param name="collision"></param>
//	private void OnCollisionEnter(Collision collision)
//	{
//		// 当たった相手に"Player"タグが付いている場合
//		if (collision.gameObject.tag == "Ball")
//		{
//			// 衝突した面の、接触した点における法線ベクトルを取得
//			Vector3 normal = collision.contacts[0].normal;
//			// 衝突した速度ベクトルを単位ベクトルにする
//			Vector3 velocity = collision.rigidbody.velocity.normalized;
//			// x,z方向に対して逆向きの法線ベクトルを取得
//			velocity += new Vector3(-normal.x * bounceVectorMultiple, 0f, -normal.z * bounceVectorMultiple);
//			// 取得した法線ベクトルに跳ね返す速さをかけて、跳ね返す
//			collision.rigidbody.AddForce(velocity * bounceSpeed, ForceMode.Impulse);
//		}
//	}
//}

using UnityEngine;
public class Bounce : MonoBehaviour
{
    public float bounce = 10f;
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ball") {
            other.rigidbody.AddForce(0f, bounce / 6, bounce, ForceMode.Impulse);
        }
    }
}
