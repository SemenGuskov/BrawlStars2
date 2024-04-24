using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using IOSBridge;
using Newtonsoft.Json;
using Plugins.Scripts.Dropbox;
using UnityEngine;
using UnityEngine.Networking;

public class DataLoader_214BS : MonoBehaviour
{
     [SerializeField] private string JsonName_214BS;
     [SerializeField] private List<BrawlersData_214BS> _brawlers_214BS;

    private bool _initialized_214BS = true;

    public static event Action OnLoaded_214BS;
    public static Dictionary<string, string> _descriptions_214BS = new Dictionary<string,string>();
    public static Dictionary<string, string> imagePath_DMV = new Dictionary<string, string>();
    public List<BrawlData> _brawnDataList_214BS { get; set; }

    [Serializable]
    public class BrawlData
    {
        private long BS_214_Aboba = 1234567890;
        [JsonProperty("31i901f2")] public string imageUrl { get; set; }
        [JsonProperty("56yuti")] public string characterName { get; set; }
        private long BS_214_Aboba1 = 1234567890;
        [JsonProperty("31i901_f21")] public string description { get; set; }
        private long BS_214_Aboba2 = 1234567890;
    }

    private void Awake()
    {
        _brawnDataList_214BS = new List<BrawlData>();
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        StartWorking_214BS();
    }

    private void StartWorking_214BS()
    {
        StartCoroutine(DownloadJson_214BS(JsonName_214BS, () =>
        { 
            _brawnDataList_214BS.ToList().ForEach(brawlData =>
            {
                var Braw_214BS = _brawlers_214BS.FirstOrDefault(brawl => brawlData.characterName.ToLower().Equals(brawl.NameBrawles.ToLower()));
                if (Braw_214BS == null)
                    return;
                if(!_descriptions_214BS.ContainsKey(Braw_214BS.NameBrawles))
                    _descriptions_214BS.Add(Braw_214BS.NameBrawles, brawlData.description);
                if(!imagePath_DMV.ContainsKey(Braw_214BS.NameBrawles))
                    imagePath_DMV.Add(Braw_214BS.NameBrawles, brawlData.imageUrl);
                if (!File.Exists(Application.persistentDataPath + $"/{brawlData.imageUrl}"))
                {
                    StartCoroutine(LoadImageFromDB_214BS(brawlData.imageUrl, null));
                }
            });

            if (_brawnDataList_214BS.Count > 0)
                OnLoaded_214BS?.Invoke();
        }));
    }

    private IEnumerator LoadImageFromDB_214BS(string imageUrl, Action<Texture2D> onLoaded)
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
            yield return File.WriteAllBytesAsync(Application.persistentDataPath + $"/{imageUrl}", bytes_214BS);

            if (onLoaded != null)
            {
                Texture2D texture2D_214BS = new Texture2D(2, 2);
                texture2D_214BS.LoadImage(bytes_214BS);
                texture2D_214BS.Apply();
                Resources.UnloadUnusedAssets();
                onLoaded?.Invoke(texture2D_214BS);
            }
        }
        else
        {
            Debug.Log(request_214BS.error);
        }
    }

    public static IEnumerator LoadImageFromCache_214BS(string imageUrl, Action<Texture2D> onLoaded)
    {
        if (File.Exists(Application.persistentDataPath + "/" + imageUrl))
        {
            var bytes_214BS = File.ReadAllBytesAsync(Application.persistentDataPath + $"/{imageUrl}");
            yield return bytes_214BS;
            Texture2D texture2D_214BS = new Texture2D(2, 2);
            texture2D_214BS.LoadImage(bytes_214BS.Result);
            texture2D_214BS.Apply();
            Resources.UnloadUnusedAssets();
            onLoaded?.Invoke(texture2D_214BS);
        }
    }

    private IEnumerator DownloadJson_214BS(string jsonOnServer, Action onLoaded)
    {
        var task_214BS = DropboxHelper.Initialize();
        yield return new WaitUntil(() => task_214BS.IsCompleted);

        if (!Directory.Exists(Path.GetDirectoryName(Application.persistentDataPath + "/json_BS").Replace("_BS", "")))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(Application.persistentDataPath + "/json_BS").Replace("_BS", ""));
        }

        string savePath_214BS = Application.persistentDataPath + "/json_BS".Replace("_BS", "");
        string jsData_214BS = null;
        
        UnityWebRequest json_214BS = DropboxHelper.GetRequestForFileDownload(jsonOnServer);
        yield return json_214BS.SendWebRequest();

        Debug.Log(json_214BS.ToString());

        if (json_214BS.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(json_214BS.error);
            string objNameCvDm_CV_256 = this.gameObject.name;
            string methName_214BS = "StartWorking()";
            IOStoUnityBridge.ShowAlertWithCallBack("Error_214BS".Replace("_214BS", ""), "Please, try again._214BS".Replace("_214BS", ""), objNameCvDm_CV_256,
                methName_214BS);
        }
        else
        {
            yield return File.WriteAllTextAsync(savePath_214BS, json_214BS.downloadHandler.text);
            var readAllTextAsync_214BS = File.ReadAllTextAsync(savePath_214BS);
            yield return readAllTextAsync_214BS;
            jsData_214BS = readAllTextAsync_214BS.Result;
        }
        
        try
        {
            _brawnDataList_214BS = JsonConvert.DeserializeObject<List<BrawlData>>(jsData_214BS);
        }
        catch(Exception e)
        {
            Debug.Log(e.Message);
        }

        onLoaded?.Invoke();
    }
}
