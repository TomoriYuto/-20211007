using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameClearResult : MonoBehaviour
{
    [SerializeField]
    private Text _textCountdown;

    [SerializeField] private GameObject Panel2;
    [SerializeField] private GameObject Result;

    public Text countText;
    public Text countResult;
    public Text ResultTime;

    private int count; // アイテムの取得数を格納する変数
    private bool inGame;

    private Rigidbody rb;

    private int count2;
    float seconds = 0;
    int minute = 0, seconds2 = 0;
    private float oldSeconds;

    private Text textResult;
    private Text textScore;
    private Text textResultTime;

    void Start()
    {
        Panel2.SetActive(false);
        Result.SetActive(false);

        inGame = true;
        rb = GetComponent<Rigidbody>();
        count = 0; // 初期化
        SetCountText();

        _textCountdown.text = "";
        rb.useGravity = true;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            other.gameObject.SetActive(false);
            count = count + 1; // 衝突判定のイベントが発生した際に count の数を１上げる
            //count2 += 1; 
            SetCountText();
        }
    }
    public void Update()
    {
        if (count >= 12)
        {
            if (Input.GetKeyDown("joystick button 0"))
            {
                Result.SetActive(false);
                Panel2.SetActive(true);
            }
            if (count == 12)
            {
                StartCoroutine(CountdownCoroutine());
                count += 1;
            }
        }
        else
        {
            seconds += Time.deltaTime;
            if (seconds >= 60f)
            {
                minute++;
                seconds = seconds - 60;
            }
            if ((int)seconds != (int)oldSeconds)
            {

                ResultTime.text = "掛かった時間　" + minute.ToString("00") + ":" + ((int)seconds).ToString("00");

            }
            oldSeconds = seconds;

        }
    }
    void SetCountText()
    {
        countText.text = count.ToString() + " / 12";
        countResult.text = string.Format("取得したコイン　{00}枚", count);
        //ResultTime.text = string.Format("かかった時間　{0}：{00}", minute, second);

        if (count >= 12)
        {
            inGame = false;
            rb.constraints = RigidbodyConstraints.FreezeAll;
            GameObject.Find("Cube").GetComponent<PouseMenu>().enabled = false;
            GameObject.Find("Cube/GameObject/cannon").GetComponent<Enemy>().enabled = false;
        }
    }
    IEnumerator CountdownCoroutine()
    {
        GameObject.Find("Cube").GetComponent<RotateCube>().enabled = false;
        _textCountdown.gameObject.SetActive(true);

        _textCountdown.text = "ゲームクリア";
        yield return new WaitForSeconds(1.0f);

        Result.SetActive(true);

        _textCountdown.text = "";
        _textCountdown.gameObject.SetActive(false);
    }
}