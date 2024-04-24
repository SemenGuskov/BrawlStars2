using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using System.IO.IsolatedStorage;

public class OpenBoxes_214BS : MonoBehaviour
{
    [SerializeField] private List<GameObject> BoxBS;
    [SerializeField] private List<Sprite> SpritePrizeBS;
    
    [SerializeField] private Transform BoxStartPosition;
    [SerializeField] private Transform BoxOpenPoint;
    
    [SerializeField] private GameObject CoinPrizeSprite;
    [SerializeField] private Text CoinsAmountWinBS;
    
     [SerializeField] private AudioManager_214BS audioManager214Bs ;
    
    private int IndexBox;
    private int CoinsPrise;
    
    public static Action<int,int> CollectRevards;
    public void StartFallBox(int index)
    {
        for (int i = 0; i < BoxBS.Count; i++)
        {
            BoxBS[i].SetActive(true);
            BoxBS[i].transform.localPosition = new Vector3(BoxStartPosition.localPosition.x, BoxStartPosition.localPosition.y,BoxStartPosition.localPosition.z);
        }

        IndexBox = index;
        audioManager214Bs.SoundEffect(0);
        BoxBS[index].SetActive(true);
        BoxBS[index].transform.DOMove(BoxOpenPoint.transform.position, 0.7f).SetEase(Ease.OutBounce);
    }
    
    public void OpenBoxFreeBS()
    {
        BoxBS[0].SetActive(false);
        CoinsPrise = Random.Range(10,30);
        CoinPrizeSprite.SetActive(true);
        CoinPrizeSprite.GetComponent<Image>().sprite = SpritePrizeBS[0];
        CoinsAmountWinBS.text = "+_214BS".Replace("_214BS", "") + CoinsPrise;
        Save_214BS.save_BS().saveDataBS.TotalOpenFreeBoxesBS++;
        Save_214BS.save_BS().saveDataBS.TotalCountPathtoGloryBS++;
        GameMoney_214BS.AddCoinsBS(CoinsPrise);
       // _collectPrize.PowerPointPrize(1);
    }
    public void OpenBoxBigBS()
    {
        BoxBS[1].SetActive(false);
        var rand_214BS = Random.Range(0, 100);
        if (rand_214BS <= 50)
        {
            CoinsPrise = Random.Range(90,150);
        }
        else
        {
            CoinsPrise = Random.Range(30, 90);
        }
        CoinPrizeSprite.SetActive(true);
        CoinPrizeSprite.GetComponent<Image>().sprite = SpritePrizeBS[1];
        CoinsAmountWinBS.text = "+_214BS".Replace("_214BS", "") + CoinsPrise;
        Save_214BS.save_BS().saveDataBS.TotalOpenBigBoxesBS++;
        Save_214BS.save_BS().saveDataBS.TotalCountPathtoGloryBS += 2;
        GameMoney_214BS.AddCoinsBS(CoinsPrise);
    }
    public void OpenBoxMegaBS()
    {
        BoxBS[2].SetActive(false);
        CoinsPrise = Random.Range(250,350);
        CoinPrizeSprite.SetActive(true);
        CoinPrizeSprite.GetComponent<Image>().sprite = SpritePrizeBS[2];
        CoinsAmountWinBS.text = "+_214BS".Replace("_214BS", "") + CoinsPrise;
        Save_214BS.save_BS().saveDataBS.TotalOpenMegaBoxesBS++;
        Save_214BS.save_BS().saveDataBS.TotalCountPathtoGloryBS += 5;
        GameMoney_214BS.AddCoinsBS(CoinsPrise);
    }
    
    public void CollectPowerPoint()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        CollectRevards?.Invoke(IndexBox,CoinsPrise);
    }
}
