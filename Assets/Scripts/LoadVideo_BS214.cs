using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using System.Net.Security;

public class LoadVideo_BS214 : MonoBehaviour
{
    private string bs214;
    [SerializeField] private UnityEngine.Video.VideoClip _iphoneClip_BS214; 
    private string bs214_1;
    [SerializeField] private RenderTexture _iphoneTexture_BS214;
    
    [Space (10)]
    [SerializeField] private UnityEngine.Video.VideoClip _ipadClip_BS214; 
    private string bs214_2;
    [SerializeField] private RenderTexture _ipadTexture_BS214;
    
    private UnityEngine.Video.VideoPlayer _videoPlyer_BS214;
    private RawImage _videoScreen_BS214;

    private void Awake()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        _videoPlyer_BS214 = GetComponent<UnityEngine.Video.VideoPlayer>();
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        _videoScreen_BS214 = GetComponent<RawImage>();

        int value_BS214 = GetDeviceId_BS214();

        if (_iphoneClip_BS214 != null && _ipadClip_BS214 != null)
        {
            if (value_BS214 == 1)
            {
                _videoScreen_BS214.texture = _iphoneTexture_BS214;
                if (false)
                {
                    while (false)
                    {
                        var bs214 = SystemInfo.deviceName;
                    }
                }
                _videoPlyer_BS214.targetTexture = _iphoneTexture_BS214;
                _videoPlyer_BS214.clip = _iphoneClip_BS214;
            }
            else 
            {
                _videoScreen_BS214.texture = _ipadTexture_BS214;
                _videoPlyer_BS214.targetTexture = _ipadTexture_BS214;
                _videoPlyer_BS214.clip = _ipadClip_BS214;
            }
        }
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
        if (hasFocus)
        {
            if (false)
            {
                while (false)
                {
                    var bs214 = SystemInfo.deviceName;
                }
            }
            _videoPlyer_BS214.Play();
        }
        else
        {
            _videoPlyer_BS214.Pause();
        }
    }

    public int GetDeviceId_BS214()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        float width_BS214 = Camera.main.pixelWidth;
        float height_BS214 = Camera.main.pixelHeight;
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        var val_BS214 = width_BS214 > height_BS214 ? width_BS214 / height_BS214 : height_BS214 / width_BS214;

        #if UNITY_EDITOR
        if (val_BS214 > 1.3f && val_BS214 < 1.4f)
            return 0;
        else
            return 1;
        #else
        if (SystemInfo.deviceName.Contains("iPhone_BS214".Replace("_BS214", "")))
            return 1;
        return 0;
        #endif
    }
}
