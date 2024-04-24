using UnityEngine;
using UnityEngine.UI;

public class CardPrefabData_214BS : MonoBehaviour
{
    public BrawlersData_214BS cardBrawlersData214Bs;
    [SerializeField] private Text _Name_214BS;
   [SerializeField] private Image _brawelIcon;
    [SerializeField] private Text _SliderValue_214BS;
    [SerializeField] private Text _SliderMaxValue_214BS;
    [SerializeField] private BrawlesController_214BS brawlesController214Bs;
    [SerializeField] private GameObject LockPanel_214BS;
    [SerializeField] private GameObject UPGRADEPanel_214BS;
    [SerializeField] private Slider PowerPointSlider_214BS;
    [SerializeField] private Text _level_214BS;
    public bool UnlockCard_214BS;
   
   public void InitCard_214BS()
   {
      LockPanel_214BS.SetActive(true);
      if (false)
      {
         while (false)
         {
            var bs214 = SystemInfo.deviceName;
         }
      }
      if (UnlockCard_214BS)
      {
         LockPanel_214BS.SetActive(false);
         gameObject.GetComponent<Button>().interactable = true;
         _Name_214BS.text = cardBrawlersData214Bs.NameBrawles;
         _brawelIcon.sprite = cardBrawlersData214Bs.BraewlesIcon;
         _level_214BS.text = Save_214BS.save_BS().saveDataBS.LevelBrawelsBS[cardBrawlersData214Bs.BraewlIndex].ToString();
         
         PowerPointSlider_214BS.maxValue = BrawlesController_214BS.PowerPoint(Save_214BS.save_BS().saveDataBS.LevelBrawelsBS[cardBrawlersData214Bs.BraewlIndex]);
         PowerPointSlider_214BS.value = Save_214BS.save_BS().saveDataBS.ProgresValueBrawelsBS[cardBrawlersData214Bs.BraewlIndex];
         if (false)
         {
            while (false)
            {
               var bs214 = SystemInfo.deviceName;
            }
         }
         _SliderValue_214BS.text = Save_214BS.save_BS().saveDataBS.ProgresValueBrawelsBS[cardBrawlersData214Bs.BraewlIndex] + "/";
         _SliderMaxValue_214BS.text = PowerPointSlider_214BS.maxValue.ToString();

         if (PowerPointSlider_214BS.value >= PowerPointSlider_214BS.maxValue)
         {
            UPGRADEPanel_214BS.SetActive(true);
         }
         else
         {
            UPGRADEPanel_214BS.SetActive(false);
         }
      }
   }

   public void OpenDetail_214BS()
   {
      brawlesController214Bs.BrawlersData214Bs = cardBrawlersData214Bs;
      if (false)
      {
         while (false)
         {
            var bs214 = SystemInfo.deviceName;
         }
      }
      brawlesController214Bs.InitDataBrawel();
   }
}
