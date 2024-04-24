using System;
using UnityEngine;
using UnityEngine.UI;

public class IndicatorsEvents_214BS : MonoBehaviour
{
  
     [SerializeField] private GameObject _shopIndicator_214BS;
     [SerializeField] private GameObject _brawelIndicator_214BS;
     [SerializeField] private GameObject _questIndicator_214BS;
    
    // [SerializeField] private Text _shopIndicatorText;
     [SerializeField] private Text _brawelIndicatorText_214BS;
     [SerializeField] private Text _questIndicatorText_214BS;


    public static Action<TypeIndicator> ShopIvent_214BS;
    public static Action<TypeIndicator> BrawelIvent_214BS;
    public static Action<TypeIndicator> QuestIvent_214BS;
    
    
    private void Start()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        CalculateIndicators(TypeIndicator.SHOP_214BS);
    }
    
    private void OnEnable()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        CalculateIndicators(TypeIndicator.BRAWELS_214BS);
    }

    public void ResetNewBrawel()
    {
        Save_214BS.save_BS().saveDataBS.BrawelIndicatorValue = 0;
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        Save_214BS.save_BS().SaveGameBS();
    }
    
    public void CalculateIndicators(TypeIndicator typeindicator)
    {
        switch (typeindicator)
        {
            case TypeIndicator.SHOP_214BS:
                _shopIndicator_214BS.SetActive(true);
                break;
            case TypeIndicator.BRAWELS_214BS:
                if (Save_214BS.save_BS().saveDataBS.BrawelIndicatorValue > 0)
                {
                    _brawelIndicatorText_214BS.text = Save_214BS.save_BS().saveDataBS.BrawelIndicatorValue.ToString();
                    _brawelIndicator_214BS.SetActive(true);
                }
                else
                {
                    _brawelIndicator_214BS.SetActive(false);
                }
                break;
            case TypeIndicator.QUEST_214BS:
                if (Save_214BS.save_BS().saveDataBS.QuestIndicatorValue > 0)
                {
                    _questIndicatorText_214BS.text = Save_214BS.save_BS().saveDataBS.QuestIndicatorValue.ToString();
                    _questIndicator_214BS.SetActive(true);
                }
                else
                {
                    _questIndicator_214BS.SetActive(false);
                }
                break;
        }
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
    }
}

public enum TypeIndicator
{
 SHOP_214BS,
 BRAWELS_214BS,
 QUEST_214BS
}