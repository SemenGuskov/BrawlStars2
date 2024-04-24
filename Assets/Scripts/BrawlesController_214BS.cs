using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class BrawlesController_214BS : MonoBehaviour
{
 // [SerializeField] private List<BrawlersData> _brawlersData;
  private BrawlersData_214BS _data214Bs;
  [SerializeField] private int _brawleIndex;
  [SerializeField] private RawImage BraewlesSkin;
  [SerializeField] private int BraewlesSkinIndexSelected;
  [SerializeField] private Text NameBrawles;
  [SerializeField] private Text TypeBrawles;
  [SerializeField] private Text DropType;
  [SerializeField] private Text LevelBrawles;
  [SerializeField] private int LevelBrawlesValue;
  [SerializeField] private List<GameObject> Offense;
   [SerializeField] private List<GameObject>  Defense_214BS;
  [SerializeField] private List<GameObject>  Untility;
  [SerializeField] private Text HeroDescription;
  
   [SerializeField] private Button SelectButton_214BS;
  [SerializeField] private Slider SliderLevelUp;
  [SerializeField] private Text MaxSliderLevelUp;
  [SerializeField] private Text PresentSliderLevelUp;

  [SerializeField] private Button LevelUP;
  [SerializeField] private Text LevelUpCost;
  private int LevelUpPriseValue;
  
  [SerializeField] private AudioSource AudioBrawel;


    public BrawlersData_214BS BrawlersData214Bs
  {
    get { return _data214Bs; }
    set { _data214Bs = value; }
  }

  public void StartSound()
  {
    int indexClip_214BS = Random.Range(0, BrawlersData214Bs.BrawelsSounds.Count);
    AudioBrawel.clip = BrawlersData214Bs.BrawelsSounds[indexClip_214BS];
    AudioBrawel.Play();
  }

  private void OnDisable()
  {
    BraewlesSkin.texture = null;
    if (false)
    {
      while (false)
      {
        var bs214 = SystemInfo.deviceName;
      }
    }
    Resources.UnloadUnusedAssets();
  }

    public void InitDataBrawel()
  {
    _brawleIndex = _data214Bs.BraewlIndex;
    if (_brawleIndex == Save_214BS.save_BS().saveDataBS.UserAvatarIndexBS)
      SelectButton_214BS.GetComponentInChildren<Text>().text = "SELECTED_214BS".Replace("_214BS", "");
    else
      SelectButton_214BS.GetComponentInChildren<Text>().text = "SELECT_214BS".Replace("_214BS", "");
    //_data.LevelBrawles = SaveBS.save_BS().saveDataBS.LevelBrawelsBS[_data.BraewlIndex];
    //_data.PresentSliderLevelUp = SaveBS.save_BS().saveDataBS.ProgresValueBrawelsBS[_data.BraewlIndex];
    LevelBrawlesValue = Save_214BS.save_BS().saveDataBS.LevelBrawelsBS[_data214Bs.BraewlIndex];//_data.LevelBrawles;
    LevelBrawles.text = Save_214BS.save_BS().saveDataBS.LevelBrawelsBS[_data214Bs.BraewlIndex].ToString();
    
    BraewlesSkinIndexSelected = _data214Bs.BraewlesSkinIndexSelected;

    BraewlesSkin.gameObject.SetActive(false);
    var skin_214BS = DataLoader_214BS.imagePath_DMV.FirstOrDefault(x => x.Key.ToLower().Equals(_data214Bs.NameBrawles.ToLower()));

    if (skin_214BS.Value != null && gameObject.activeSelf)
    {
            StartCoroutine(DataLoader_214BS.LoadImageFromCache_214BS(skin_214BS.Value, tex => BraewlesSkin.texture = tex));
            {
                BraewlesSkin.gameObject.SetActive(true);
            }
    }


    var descr_214BS = DataLoader_214BS._descriptions_214BS.FirstOrDefault(x => x.Key.ToLower().Equals(_data214Bs.NameBrawles.ToLower()));
    HeroDescription.text = descr_214BS.Value;
    
    NameBrawles.text = _data214Bs.NameBrawles;
    TypeBrawles.text = ChooseTypeBrawles(_data214Bs.TypeBrawles);
    DropType.text = ChooseDropType(_data214Bs.DropType);
   
    SetStats(Offense,_data214Bs.Offense);
    SetStats(Defense_214BS,_data214Bs.Defense_214BS);
    SetStats(Untility,_data214Bs.Untility);
    SliderUpInit();
    
    LevelUpPriseValue = LevelPrise(LevelBrawlesValue);
    LevelUpCost.text = LevelUpPriseValue.ToString();

    CheckLevelUP();
    
    Invoke("StartSound",0.5f);
  }

  private string ChooseTypeBrawles(TypeBrawles type)
  {
    string selectType_214BS = "DEFAULT_214BS".Replace("_214BS", "");
    switch (type)
    {
      case global::TypeBrawles.DESTROYER_214BS:
        selectType_214BS = "DESTROYER_214BS".Replace("_214BS", "");
      break;
      case global::TypeBrawles.TANK_214BS:
        selectType_214BS = "TANK_214BS".Replace("_214BS", "");
      break;
      case global::TypeBrawles.SUPPORT_214BS:
        selectType_214BS = "SUPPORT_214BS".Replace("_214BS", "");
        break;
      case global::TypeBrawles.ASSASIN_214BS:
        selectType_214BS = "ASSASIN_214BS".Replace("_214BS", "");
        break;
      case global::TypeBrawles.HYBRID_214BS:
        selectType_214BS = "HYBRID_214BS".Replace("_214BS", "");
        break;
    }
    return selectType_214BS;
  }
  private string ChooseDropType(DropType droptype)
  {
    string selectType = "DEFAULT_214BS".Replace("_214BS", "");
    switch (droptype)
    {
      case global::DropType.INITIAL_BRAWLER_214BS:
        selectType = "INITIAL BRAWLER_214BS".Replace("_214BS", "");
        break;
      case global::DropType.PATH_TO_GLORY_214BS:
        selectType = "PATH TO GLORY_214BS".Replace("_214BS", "");
        break;
      case global::DropType.RARE_214BS:
        selectType = "RARE_214BS".Replace("_214BS", "");
        break;
      case global::DropType.SUPER_RARE_214BS:
        selectType = "SUPER RARE_214BS".Replace("_214BS", "");
        break;
      case global::DropType.EPIC_214BS:
        selectType = "EPIC_214BS".Replace("_214BS", "");
        break;
      case global::DropType.LEGENDARY_214BS:
        selectType = "LEGENDARY_214BS".Replace("_214BS", "");
        break;
      case global::DropType.MYTHICAL_214BS:
        selectType = "MYTHICAL_214BS".Replace("_214BS", "");
        break;
      case global::DropType.CHROMATIC_214BS:
        selectType = "CHROMATIC_214BS".Replace("_214BS", "");
        break;
    }
    return selectType;
  }
  private void SliderUpInit()
  {
    SliderLevelUp.maxValue = PowerPoint(LevelBrawlesValue);
    SliderLevelUp.value = Save_214BS.save_BS().saveDataBS.ProgresValueBrawelsBS[_data214Bs.BraewlIndex];//_data.PresentSliderLevelUp;
    MaxSliderLevelUp.text = "/" + SliderLevelUp.maxValue;
    PresentSliderLevelUp.text = Save_214BS.save_BS().saveDataBS.ProgresValueBrawelsBS[_data214Bs.BraewlIndex].ToString();
  }
  private void SetStats(List<GameObject> _stats, int amount)
  {
    for (int i = 0; i < 5; i++)
    {
      if (i < amount)
      {
        _stats[i].SetActive(true);
      }
      else
      {
        _stats[i].SetActive(false);
      }
    }
  }
  private void CheckLevelUP()
  {
    if (SliderLevelUp.value >= SliderLevelUp.maxValue && Save_214BS.save_BS().saveDataBS.CoinsBS >= LevelUpPriseValue && Save_214BS.save_BS().saveDataBS.LevelBrawelsBS[_data214Bs.BraewlIndex] < 10)
    {
      LevelUP.interactable = true;
      LevelUpCost.color = Color.white;
    }
    else
    {
      LevelUpCost.color = Color.red;
    }

    if (Save_214BS.save_BS().saveDataBS.LevelBrawelsBS[_data214Bs.BraewlIndex] >= 10)
    {
      LevelUpCost.text = "MAX_214BS".Replace("_214BS", "");
    }
  }
  private int  LevelPrise(int level)
  {
    int priseLevel = 0;
    switch (level)
    {
      case 1 :
        priseLevel = 20;
        break;
      case 2 :
        priseLevel = 35;
        break;
      case 3 :
        priseLevel = 75;
        break;
      case 4 :
        priseLevel = 140;
        break;
      case 5 :
        priseLevel = 290;
        break;
      case 6 :
        priseLevel = 480;
        break;
      case 7 :
        priseLevel = 800;
        break;
      case 8 :
        priseLevel = 1250;
        break;
      case 9 :
        priseLevel = 1875;
        break;
      case 10:
        priseLevel = 2500;
        break;
    }
    return priseLevel;
  }
  public static int  PowerPoint(int level)
  {
    int powerpoint = 0;
    switch (level)
    {
      case 1 :
        powerpoint = 20;
        break;
      case 2 :
        powerpoint = 30;
        break;
      case 3 :
        powerpoint = 50;
        break;
      case 4 :
        powerpoint = 80;
        break;
      case 5 :
        powerpoint = 130;
        break;
      case 6 :
        powerpoint = 210;
        break;
      case 7 :
        powerpoint = 340;
        break;
      case 8 :
        powerpoint = 550;
        break;
      case 9 :
        powerpoint = 890;
        break;
      case 10:
        powerpoint = 1500;
        break;
    }
    return powerpoint;
  }

  public void SelectBrawels()
  {
    Save_214BS.save_BS().saveDataBS.UserAvatarIndexBS = _brawleIndex;
    Save_214BS.save_BS().SaveGameBS();
    InitDataBrawel();
  }
  public void ByNextLevel()
  {
    if (SliderLevelUp.value >= SliderLevelUp.maxValue && Save_214BS.save_BS().saveDataBS.CoinsBS >= LevelUpPriseValue && Save_214BS.save_BS().saveDataBS.LevelBrawelsBS[_data214Bs.BraewlIndex] < 10)
    {
       Save_214BS.save_BS().saveDataBS.ProgresValueBrawelsBS[_data214Bs.BraewlIndex] -= PowerPoint(LevelBrawlesValue);
       Debug.Log("PRESENT = _214BS".Replace("_214BS", "") + Save_214BS.save_BS().saveDataBS.ProgresValueBrawelsBS[_data214Bs.BraewlIndex]);
       Save_214BS.save_BS().saveDataBS.LevelBrawelsBS[_data214Bs.BraewlIndex]++;
       Save_214BS.save_BS().SaveGameBS();
       GameMoney_214BS.RemoveCoinsBS(LevelUpPriseValue);
       //_data.LevelBrawles = SaveBS.save_BS().saveDataBS.LevelBrawelsBS[_data.BraewlIndex];
       //_data.PresentSliderLevelUp = SaveBS.save_BS().saveDataBS.ProgresValueBrawelsBS[_data.BraewlIndex];
    }
    InitDataBrawel();
  }
}
