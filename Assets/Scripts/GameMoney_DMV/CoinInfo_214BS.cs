using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.IO.IsolatedStorage;

public class CoinInfo_214BS : MonoBehaviour
{
    [SerializeField] private Text _coinsText;
    private int PresentCoins;
    private void OnEnable()
    {
        GameMoney_214BS.CoinInfoRefresh += CoinInfoUpdateBS;
        PresentCoins = Save_214BS.save_BS().saveDataBS.CoinsBS;
        _coinsText.text = PresentCoins.ToString();
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
        GameMoney_214BS.CoinInfoRefresh -= CoinInfoUpdateBS;
    }
    
    void CoinInfoUpdateBS(int presentCoin)
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        StartCoroutine(CoinsChangeEffect(presentCoin));
    }

    private IEnumerator CoinsChangeEffect(int presentCoin)
    {
        while (true)
        {
            if (PresentCoins > presentCoin)
            {
                if (PresentCoins - presentCoin >= 50)
                {
                    PresentCoins -= 50;
                }
                else
                {
                    PresentCoins--;
                }
                _coinsText.text = PresentCoins.ToString();
            }
            if (PresentCoins < presentCoin)
            {
                if (presentCoin - PresentCoins >= 50)
                {
                    PresentCoins += 50;
                }
                else
                {
                    PresentCoins++;
                }
                _coinsText.text = PresentCoins.ToString();
            }
            if (PresentCoins == presentCoin)
            {
                _coinsText.text = PresentCoins.ToString();
                break;
            }
            yield return new WaitForSeconds(0.01f);
        }
    }
}
