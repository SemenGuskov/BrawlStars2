using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO.IsolatedStorage;

public class QuestManager_214BS : MonoBehaviour
{
    [SerializeField] private IndicatorsEvents_214BS indicatorsEvents214Bs;
   
   [SerializeField] private List<QuestElement_214BS> _QuestTrophiesElements;
   [SerializeField] private List<QuestElement_214BS> _QuestBigBoxElements;
   [SerializeField] private List<QuestElement_214BS> _QuestMegaBoxElements;
   [SerializeField] private List<QuestElement_214BS> _QuestBrawelsElements;
   [SerializeField] private List<QuestElement_214BS> _QuestGameTimeElements;
   [Header("TROPHIES")]
   [SerializeField] private GameObject CollectTrophiesImage;
   [SerializeField] private GameObject CardQuestTrophies;
   [SerializeField] private Text QuestTrophiesBigBoxText;
   [SerializeField] private Text QuestTrophiesSlider;
   [SerializeField] private Text QuestTrophiesCoin;
   [SerializeField] private Text QuestTrophiesCrystal;
   [Header("BIG_BOX")]  
   [SerializeField] private GameObject CollectBigBoxImage;
   [SerializeField] private GameObject CardQuestBigBox;
   [SerializeField] private Text QuestBigBoxAimText;
   [SerializeField] private Text QuestBigBoxSlider;
   [SerializeField] private Text QuestBigBoxCoin;
   [SerializeField] private Text QuestBigBoxCrystal;
   [Header("MEGA_BOX")]
   [SerializeField] private GameObject CollectMegaBoxImage;
   [SerializeField] private GameObject CardQuestMegaBox;
   [SerializeField] private Text QuestMegaBoxAimText;
   [SerializeField] private Text QuestMegaBoxSlider;
   [SerializeField] private Text QuestMegaBoxCoin;
   [SerializeField] private Text QuestMegaBoxCrystal;
   [Header("BRAWELS")]
   [SerializeField] private GameObject CollectBrawelsImage;
   [SerializeField] private GameObject CardQuestBrawels;
   [SerializeField] private Text QuestBrawelsAimText;
   [SerializeField] private Text QuestBrawelsSlider;
   [SerializeField] private Text QuestBrawelsCoin;
   [SerializeField] private Text QuestBrawelsCrystal;
   [Header("GAME_TIME")]
   [SerializeField] private GameObject CollectGameTimeImage;
   [SerializeField] private GameObject CardQuestGameTime;
   [SerializeField] private Text QuestGameTimeAimText;
   [SerializeField] private Text QuestGameTimeSlider;
   [SerializeField] private Text QuestGameTimeCoin;
   [SerializeField] private Text QuestGameTimeCrystal;

   private int TrophieActiveIndex;
   private int BigBoxActiveIndex;
   private int MegaBoxActiveIndex;
   private int BrawelsActiveIndex;
   private int GameTimeActiveIndex;

   private int countcollectTrophy;
   private int countcollectBigBoxes;
   private int countcollectMegaBoxes;
   private int countcollectBrawels;
   private int countcollectGameTime;
   
   private void OnEnable()
   {
      if (false)
      {
         while (false)
         {
            var bs214 = SystemInfo.deviceName;
         }
      }
      InitAllQuests();
   }

   // public void ResetQuestProgress()
   // {
   //    for (int i = 1; i < _QuestTrophiesElements.Count; i++)
   //    {
   //       _QuestTrophiesElements[i].prizeCollectProcess = false;
   //    }
   //    _QuestTrophiesElements[0].prizeCollectProcess = true;
   // }
   public void InitAllQuests()
   {
      countcollectTrophy = 0;
      countcollectBigBoxes = 0;
      countcollectMegaBoxes = 0;
      countcollectBrawels = 0;
      countcollectGameTime = 0;
      
      for (int i = 0; i < Save_214BS.save_BS().saveDataBS.QuestTrophyElements.Length; i++)    ///_QuestTrophiesElements
      {
         if (Save_214BS.save_BS().saveDataBS.QuestTrophyElements[i])
         {
            InitTrophiesQuest(i);
            TrophieActiveIndex = i;
         }
         else
         {
            countcollectTrophy++;
         }
         if (countcollectTrophy >= _QuestTrophiesElements.Count)
         {
            CardQuestTrophies.SetActive(false);
         }
      }
      for (int i = 0; i < Save_214BS.save_BS().saveDataBS.QuestBigBoxElements.Length; i++)
      {
         if (Save_214BS.save_BS().saveDataBS.QuestBigBoxElements[i])
         {
            InitBigBoxQuest(i);
            BigBoxActiveIndex = i;
         }
         else
         {
            countcollectBigBoxes++;
         }
         if (countcollectBigBoxes >= _QuestBigBoxElements.Count)
         {
            CardQuestBigBox.SetActive(false);
         }
      }
      for (int i = 0; i < Save_214BS.save_BS().saveDataBS.QuestMegaBoxElements.Length; i++)
      {
         if (Save_214BS.save_BS().saveDataBS.QuestMegaBoxElements[i])
         {
            InitMegaBoxQuest(i);
            MegaBoxActiveIndex = i;
         }
         else
         {
            countcollectMegaBoxes++;
         }
         if (countcollectMegaBoxes >= _QuestMegaBoxElements.Count)
         {
            CardQuestMegaBox.SetActive(false);
         }
      }
      for (int i = 0; i < Save_214BS.save_BS().saveDataBS.QuestBrawelsElements.Length; i++)
      {
         if (Save_214BS.save_BS().saveDataBS.QuestBrawelsElements[i])
         {
            InitBrawelsQuest(i);
            BrawelsActiveIndex = i;
         }
         else
         {
            countcollectBrawels++;
         }
         if (countcollectBrawels >= _QuestBrawelsElements.Count)
         {
            CardQuestBrawels.SetActive(false);
         }
      }
      for (int i = 0; i < Save_214BS.save_BS().saveDataBS.QuestGameTimeElements.Length; i++)
      {
         if (Save_214BS.save_BS().saveDataBS.QuestGameTimeElements[i])
         {
            InitGameTimeQuest(i);
            GameTimeActiveIndex = i;
         }
         else
         {
            countcollectGameTime++;
         }
         if (countcollectGameTime >= _QuestGameTimeElements.Count)
         {
            CardQuestGameTime.SetActive(false);
         }
      }
   }
   
   public void InitTrophiesQuest(int indexQuest)
   {
  
      CardQuestTrophies.GetComponentInChildren<Slider>().maxValue = _QuestTrophiesElements[indexQuest].MaxValueSliderBS;
      CardQuestTrophies.GetComponentInChildren<Slider>().value = Save_214BS.save_BS().saveDataBS.TotalCountPathtoGloryBS;
      QuestTrophiesSlider.text = (Save_214BS.save_BS().saveDataBS.TotalCountPathtoGloryBS / CardQuestTrophies.GetComponentInChildren<Slider>().maxValue) * 100 + "%_214BS".Replace("_214BS", "");
     
      if (CardQuestTrophies.GetComponentInChildren<Slider>().value >= CardQuestTrophies.GetComponentInChildren<Slider>().maxValue)
      {
         if (Save_214BS.save_BS().saveDataBS.QuestIndicatorValue == 0)
         {
            Save_214BS.save_BS().saveDataBS.QuestIndicatorValue++;
         }
         CardQuestTrophies.GetComponent<Image>().color = Color.green;
         CardQuestTrophies.GetComponent<Button>().interactable = true;
         QuestTrophiesSlider.text = "100%_214BS".Replace("_214BS", "");
         CollectTrophiesImage.SetActive(true);
      }
      QuestTrophiesBigBoxText.text = "GET IN TOTAL _214BS".Replace("_214BS", "") + _QuestTrophiesElements[indexQuest].MaxValueSliderBS + "\n_214BS".Replace("_214BS", "") + "TROPHIES_214BS".Replace("_214BS", "");
      QuestTrophiesCoin.text = _QuestTrophiesElements[indexQuest].CoinsPrizeBS.ToString();
      QuestTrophiesCrystal.text = _QuestTrophiesElements[indexQuest].CrystalsPrizeBS.ToString();
      indicatorsEvents214Bs.CalculateIndicators(TypeIndicator.QUEST_214BS);
   }
   public void InitBigBoxQuest(int indexQuest)
   {
      CardQuestBigBox.GetComponentInChildren<Slider>().maxValue = _QuestBigBoxElements[indexQuest].MaxValueSliderBS;
      CardQuestBigBox.GetComponentInChildren<Slider>().value = Save_214BS.save_BS().saveDataBS.TotalOpenBigBoxesBS;
      QuestBigBoxSlider.text = (Save_214BS.save_BS().saveDataBS.TotalOpenBigBoxesBS / CardQuestBigBox.GetComponentInChildren<Slider>().maxValue) * 100 + "%_214BS".Replace("_214BS", "");
      
      if (CardQuestBigBox.GetComponentInChildren<Slider>().value >= CardQuestBigBox.GetComponentInChildren<Slider>().maxValue)
      {
         if (Save_214BS.save_BS().saveDataBS.QuestIndicatorValue == 0)
         {
            Save_214BS.save_BS().saveDataBS.QuestIndicatorValue++;
         }
         CardQuestBigBox.GetComponent<Image>().color = Color.green;
         CardQuestBigBox.GetComponent<Button>().interactable = true;
         QuestBigBoxSlider.text = "100%_214BS".Replace("_214BS", "");
         CollectBigBoxImage.SetActive(true);
      }
      QuestBigBoxAimText.text = "OPEN TOTAL _214BS".Replace("_214BS", "") + _QuestBigBoxElements[indexQuest].MaxValueSliderBS + "\n_214BS".Replace("_214BS", "") + "BIG BOXES_214BS".Replace("_214BS", "");
      QuestBigBoxCoin.text = _QuestBigBoxElements[indexQuest].CoinsPrizeBS.ToString();
      QuestBigBoxCrystal.text = _QuestBigBoxElements[indexQuest].CrystalsPrizeBS.ToString();
      indicatorsEvents214Bs.CalculateIndicators(TypeIndicator.QUEST_214BS);
   }
   public void InitMegaBoxQuest(int indexQuest)
   {
      CardQuestMegaBox.GetComponentInChildren<Slider>().maxValue = _QuestMegaBoxElements[indexQuest].MaxValueSliderBS;
      CardQuestMegaBox.GetComponentInChildren<Slider>().value = Save_214BS.save_BS().saveDataBS.TotalOpenMegaBoxesBS;
      QuestMegaBoxAimText.text = "OPEN TOTAL _214BS".Replace("_214BS", "") + _QuestMegaBoxElements[indexQuest].MaxValueSliderBS + "\n_214BS".Replace("_214BS", "") + "MEGA BOXES_214BS".Replace("_214BS", "");
      QuestMegaBoxSlider.text = (Save_214BS.save_BS().saveDataBS.TotalOpenMegaBoxesBS / CardQuestMegaBox.GetComponentInChildren<Slider>().maxValue) * 100 + "%_214BS".Replace("_214BS", "");
      if (CardQuestMegaBox.GetComponentInChildren<Slider>().value >= CardQuestMegaBox.GetComponentInChildren<Slider>().maxValue)
      {
         if (Save_214BS.save_BS().saveDataBS.QuestIndicatorValue == 0)
         {
            Save_214BS.save_BS().saveDataBS.QuestIndicatorValue++;
         }
         CardQuestMegaBox.GetComponent<Image>().color = Color.green;
         CardQuestMegaBox.GetComponent<Button>().interactable = true;
         QuestMegaBoxSlider.text = "100%_214BS".Replace("_214BS", "");
         CollectMegaBoxImage.SetActive(true);
      }

      QuestMegaBoxCoin.text = _QuestMegaBoxElements[indexQuest].CoinsPrizeBS.ToString();
      QuestMegaBoxCrystal.text = _QuestMegaBoxElements[indexQuest].CrystalsPrizeBS.ToString();
      indicatorsEvents214Bs.CalculateIndicators(TypeIndicator.QUEST_214BS);
   }
   public void InitBrawelsQuest(int indexQuest)
   {
      CardQuestBrawels.GetComponentInChildren<Slider>().maxValue = _QuestBrawelsElements[indexQuest].MaxValueSliderBS;
      CardQuestBrawels.GetComponentInChildren<Slider>().value = Save_214BS.save_BS().saveDataBS.TotalOpenBrawelsBS[indexQuest];
      QuestBrawelsAimText.text = "GET IN TOTAL _214BS".Replace("_214BS", "") + _QuestBrawelsElements[indexQuest].MaxValueSliderBS + "\n_214BS".Replace("_214BS", "") + "BRAWELS_214BS".Replace("_214BS", "");
      QuestBrawelsSlider.text = (Save_214BS.save_BS().saveDataBS.TotalOpenBrawelsBS[indexQuest] / CardQuestBrawels.GetComponentInChildren<Slider>().maxValue) * 100 + "%_214BS".Replace("_214BS", "");
      if (CardQuestBrawels.GetComponentInChildren<Slider>().value >= CardQuestBrawels.GetComponentInChildren<Slider>().maxValue)
      {
         if (Save_214BS.save_BS().saveDataBS.QuestIndicatorValue == 0)
         {
            Save_214BS.save_BS().saveDataBS.QuestIndicatorValue++;
         }
         CardQuestBrawels.GetComponent<Image>().color = Color.green;
         CardQuestBrawels.GetComponent<Button>().interactable = true;
         QuestBrawelsSlider.text = "100%_214BS".Replace("_214BS", "");
         CollectBrawelsImage.SetActive(true);
      }

      QuestBrawelsCoin.text = _QuestBrawelsElements[indexQuest].CoinsPrizeBS.ToString();
      QuestBrawelsCrystal.text = _QuestBrawelsElements[indexQuest].CrystalsPrizeBS.ToString();
      indicatorsEvents214Bs.CalculateIndicators(TypeIndicator.QUEST_214BS);
   }
   public void InitGameTimeQuest(int indexQuest)
   {
      CardQuestGameTime.GetComponentInChildren<Slider>().maxValue = _QuestGameTimeElements[indexQuest].MaxValueSliderBS;
      CardQuestGameTime.GetComponentInChildren<Slider>().value = Save_214BS.save_BS().saveDataBS.TotalGameHourBS;
      QuestGameTimeAimText.text = "TOTAL GAME TIME _214BS".Replace("_214BS", "") + _QuestGameTimeElements[indexQuest].MaxValueSliderBS;
      QuestGameTimeSlider.text = (Save_214BS.save_BS().saveDataBS.TotalGameHourBS / CardQuestGameTime.GetComponentInChildren<Slider>().maxValue) * 100 + "%_214BS".Replace("_214BS", "");
      if (CardQuestGameTime.GetComponentInChildren<Slider>().value >= CardQuestGameTime.GetComponentInChildren<Slider>().maxValue)
      {
         if (Save_214BS.save_BS().saveDataBS.QuestIndicatorValue == 0)
         {
            Save_214BS.save_BS().saveDataBS.QuestIndicatorValue++;
         }
         CardQuestGameTime.GetComponent<Image>().color = Color.green;
         CardQuestGameTime.GetComponent<Button>().interactable = true;
         QuestGameTimeSlider.text = "100%_214BS".Replace("_214BS", "");
         CollectGameTimeImage.SetActive(true);
      }

      QuestGameTimeCoin.text = _QuestGameTimeElements[indexQuest].CoinsPrizeBS.ToString();
      QuestGameTimeCrystal.text = _QuestGameTimeElements[indexQuest].CrystalsPrizeBS.ToString();
      indicatorsEvents214Bs.CalculateIndicators(TypeIndicator.QUEST_214BS);
   }
   
   public void CollectTrophiesPrize()
   {
      GameMoney_214BS.AddCoinsBS(_QuestTrophiesElements[TrophieActiveIndex].CoinsPrizeBS);
      GameMoney_214BS.AddCrystallBS( _QuestTrophiesElements[TrophieActiveIndex].CrystalsPrizeBS);
      
      Save_214BS.save_BS().saveDataBS.QuestTrophyElements[TrophieActiveIndex] = false;
      if (Save_214BS.save_BS().saveDataBS.QuestIndicatorValue > 0)
      {
         Save_214BS.save_BS().saveDataBS.QuestIndicatorValue--;
      }
      if (_QuestTrophiesElements.Count-1 > TrophieActiveIndex)
      {
         Save_214BS.save_BS().saveDataBS.QuestTrophyElements[TrophieActiveIndex + 1] = true;
         CardQuestTrophies.GetComponent<Image>().color = new Color(0.19f,0.22f,0.31f,1f);
         CardQuestTrophies.GetComponent<Button>().interactable = false;
         CollectTrophiesImage.SetActive(false);
      }
      else
      {
         CardQuestTrophies.SetActive(false);
      }
      Save_214BS.save_BS().SaveGameBS();
      InitAllQuests();
   }
   public void CollectBigBoxPrize()
   {
      GameMoney_214BS.AddCoinsBS(_QuestBigBoxElements[BigBoxActiveIndex].CoinsPrizeBS);
      GameMoney_214BS.AddCrystallBS( _QuestBigBoxElements[BigBoxActiveIndex].CrystalsPrizeBS);
      
      Save_214BS.save_BS().saveDataBS.QuestBigBoxElements[BigBoxActiveIndex] = false;
      if (Save_214BS.save_BS().saveDataBS.QuestIndicatorValue > 0)
      {
         Save_214BS.save_BS().saveDataBS.QuestIndicatorValue--;
      }
      if (_QuestBigBoxElements.Count-1 > BigBoxActiveIndex)
      {
         Save_214BS.save_BS().saveDataBS.QuestBigBoxElements[BigBoxActiveIndex + 1] = true;
      
         CardQuestBigBox.GetComponent<Image>().color = new Color(0.19f,0.22f,0.31f,1f);
         CardQuestBigBox.GetComponent<Button>().interactable = false;
         CollectBigBoxImage.SetActive(false);
      }
      else
      {
         CardQuestBigBox.SetActive(false);
      }
      Save_214BS.save_BS().SaveGameBS();
      InitAllQuests();
   }
   public void CollectMegaBoxPrize()
   {
      GameMoney_214BS.AddCoinsBS(_QuestMegaBoxElements[MegaBoxActiveIndex].CoinsPrizeBS);
      GameMoney_214BS.AddCrystallBS( _QuestMegaBoxElements[MegaBoxActiveIndex].CrystalsPrizeBS);
      
      Save_214BS.save_BS().saveDataBS.QuestMegaBoxElements[MegaBoxActiveIndex] = false;
      if (Save_214BS.save_BS().saveDataBS.QuestIndicatorValue > 0)
      {
         Save_214BS.save_BS().saveDataBS.QuestIndicatorValue--;
      }
      if (_QuestMegaBoxElements.Count-1 > MegaBoxActiveIndex)
      {
         Save_214BS.save_BS().saveDataBS.QuestMegaBoxElements[MegaBoxActiveIndex + 1] = true;
      
         CardQuestMegaBox.GetComponent<Image>().color = new Color(0.19f,0.22f,0.31f,1f);
         CardQuestMegaBox.GetComponent<Button>().interactable = false;
         CollectMegaBoxImage.SetActive(false);
      }
      else
      {
         CardQuestMegaBox.SetActive(false);
      }
      Save_214BS.save_BS().SaveGameBS();
      InitAllQuests();
   }
   public void CollectBrawelPrize()
   {
      GameMoney_214BS.AddCoinsBS(_QuestBrawelsElements[BrawelsActiveIndex].CoinsPrizeBS);
      GameMoney_214BS.AddCrystallBS( _QuestBrawelsElements[BrawelsActiveIndex].CrystalsPrizeBS);
         
      Save_214BS.save_BS().saveDataBS.QuestBrawelsElements[BrawelsActiveIndex] = false;
      if (Save_214BS.save_BS().saveDataBS.QuestIndicatorValue > 0)
      {
         Save_214BS.save_BS().saveDataBS.QuestIndicatorValue--;
      }
      if (_QuestBrawelsElements.Count-1 > BrawelsActiveIndex)
      {
         Save_214BS.save_BS().saveDataBS.QuestBrawelsElements[BrawelsActiveIndex + 1] = true;
      
         CardQuestBrawels.GetComponent<Image>().color = new Color(0.19f,0.22f,0.31f,1f);
         CardQuestBrawels.GetComponent<Button>().interactable = false;
         CollectBrawelsImage.SetActive(false);
      }
      else
      {
         CardQuestBrawels.SetActive(false);
      }
      Save_214BS.save_BS().SaveGameBS();
      InitAllQuests();
   }
   public void CollectGameTimePrize()
   {
      GameMoney_214BS.AddCoinsBS(_QuestGameTimeElements[GameTimeActiveIndex].CoinsPrizeBS);
      GameMoney_214BS.AddCrystallBS( _QuestGameTimeElements[GameTimeActiveIndex].CrystalsPrizeBS);
      
      Save_214BS.save_BS().saveDataBS.QuestGameTimeElements[GameTimeActiveIndex] = false;
      if (Save_214BS.save_BS().saveDataBS.QuestIndicatorValue > 0)
      {
         Save_214BS.save_BS().saveDataBS.QuestIndicatorValue--;
      }
      if (_QuestGameTimeElements.Count-1 > GameTimeActiveIndex)
      {
         Save_214BS.save_BS().saveDataBS.QuestGameTimeElements[GameTimeActiveIndex + 1] = true;
      
         CardQuestGameTime.GetComponent<Image>().color = new Color(0.19f,0.22f,0.31f,1f);
         CardQuestGameTime.GetComponent<Button>().interactable = false;
         CollectGameTimeImage.SetActive(false);
      }
      else
      {
         CardQuestGameTime.SetActive(false);
      }
      Save_214BS.save_BS().SaveGameBS();
      InitAllQuests();
   }
}
