using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameUserData_214BS : MonoBehaviour
{
  [SerializeField] private Image _UserIconMainBS;
  [SerializeField] private Text _nametextColorBS;
  [SerializeField] private List<Text> _nameColorBS;
  
  [SerializeField] private InputField _inputFieldName;
  [SerializeField] private GameObject _helpNameDescritionBS;
  [SerializeField] private GameObject _panelMainUserInfoBS;
  [SerializeField] private GameObject _panelChangeNameBS;
   [SerializeField] private MainMenu_214BS mainMenu214Bs;
  
  
  public void NameInitBS()
  {
    _UserIconMainBS.sprite = mainMenu214Bs._brawlersDatas[Save_214BS.save_BS().saveDataBS.UserIconBS].BraewlesIcon;
    _nametextColorBS.text = Save_214BS.save_BS().saveDataBS.UserNameBS;
    _inputFieldName.text = Save_214BS.save_BS().saveDataBS.UserNameBS;
    _nametextColorBS.color = Save_214BS.save_BS().saveDataBS.UserNameColorBS;
  }

  public void RefreshName()
  {
    foreach (var textName in _nameColorBS)
    {
      textName.text = Save_214BS.save_BS().saveDataBS.UserNameBS;
    }
  }

  public void SetNameColorBS(Text textButton)
  {
    Save_214BS.save_BS().saveDataBS.UserNameColorBS = textButton.color;
    Save_214BS.save_BS().SaveGameBS();
    _nametextColorBS.color = Save_214BS.save_BS().saveDataBS.UserNameColorBS;
  }

  public void SetUserIconBS(BrawlersData_214BS UserBrawelIcon)
  {
    Save_214BS.save_BS().saveDataBS.UserIconBS = UserBrawelIcon.BraewlIndex;
    Save_214BS.save_BS().SaveGameBS();
    _UserIconMainBS.sprite = UserBrawelIcon.BraewlesIcon;
  }
  public void ChangeUserName()
  {
    OffHelpText();
    if (_inputFieldName.text.Length >= 2 && !_inputFieldName.text.Contains(" _214BS".Replace("_214BS", "")))
    {
      Save_214BS.save_BS().saveDataBS.UserNameBS = _inputFieldName.text;
      Save_214BS.save_BS().SaveGameBS();
      _nametextColorBS.text = Save_214BS.save_BS().saveDataBS.UserNameBS;
      _panelChangeNameBS.SetActive(false);
      _panelMainUserInfoBS.SetActive(true);
    }
    else
    {
      _helpNameDescritionBS.SetActive(true);
      _inputFieldName.text = "_214BS".Replace("_214BS", "");
      print("Less then 3 symbol");
    }
  }

  public void OffHelpText()
  {
    if (false)
    {
      while (false)
      {
        var bs214 = SystemInfo.deviceName;
      }
    }
    _helpNameDescritionBS.SetActive(false);
  }
  
}
