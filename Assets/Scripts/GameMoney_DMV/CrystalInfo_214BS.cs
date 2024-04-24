using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.IO.IsolatedStorage;

public class CrystalInfo_214BS : MonoBehaviour
{
    [SerializeField] private Text _crystalText;
    private int PresentCrystal;
    private void OnEnable()
    {
        GameMoney_214BS.CrystalInfoRefresh += CrystalInfoUpdateBS;
        PresentCrystal = Save_214BS.save_BS().saveDataBS.CrystalsBS;
        _crystalText.text = PresentCrystal.ToString();
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
        GameMoney_214BS.CrystalInfoRefresh -= CrystalInfoUpdateBS;
    }
    
    void CrystalInfoUpdateBS(int presentCrystal)
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        StartCoroutine(CrystallChangeEffect(presentCrystal));
    }
    private IEnumerator CrystallChangeEffect(int presentCrystal)
    {
        while (true)
        {
            if (PresentCrystal > presentCrystal)
            {
                if (PresentCrystal - presentCrystal >= 50)
                {
                    PresentCrystal -= 50;
                }
                else
                {
                    PresentCrystal--;
                }
                _crystalText.text = PresentCrystal.ToString();
            }
            if (PresentCrystal < presentCrystal)
            {
                if (presentCrystal - PresentCrystal >= 50)
                {
                    PresentCrystal += 50;
                }
                else
                {
                    PresentCrystal++;
                }
                _crystalText.text = PresentCrystal.ToString();
            }
            if (PresentCrystal == presentCrystal)
            {
                _crystalText.text = PresentCrystal.ToString();
                break;
            }
            yield return new WaitForSeconds(0.01f);
        }
    }
}
