using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO.IsolatedStorage;

public class SliderProgressController_214BS : MonoBehaviour
{
    [SerializeField] private GameObject _mainPanel_214BS;
   [SerializeField] private GameObject _pathtoGlory;
    [SerializeField] private GameObject _loaderPanel;
 
   [SerializeField] private Slider _sliderMainPanel;
   [SerializeField] private Image _spritesIconBS;
   [SerializeField] private List<Sprite> _spritesBS;
   [SerializeField] private List<Slider> _slidersBS;
   private int PresentProgressValueBS;
   [SerializeField] private Text _SliderHandleText;
   private void Start()
   {
    if (false)
    {
     while (false)
     {
      var bs214 = SystemInfo.deviceName;
     }
    }
    OnEnable();
    SetPresentValueSlider_214BS();
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
    SetPresentValueSlider_214BS();
   }
   private void SetIcon_214BS(int indexSprite)
   {
    if (false)
    {
     while (false)
     {
      var bs214 = SystemInfo.deviceName;
     }
    }
    _spritesIconBS.sprite = _spritesBS[indexSprite];
   }
   public void SetPresentValueSlider_214BS()
   {
    PresentProgressValueBS = Save_214BS.save_BS().saveDataBS.TotalCountPathtoGloryBS;
    if (false)
    {
     while (false)
     {
      var bs214 = SystemInfo.deviceName;
     }
    }

    int[] minValues = { 0, 5, 15, 25, 40, 60, 200, 250, 400, 450, 500, 550, 600, 650, 700, 750, 800, 850, 900, 950, 1000, 1100, 1200, 1300, 1400 };
    int[] maxValues = { 5, 15, 25, 40, 60, 200, 250, 400, 450, 500, 550, 600, 650, 700, 750, 800, 850, 900, 950, 1000, 1100, 1200, 1300, 1400, 1500 };
        //    if (PresentProgressValueBS >= 0 && 5 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 0;
        // _sliderMainPanel.maxValue = 5;
        // SetIcon_214BS(0);
        //}
        //if (PresentProgressValueBS > 5 && 15 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 5;
        // _sliderMainPanel.maxValue = 15;
        // SetIcon_214BS(1);
        //}
        //if (PresentProgressValueBS > 15 && 25 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 15;
        // _sliderMainPanel.maxValue = 25;
        // SetIcon_214BS(2);
        //}
        //if (PresentProgressValueBS > 25 && 40 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 25;
        // _sliderMainPanel.maxValue = 40;
        // SetIcon_214BS(3);
        //}
        //if (PresentProgressValueBS > 40 && 60 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 40;
        // _sliderMainPanel.maxValue = 60;
        // SetIcon_214BS(4);
        //}
        //if (PresentProgressValueBS > 60 && 200 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 60;
        // _sliderMainPanel.maxValue = 200;
        // SetIcon_214BS(5);
        //}
        //if (PresentProgressValueBS > 200 && 250>=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 200;
        // _sliderMainPanel.maxValue = 250;
        // SetIcon_214BS(6);
        //}
        //if (PresentProgressValueBS > 250 && 400 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 250;
        // _sliderMainPanel.maxValue = 400;
        // SetIcon_214BS(7);
        //}
        //if (PresentProgressValueBS > 400 && 450 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 400;
        // _sliderMainPanel.maxValue = 450;
        // SetIcon_214BS(8);
        //}
        //if (PresentProgressValueBS > 450 && 500 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 450;
        // _sliderMainPanel.maxValue = 500;
        // SetIcon_214BS(9);
        //}
        //if (PresentProgressValueBS > 500 && 550 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 500;
        // _sliderMainPanel.maxValue = 550;
        // SetIcon_214BS(10);
        //}
        //if (PresentProgressValueBS > 550 && 600 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 550;
        // _sliderMainPanel.maxValue = 600;
        // SetIcon_214BS(11);
        //}
        //if (PresentProgressValueBS > 600 && 650 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 600;
        // _sliderMainPanel.maxValue = 650;
        // SetIcon_214BS(12);
        //}
        //if (PresentProgressValueBS > 650 && 700 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 650;
        // _sliderMainPanel.maxValue = 700;
        // SetIcon_214BS(13);
        //}
        //if (PresentProgressValueBS > 700 && 750 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 700;
        // _sliderMainPanel.maxValue = 750;
        // SetIcon_214BS(14);
        //}
        //if (PresentProgressValueBS > 750 && 800 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 750;
        // _sliderMainPanel.maxValue = 800;
        // SetIcon_214BS(15);
        //}
        //if (PresentProgressValueBS > 800 && 850 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 800;
        // _sliderMainPanel.maxValue = 850;
        // SetIcon_214BS(16);
        //}
        //if (PresentProgressValueBS > 850 && 900 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 850;
        // _sliderMainPanel.maxValue = 900;
        // SetIcon_214BS(17);
        //}
        //if (PresentProgressValueBS > 900 && 950 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 900;
        // _sliderMainPanel.maxValue = 950;
        // SetIcon_214BS(18);
        //}
        //if (PresentProgressValueBS > 950 && 1000 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 950;
        // _sliderMainPanel.maxValue = 1000;
        // SetIcon_214BS(19);
        //}
        //if (PresentProgressValueBS > 1000 && 1100 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 1000;
        // _sliderMainPanel.maxValue = 1100;
        // SetIcon_214BS(20);
        //}
        //if (PresentProgressValueBS > 1100 && 1200 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 1100;
        // _sliderMainPanel.maxValue = 1200;
        // SetIcon_214BS(21);
        //}
        //if (PresentProgressValueBS > 1200 && 1300 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 1200;
        // _sliderMainPanel.maxValue = 1300;
        // SetIcon_214BS(22);
        //}
        //if (PresentProgressValueBS > 1300 && 1400 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 1300;
        // _sliderMainPanel.maxValue = 1400;
        // SetIcon_214BS(23);
        //}
        //if (PresentProgressValueBS > 1400 && 1500 >=  PresentProgressValueBS)
        //{
        // _sliderMainPanel.minValue = 1400;
        // _sliderMainPanel.maxValue = 1500;
        // SetIcon_214BS(24);
        //}
        for (int i = 0; i < minValues.Length; i++)
        {
            if (PresentProgressValueBS > minValues[i] && PresentProgressValueBS <= maxValues[i])
            {
                _sliderMainPanel.minValue = minValues[i];
                _sliderMainPanel.maxValue = maxValues[i];
                SetIcon_214BS(i);
                break;
            }
        }

        _sliderMainPanel.value = PresentProgressValueBS;
   }
   public void SlidersInit()
   {
     _slidersBS[0].minValue = 0;
     _slidersBS[0].maxValue = 5;
     _slidersBS[1].maxValue = 15;
     _slidersBS[2].maxValue = 25;
     _slidersBS[3].maxValue = 40;
     _slidersBS[4].maxValue = 60;
     _slidersBS[5].maxValue = 200;
     _slidersBS[6].maxValue = 250;
     _slidersBS[7].maxValue = 350;
     _slidersBS[8].maxValue = 400;
     _slidersBS[9].maxValue = 450;
     _slidersBS[10].maxValue = 500;
     _slidersBS[11].maxValue = 550;
     _slidersBS[12].maxValue = 600;
     _slidersBS[13].maxValue = 650;
     _slidersBS[14].maxValue = 700;
     _slidersBS[15].maxValue = 750;
     _slidersBS[16].maxValue = 800;
     _slidersBS[17].maxValue = 850;
     _slidersBS[18].maxValue = 900;
     _slidersBS[19].maxValue = 950;
     _slidersBS[20].maxValue = 1000;
     _slidersBS[21].maxValue = 1100;
     _slidersBS[22].maxValue = 1200;
     _slidersBS[23].maxValue = 1300;
     _slidersBS[24].maxValue = 1400;
     _slidersBS[25].maxValue = 1500;
     for (int i = 1; i < _slidersBS.Count; i++)
     {
      _slidersBS[i].minValue = _slidersBS[i - 1].maxValue;
     }
   }
   public void OpenPathPanel_214BS()
   {
        //_mainPanel_214BS.SetActive(false);
        _loaderPanel.SetActive(true);
        _pathtoGlory.SetActive(true);
        SlidersInit();
    _SliderHandleText.text = PresentProgressValueBS.ToString();
    
    for (int i_214BS = 0; i_214BS < _slidersBS.Count; i_214BS++)
    {
      if (PresentProgressValueBS > _slidersBS[i_214BS].maxValue)
      { 
        if (i_214BS < _slidersBS.Count-1)
        {
         _SliderHandleText.text = PresentProgressValueBS.ToString();
         _slidersBS[i_214BS].handleRect.SetParent(_slidersBS[i_214BS+1].handleRect.parent);
         _slidersBS[i_214BS+1].handleRect = _slidersBS[i_214BS].handleRect;
         _slidersBS[i_214BS].handleRect.anchoredPosition = new Vector2(0,_slidersBS[i_214BS].handleRect.anchoredPosition.y);
        }
        _slidersBS[i_214BS].value = _slidersBS[i_214BS].maxValue;
      }
      
      if (PresentProgressValueBS <= _slidersBS[i_214BS].minValue)
      {
       _slidersBS[i_214BS].value = _slidersBS[i_214BS].minValue;
      }
      
      if (PresentProgressValueBS >= _slidersBS[i_214BS].minValue && PresentProgressValueBS <= _slidersBS[i_214BS].maxValue)
      {
       _slidersBS[i_214BS].value = PresentProgressValueBS;
      }
    }
   }
}
