using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using System.IO.IsolatedStorage;

public class ShopController_214BS : MonoBehaviour
{
   [SerializeField] private List<Text> _buttonsShop_214BS;
   [SerializeField] private Scrollbar _sliderShop_214BS;
   [SerializeField] private float slidingTime_214BS;
   [SerializeField] private GameObject CoinRevard_214BS;
   [SerializeField] private GameObject CrystalRevard_214BS;
   [SerializeField] private GameObject PowerpointRevard_214BS;

  private void Start()
  {
      if (false)
      {
          while (false)
          {
              var bs214 = SystemInfo.deviceName;
          }
      }
      GameTimer_214BS.TimeIsLess_214BS += TimerOff;
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
      SlideControll_214BS();
  }

  private void OnDestroy()
  {
      if (false)
      {
          while (false)
          {
              var bs214 = SystemInfo.deviceName;
          }
      }
      GameTimer_214BS.TimeIsLess_214BS -= TimerOff;
  }

  public void SlideControll_214BS()
  {
      if (_sliderShop_214BS.value <= 0.2)
      {
          _buttonsShop_214BS[0].color = Color.yellow;
          _buttonsShop_214BS[0].fontSize = 55;
          _buttonsShop_214BS[1].color = Color.white;
          _buttonsShop_214BS[1].fontSize = 45;
          _buttonsShop_214BS[2].color = Color.white;
          _buttonsShop_214BS[2].fontSize = 45;
          _buttonsShop_214BS[3].color = Color.white;
          _buttonsShop_214BS[3].fontSize = 45;
      }
      if (_sliderShop_214BS.value > 0.2 && _sliderShop_214BS.value <= 0.5)
      {
          _buttonsShop_214BS[0].color = Color.white;
          _buttonsShop_214BS[0].fontSize = 45;
          _buttonsShop_214BS[1].color = Color.yellow;
          _buttonsShop_214BS[1].fontSize = 55;
          _buttonsShop_214BS[2].color = Color.white;
          _buttonsShop_214BS[2].fontSize = 45;
          _buttonsShop_214BS[3].color = Color.white;
          _buttonsShop_214BS[3].fontSize = 45;
      }
      if (_sliderShop_214BS.value > 0.5 && _sliderShop_214BS.value <= 0.8)
      {
          _buttonsShop_214BS[0].color = Color.white;
          _buttonsShop_214BS[0].fontSize = 45;
          _buttonsShop_214BS[1].color = Color.white;
          _buttonsShop_214BS[1].fontSize = 45;
          _buttonsShop_214BS[2].color = Color.yellow;
          _buttonsShop_214BS[2].fontSize = 55;
          _buttonsShop_214BS[3].color = Color.white;
          _buttonsShop_214BS[3].fontSize = 45;
      }
      if (_sliderShop_214BS.value > 0.8 && _sliderShop_214BS.value <= 1.1f)
      {
          _buttonsShop_214BS[0].color = Color.white;
          _buttonsShop_214BS[0].fontSize = 45;
          _buttonsShop_214BS[1].color = Color.white;
          _buttonsShop_214BS[1].fontSize = 45;
          _buttonsShop_214BS[2].color = Color.white;
          _buttonsShop_214BS[2].fontSize = 45;
          _buttonsShop_214BS[3].color = Color.yellow;
          _buttonsShop_214BS[3].fontSize = 55;
      }
  }

  public void SetSlider(float slideValue)
  {
      DOTween.To(() => _sliderShop_214BS.value, x => _sliderShop_214BS.value = x, slideValue, slidingTime_214BS);
  }


  public void TimerOff(TypeTimer typeTimer)
  {
      switch (typeTimer)
      {
          case TypeTimer.CoinsTimer :
              CoinRevard_214BS.SetActive(false);
              IndicatorsEvents_214BS.ShopIvent_214BS.Invoke(TypeIndicator.SHOP_214BS);
              break;
          case TypeTimer.CrystalsTimer:
              CrystalRevard_214BS.SetActive(false);
              IndicatorsEvents_214BS.ShopIvent_214BS.Invoke(TypeIndicator.SHOP_214BS);
              break;
          case TypeTimer.PowerPointsTimer :
              PowerpointRevard_214BS.SetActive(false);
              IndicatorsEvents_214BS.ShopIvent_214BS.Invoke(TypeIndicator.SHOP_214BS);
              break;
      }
  }
  
}
