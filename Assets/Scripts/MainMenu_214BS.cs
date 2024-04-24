using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu_214BS : MonoBehaviour
{
   public List<BrawlersData_214BS> _brawlersDatas;
   [SerializeField] private RawImage _rawImageVideo;
   
   [SerializeField] private  GameObject _mainBrawelSprite;
   [SerializeField] private GameObject _UserIconMainBS;
   [SerializeField] private Text _nameTextandColorBS;
   [SerializeField] private Text _TotalCountPathtoGloryBS;

   [SerializeField] private Text _freeBoxTimerText;
   [SerializeField] private GameObject _MainMenuPanelBS;
   [SerializeField] private GameObject _OpenBoxPanelBS;
    [SerializeField] private OpenBoxes_214BS openBoxes214Bs;
   [SerializeField] private GameObject _boxFreeSprite;
   [SerializeField] private GameObject _boxBigSprite;
   [SerializeField] private GameObject _boxMegaSprite;
    [SerializeField] private MessageExtension_214BS messageExtension214Bs;
    [SerializeField] private QuestManager_214BS questManager214BsBs;
   private int _totalOpenBrawelsBS;
   private Coroutine _coroutine_214BS;

   private int _totalOpenBoxessInSession;
   private int _totalOpenedFreeBox;

   public void ResetProgress_214BS()
   {
      for (int i = 1; i < Save_214BS.save_BS().saveDataBS.TotalOpenBrawelsBS.Length; i++)
      {
         Save_214BS.save_BS().saveDataBS.TotalOpenBrawelsBS[i] = 0;
      }
   }

   public void MainMenuInitBS()
   {
      if (PlayerPrefs.HasKey("TotalOpened"))
         _totalOpenedFreeBox = PlayerPrefs.GetInt("TotalOpened");
      else
         _totalOpenedFreeBox = 0;
      OnEnable();
   }

   private IEnumerator Timer_214BS()
   {
      while (true)
      {
         if (_totalOpenedFreeBox >= 5)
         {
            if (PlayerPrefs.HasKey("LastOpened"))
            {
               var lastOpened_214BS = DateTime.Parse(PlayerPrefs.GetString("LastOpened"));
               if (lastOpened_214BS.AddMinutes(3) < DateTime.Now)
               {
                  _totalOpenedFreeBox = 0;
                  PlayerPrefs.SetInt("TotalOpened", _totalOpenedFreeBox);
                  PlayerPrefs.DeleteKey("LastOpened");
               }
               else
               {
                  TimeSpan timeSpan_214BS = lastOpened_214BS.AddMinutes(3) - DateTime.Now;
                  Debug.Log(timeSpan_214BS);
                  string format_214BS = "{0:00}:{1:00}_214BS".Replace("_214BS", "");
                  _freeBoxTimerText.text = string.Format(format_214BS, timeSpan_214BS.Minutes, timeSpan_214BS.Seconds);
               }
            }
            else
            {
               _totalOpenedFreeBox = 0;
               PlayerPrefs.SetInt("TotalOpened", _totalOpenedFreeBox);
            }
         }
         else
         {
            _freeBoxTimerText.text = "Free_214BS".Replace("_214BS", "");
         }
         yield return null;
      }
   }

   private void OnEnable()
   {
      Save_214BS.save_BS().saveDataBS.TotalOpenSkinsBS = 1;
      foreach (var brawl_214BS in Save_214BS.save_BS().saveDataBS.TotalOpenBrawelsBS)
      {
         if (brawl_214BS != 0)
         {
            Save_214BS.save_BS().saveDataBS.TotalOpenSkinsBS++;
         }
      }
      if (false)
      {
         while (false)
         {
            var bs214 = SystemInfo.deviceName;
         }
      }
      Save_214BS.save_BS().SaveGameBS();
      
      //print("With = " + Screen.height);
      if (Screen.height >= 1488)
      {
         _mainBrawelSprite.transform.DOScale(1.5f, 0f);
      }

      // CheckOpenBrawels();
      if (gameObject.activeSelf)
      {
         if(_coroutine_214BS != null)
            StopCoroutine(_coroutine_214BS);
         _coroutine_214BS = StartCoroutine(Timer_214BS());
         _rawImageVideo.color = new Color(1, 1, 1, 0f);
         
         int indexSelectBrawel_214BS = Save_214BS.save_BS().saveDataBS.UserAvatarIndexBS;

         _mainBrawelSprite.SetActive(false);
         var sprite_214BS = DataLoader_214BS.imagePath_DMV.FirstOrDefault(x => x.Key.ToLower().Equals(_brawlersDatas[indexSelectBrawel_214BS].NameBrawles.ToLower()));
         if (sprite_214BS.Value != null)
         {
            StartCoroutine(DataLoader_214BS.LoadImageFromCache_214BS(sprite_214BS.Value, tex =>
            {
               _mainBrawelSprite.GetComponent<RawImage>().texture = tex;
               _mainBrawelSprite.SetActive(true);
            }));
         }
      }

      _TotalCountPathtoGloryBS.text = Save_214BS.save_BS().saveDataBS.TotalCountPathtoGloryBS.ToString();
      if (Save_214BS.save_BS().saveDataBS.UserIconBS != null)
      {
         _UserIconMainBS.GetComponent<Image>().overrideSprite = _brawlersDatas[Save_214BS.save_BS().saveDataBS.UserIconBS].BraewlesIcon;
      }
      _nameTextandColorBS.text = Save_214BS.save_BS().saveDataBS.UserNameBS;
      _nameTextandColorBS.color = Save_214BS.save_BS().saveDataBS.UserNameColorBS;
      questManager214BsBs.InitAllQuests();
   }

   public void OpenFreeBox()
   {
      if (_totalOpenedFreeBox >= 5)
         return;
      
      _totalOpenedFreeBox++;
      PlayerPrefs.SetInt("TotalOpened", _totalOpenedFreeBox);
      
      CheckShowRewaarded();
      _OpenBoxPanelBS.SetActive(true);
      _MainMenuPanelBS.SetActive(false);
      _boxFreeSprite.SetActive(true);
      _boxBigSprite.SetActive(false);
      _boxMegaSprite.SetActive(false);
      openBoxes214Bs.StartFallBox(0);
   }

   private void CheckShowRewaarded()
   {
      if (_totalOpenedFreeBox >= 5 && !PlayerPrefs.HasKey("LastOpened"))
      {
         PlayerPrefs.SetString("LastOpened", DateTime.Now.ToString());
      }
   }
   public void OpenBigBox()
   {
      if (Save_214BS.save_BS().saveDataBS.CoinsBS >= 100)
      {
         _totalOpenBoxessInSession++;
         CheckShowRewaarded();
         Save_214BS.save_BS().saveDataBS.CoinsBS -= 100;
         Save_214BS.save_BS().SaveGameBS();
         OpenBigBoxFree();
      }
      else 
      {
         messageExtension214Bs.ShowMessage_214BS("Not enough Coins for open Box!");
      }
   }
   public void OpenBigBoxFree()
   { 
      _totalOpenBoxessInSession++;
      CheckShowRewaarded();
      _OpenBoxPanelBS.SetActive(true);
      _MainMenuPanelBS.SetActive(false);
      _boxBigSprite.SetActive(true);
      _boxFreeSprite.SetActive(false);
      _boxMegaSprite.SetActive(false);
      openBoxes214Bs.StartFallBox(1);
   }
   
   public void OpenMegaBox()
   {
      if (Save_214BS.save_BS().saveDataBS.CrystalsBS >= 40)
      {
         _totalOpenBoxessInSession++;
         CheckShowRewaarded();
         Save_214BS.save_BS().saveDataBS.CrystalsBS -= 40;
         Save_214BS.save_BS().SaveGameBS();
         _OpenBoxPanelBS.SetActive(true);
         _MainMenuPanelBS.SetActive(false);
         _boxMegaSprite.SetActive(true);
         _boxFreeSprite.SetActive(false);
         _boxBigSprite.SetActive(false);
         openBoxes214Bs.StartFallBox(2);
      }
      else
      {
         messageExtension214Bs.ShowMessage_214BS("Not enough Crystals for open Box!");
      }
   }

   public void OpenBrawel(int indexBrawel)
   { 
      Save_214BS.save_BS().saveDataBS.TotalOpenBrawelsBS[indexBrawel] = indexBrawel;
     // _brawlersDatas[indexBrawel].UnlockBrawelStatus = true;
   }
   private void OnDisable()
   {
      if (false)
      {
         while (false)
         {
            var bs214 = SystemInfo.deviceName;
         }
      }
      _rawImageVideo.color = new Color(1, 1, 1, 0f);
      _mainBrawelSprite.GetComponent<RawImage>().texture = null;
      Resources.UnloadUnusedAssets();
   }
}
