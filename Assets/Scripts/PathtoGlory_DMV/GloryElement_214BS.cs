using System;
using System.Collections;
using System.IO;
using Plugins.Scripts.Dropbox;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.IO.IsolatedStorage;

public class GloryElement_214BS : MonoBehaviour
{
    [SerializeField] private GameObject _ClaimImage;
     [SerializeField] private Slider _progressSlider_214BS;
    [SerializeField] private  Button _claimButton;
     [SerializeField] private RawImage image_214BS;
     [SerializeField] private string imageName_214BS;

    private void Awake()
    {
        if (image_214BS != null)
        {
            if (false)
            {
                while (false)
                {
                    var bs214 = SystemInfo.deviceName;
                }
            }
            StartCoroutine(LoadImage_214BS());
        }
    }

    private void OnEnable()
    {
        if (image_214BS != null)
        {
            StartCoroutine(LoadImage_214BS());
        }
    }

    private void OnDisable()
    {
        if (image_214BS != null)
        {
            image_214BS.texture = null;
            Resources.UnloadUnusedAssets();
        }
    }

    private IEnumerator LoadImage_214BS()
    {
        string path_214BS = Application.persistentDataPath + "/Images/Brawler_Models/" + imageName_214BS;
        image_214BS.gameObject.SetActive(false);
        if (File.Exists(path_214BS))
        {
            var bytes_214BS = File.ReadAllBytesAsync(path_214BS);
            yield return bytes_214BS;
            Texture2D tex_214BS = new Texture2D(2, 2);
            tex_214BS.LoadImage(bytes_214BS.Result);
            tex_214BS.Apply();
            image_214BS.texture = tex_214BS;
            image_214BS.gameObject.SetActive(true);
        }
        else
        {
            StartCoroutine(LoadImageFromDB_214BS("/Images/Brawler_Models/" + imageName_214BS, tex_214BS =>
            {
                image_214BS.texture = tex_214BS;
                image_214BS.gameObject.SetActive(true);
            }));
        }
    }
    
    private IEnumerator LoadImageFromDB_214BS(string imageUrl, Action<Texture2D> onLoded)
    {
        UnityWebRequest request_214BS = DropboxHelper.GetRequestForFileDownload(imageUrl);
        yield return request_214BS.SendWebRequest();

        if (request_214BS.result == UnityWebRequest.Result.Success)
        {
            var bytes_214BS = request_214BS.downloadHandler.data;
            if (!Directory.Exists(Path.GetDirectoryName(Application.persistentDataPath + $"/{imageUrl}")))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Application.persistentDataPath + $"/{imageUrl}"));
            }
            File.WriteAllBytesAsync(Application.persistentDataPath + $"/{imageUrl}", bytes_214BS);
            Texture2D texture2D_214BS = new Texture2D(2, 2);
            texture2D_214BS.LoadImage(bytes_214BS);
            texture2D_214BS.Apply();
            Resources.UnloadUnusedAssets();
            onLoded?.Invoke(texture2D_214BS);
        }
        else
        {
            Debug.Log(request_214BS.error);
        }
    }

    public void CheckCollectState(int index)
    {
        _ClaimImage.SetActive(Save_214BS.save_BS().saveDataBS.PathElementClaim[index]);
        
        if (_progressSlider_214BS.value >= _progressSlider_214BS.maxValue && _ClaimImage.activeSelf == false)
        {
            print("PV/PMV = "+_progressSlider_214BS.value  + _progressSlider_214BS.maxValue);
            _claimButton.interactable = true;
        }
        else
        {
            _claimButton.interactable = false;
        }
        
    }
    public void ClaimRevard(int index)
    {
        Save_214BS.save_BS().saveDataBS.PathElementClaim[index] = true;
        Save_214BS.save_BS().SaveGameBS();
        _ClaimImage.SetActive(true);
        _claimButton.interactable = false;
    }
}
