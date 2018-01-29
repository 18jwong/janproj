using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class TextFadeAway : MonoBehaviour {

    public TextMeshProUGUI text;
	public float time = 8f;
	public bool fadeIn = true;

    // Assigns this script's text to 'text'
    void Awake () {
        text = GetComponent<TextMeshProUGUI>();
		if (fadeIn == true) {
			StartCoroutine (FadeTextToZeroAlpha (time, text));
		} else if (fadeIn == false) {
			StartCoroutine (FadeTextToFullAlpha (time, text));
			StartCoroutine (FadeTextToZeroAlpha (time, text));
		}
	}

    public IEnumerator FadeTextToFullAlpha(float t, TextMeshProUGUI i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
    }

    public IEnumerator FadeTextToZeroAlpha(float t, TextMeshProUGUI i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while(i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }
}
