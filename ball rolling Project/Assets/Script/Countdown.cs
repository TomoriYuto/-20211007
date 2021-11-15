using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Countdown : MonoBehaviour
{
	[SerializeField]
	private Text _textCountdown;

	[SerializeField]
	private Image _imageMask;

	int count;

	void Start()
	{
		count = 0;
		_textCountdown.text = "";

	}

	public void Update()
	{
		if (count == 0) {
			StartCoroutine(CountdownCoroutine());
			GetComponent<RotateCube>().enabled = false;
			GetComponent<PouseMenu>().enabled = false;
			count += 1;
		}
	}

	IEnumerator CountdownCoroutine()
	{
		_imageMask.gameObject.SetActive(true);
		_textCountdown.gameObject.SetActive(true);

		_textCountdown.text = "3";
		yield return new WaitForSeconds(1.0f);

		_textCountdown.text = "2";
		yield return new WaitForSeconds(1.0f);

		_textCountdown.text = "1";
		yield return new WaitForSeconds(1.0f);

		_textCountdown.text = "スタート!";
		yield return new WaitForSeconds(0.5f);

		_textCountdown.text = "";
		_textCountdown.gameObject.SetActive(false);
		_imageMask.gameObject.SetActive(false);
		GetComponent<RotateCube>().enabled = true;
		GetComponent<PouseMenu>().enabled = true;
	}
}