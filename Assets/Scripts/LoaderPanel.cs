using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
using TMPro;

public class LoaderPanel : MonoBehaviour
{
    [SerializeField] private GameObject _pathtoGlory;
    [SerializeField] protected float _loadSpeedBS;
    [SerializeField] private Image _frontImageSlider;
    [SerializeField] private TextMeshProUGUI _downloadPercentageText;
    [SerializeField] private MessageExtension_214BS _messageExtension214Bs;

    private void Update()
    {
        LaunchSlider();
    }
    private async void LaunchSlider()
    {
        while (_frontImageSlider.fillAmount < 1 && gameObject.activeSelf)
        {
            _frontImageSlider.fillAmount += 0.01f;
            _downloadPercentageText.text = $"{Mathf.Round(_frontImageSlider.fillAmount * 100)}%";
            await Task.Delay(1000);
            if (_frontImageSlider.fillAmount >= 1)
            {
                if (Application.internetReachability == NetworkReachability.NotReachable)
                {
                    _messageExtension214Bs.ShowMessage_214BS("Error Not internet connection!  Please check internet connection for continue_214BS".Replace("_214BS", ""));
                }
                else
                {
                    gameObject.SetActive(false);
                    _downloadPercentageText.text = $"{0}%";
                    _frontImageSlider.fillAmount = 0f;
                    break;
                }

            }
        }
    }
}
