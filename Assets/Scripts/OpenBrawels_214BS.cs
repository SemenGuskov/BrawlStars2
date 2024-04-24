using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class OpenBrawels_214BS : MonoBehaviour
{
    [SerializeField] private GameObject PathToGloryPanel;
    [SerializeField] private GameObject OpenBrawelPanel;
    [SerializeField] private GameObject BrawwelImage;


    public void OpenBrawel(string imageName)
    {
        PathToGloryPanel.SetActive(false);
        OpenBrawelPanel.SetActive(true);
        BrawwelImage.SetActive(true);
        string path_214BS = Application.persistentDataPath + "/Images/Brawler_Models/" + imageName;
        if (File.Exists(path_214BS))
        {
            var bytes_214BS = File.ReadAllBytes(path_214BS);
            Texture2D tex_214BS = new Texture2D(2, 2);
            tex_214BS.LoadImage(bytes_214BS);
            tex_214BS.Apply();
            BrawwelImage.GetComponent<RawImage>().texture = tex_214BS;
        }
        Save_214BS.save_BS().saveDataBS.BrawelIndicatorValue++;
    }
}
