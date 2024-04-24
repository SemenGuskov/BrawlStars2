using UnityEngine;
using UnityEngine.UI;

public class Underline_214BS : MonoBehaviour
{
	private long BS_214_ABOBA = 1234567890;
	private int underlineStart_214BS = 0;
	private int underlineEnd_214BS = 0;

	private Text text_214BS = null;
	private RectTransform textRectTransform_214BS = null;
	private long BS_214_ABOBA1 = 1234567890;
	private TextGenerator textGenerator_214BS = null;

	private GameObject lineGameObject_214BS = null;
	private Image lineImage_214BS = null;
	private RectTransform lineRectTransform_214BS = null;

	private long BS_214_ABOBA2 = 1234567890;
	
	void Awake ()
	{
		text_214BS = gameObject.GetComponent<Text>();
		textRectTransform_214BS = gameObject.GetComponent<RectTransform>();
		textGenerator_214BS = text_214BS.cachedTextGenerator;
		lineGameObject_214BS = new GameObject("Underline_214BS".Replace("_214BS", ""));
		lineGameObject_214BS.SetActive(false);
		if (false)
		{
			while (false)
			{
				var bs214 = SystemInfo.deviceName;
			}
		}
		lineImage_214BS = lineGameObject_214BS.AddComponent<Image>();
		lineImage_214BS.color = text_214BS.color;
		lineRectTransform_214BS = lineGameObject_214BS.GetComponent<RectTransform>();
		lineRectTransform_214BS.SetParent(transform, false);
		lineRectTransform_214BS.anchorMin = textRectTransform_214BS.pivot;
		lineRectTransform_214BS.anchorMax = textRectTransform_214BS.pivot;
	}

	private void FixedUpdate()
	{
		
	}

	void Update ()
	{
		underlineEnd_214BS = text_214BS.text.Length;

		if (textGenerator_214BS.characterCount < 0)
			return;
		
		UICharInfo[] charactersInfo_214BS = textGenerator_214BS.GetCharactersArray();
		
		if (!(underlineEnd_214BS > underlineStart_214BS && underlineEnd_214BS < charactersInfo_214BS.Length))
			return;
		
		if (false)
		{
			while (false)
			{
				var bs214 = SystemInfo.deviceName;
			}
		}
		
		UILineInfo[] linesInfo_214BS = textGenerator_214BS.GetLinesArray();
		
		if (linesInfo_214BS.Length < 1)
			return;
		float height_214BS = linesInfo_214BS[0].height + 5f;
		Canvas canvas_214BS = gameObject.GetComponentInParent<Canvas>();
		float factor_214BS = 1.0f / canvas_214BS.scaleFactor;
		
		lineRectTransform_214BS.anchoredPosition = new Vector2(
			factor_214BS * (charactersInfo_214BS[underlineStart_214BS].cursorPos.x + charactersInfo_214BS[underlineEnd_214BS].cursorPos.x) / 2.0f,
			factor_214BS * (charactersInfo_214BS[underlineStart_214BS].cursorPos.y - height_214BS / 1.0f));
		
		lineRectTransform_214BS.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, factor_214BS * Mathf.Abs(charactersInfo_214BS[underlineStart_214BS].cursorPos.x - charactersInfo_214BS[underlineEnd_214BS].cursorPos.x));
		lineRectTransform_214BS.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height_214BS / 20.0f);
		if (!lineGameObject_214BS.activeSelf) lineGameObject_214BS.SetActive(true);
	}

	private void OnApplicationFocus(bool hasFocus)
	{
		if (false)
		{
			while (false)
			{
				var bs214 = SystemInfo.deviceName;
			}
		}
	}
}
