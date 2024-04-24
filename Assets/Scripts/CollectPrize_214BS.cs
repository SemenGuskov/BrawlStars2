using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class CollectPrize_214BS : MonoBehaviour
{
     [SerializeField] private MainMenu_214BS mainMenu214Bs;
    private int GetVeluePowerPoints;
    private int SelectBrawelAddPoinl;
    [SerializeField] private Text CoinsPrize;
    [SerializeField] private List<GameObject> PrefabsBrawel;
    private int ToatalOpenBrawel;
    public  void InitCollectPrize()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        OpenBoxes_214BS.CollectRevards += PowerPointPrize;
    }

    private void OnEnable()
    {
        for (int i = 0; i < PrefabsBrawel.Count; i++)
        {
            if (PrefabsBrawel[i].activeSelf)
            {
                PrefabsBrawel[i].GetComponent<CardPrefabData_214BS>().InitCard_214BS();
            }
        }
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
        OpenBoxes_214BS.CollectRevards -= PowerPointPrize;;
    }

    public void PowerPointPrize(int typeBox, int valueCoins)
    {
        ToatalOpenBrawel = 1;
        for (int i = 1; i < Save_214BS.save_BS().saveDataBS.TotalOpenBrawelsBS.Length; i++)
        {
            if (Save_214BS.save_BS().saveDataBS.TotalOpenBrawelsBS[i] != 0)
            {
                ToatalOpenBrawel++;
            }
        }
        for (int i = 0; i < PrefabsBrawel.Count; i++)
        {
            PrefabsBrawel[i].SetActive(false);
        }
        CoinsPrize.text = "+ " + valueCoins;
        switch (typeBox)
        {
            case 0:
                CaseFree();
                break;
            case 1:
                if (ToatalOpenBrawel <= 2)
                {
                    CaseFree();
                }
                else
                {
                    CaseBig3();
                }
                break;
            case 2:
                if (ToatalOpenBrawel <= 2)
                {
                    CaseFree();
                }
                else if (ToatalOpenBrawel == 3)
                {
                    CaseBig3();
                }
                else if (ToatalOpenBrawel == 4)
                {
                    CaseMega4();
                }
                else
                {
                    CaseMega5();
                }
                break;
        }
    }
    private void CaseFree()
    {
        if (ToatalOpenBrawel <= 1)
        {
            GetVeluePowerPoints = Random.Range(3, 10);
            Save_214BS.save_BS().saveDataBS.ProgresValueBrawelsBS[0] += GetVeluePowerPoints;
            //_mainMenuBs._brawlersDatas[0].PresentSliderLevelUp += SaveBS.save_BS().saveDataBS.ProgresValueBrawelsBS[0];
            PrefabsBrawel[0].GetComponent<CardPrefabData_214BS>().cardBrawlersData214Bs = mainMenu214Bs._brawlersDatas[0];
            PrefabsBrawel[0].SetActive(true);
        }
        else
        {
            SelectBrawelAddPoinl = Random.Range(1, ToatalOpenBrawel);
            GetVeluePowerPoints = Random.Range(3, 10);
            Save_214BS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl-1] += GetVeluePowerPoints;
            //_mainMenuBs._brawlersDatas[SelectBrawelAddPoinl - 1].PresentSliderLevelUp += SaveBS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl-1];
            PrefabsBrawel[0].GetComponent<CardPrefabData_214BS>().cardBrawlersData214Bs = mainMenu214Bs._brawlersDatas[SelectBrawelAddPoinl - 1];
            PrefabsBrawel[0].SetActive(true);
            GetVeluePowerPoints = Random.Range(3, 10);
            Save_214BS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl] += GetVeluePowerPoints;
            //_mainMenuBs._brawlersDatas[SelectBrawelAddPoinl].PresentSliderLevelUp += SaveBS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl];
            PrefabsBrawel[1].GetComponent<CardPrefabData_214BS>().cardBrawlersData214Bs = mainMenu214Bs._brawlersDatas[SelectBrawelAddPoinl];
            PrefabsBrawel[1].SetActive(true);
        }
        Save_214BS.save_BS().SaveGameBS();
    }
    private void CaseBig3()
    {
        SelectBrawelAddPoinl = Random.Range(1, ToatalOpenBrawel-1);
        GetVeluePowerPoints = Random.Range(8, 24);
        Save_214BS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl-1] += GetVeluePowerPoints;
        //_mainMenuBs._brawlersDatas[SelectBrawelAddPoinl - 1].PresentSliderLevelUp += SaveBS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl-1];
        PrefabsBrawel[0].GetComponent<CardPrefabData_214BS>().cardBrawlersData214Bs = mainMenu214Bs._brawlersDatas[SelectBrawelAddPoinl - 1];
        PrefabsBrawel[0].SetActive(true);
        GetVeluePowerPoints = Random.Range(8, 24);
        Save_214BS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl] += GetVeluePowerPoints;
        //_mainMenuBs._brawlersDatas[SelectBrawelAddPoinl].PresentSliderLevelUp += SaveBS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl];
        PrefabsBrawel[1].GetComponent<CardPrefabData_214BS>().cardBrawlersData214Bs = mainMenu214Bs._brawlersDatas[SelectBrawelAddPoinl];
        PrefabsBrawel[1].SetActive(true);
        GetVeluePowerPoints = Random.Range(8, 24);
        Save_214BS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl+1] += GetVeluePowerPoints;
        //_mainMenuBs._brawlersDatas[SelectBrawelAddPoinl + 1].PresentSliderLevelUp += SaveBS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl+1];
        PrefabsBrawel[2].GetComponent<CardPrefabData_214BS>().cardBrawlersData214Bs = mainMenu214Bs._brawlersDatas[SelectBrawelAddPoinl + 1];
        PrefabsBrawel[2].SetActive(true); 
        Save_214BS.save_BS().SaveGameBS();
    }
    private void CaseMega4()
    {
         SelectBrawelAddPoinl = Random.Range(2, ToatalOpenBrawel - 1);
         GetVeluePowerPoints = Random.Range(14, 40);
         Save_214BS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl-2] += GetVeluePowerPoints;
        // _mainMenuBs._brawlersDatas[SelectBrawelAddPoinl - 2].PresentSliderLevelUp += SaveBS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl-2];
         PrefabsBrawel[0].GetComponent<CardPrefabData_214BS>().cardBrawlersData214Bs = mainMenu214Bs._brawlersDatas[SelectBrawelAddPoinl - 2];
         PrefabsBrawel[0].SetActive(true);
         GetVeluePowerPoints = Random.Range(14, 40);
         Save_214BS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl-1] += GetVeluePowerPoints;
        // _mainMenuBs._brawlersDatas[SelectBrawelAddPoinl - 1].PresentSliderLevelUp += SaveBS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl-1];
         PrefabsBrawel[1].GetComponent<CardPrefabData_214BS>().cardBrawlersData214Bs = mainMenu214Bs._brawlersDatas[SelectBrawelAddPoinl - 1];
         PrefabsBrawel[1].SetActive(true);
         GetVeluePowerPoints = Random.Range(14, 40);
         Save_214BS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl] += GetVeluePowerPoints;
        // _mainMenuBs._brawlersDatas[SelectBrawelAddPoinl].PresentSliderLevelUp += SaveBS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl];
         PrefabsBrawel[2].GetComponent<CardPrefabData_214BS>().cardBrawlersData214Bs = mainMenu214Bs._brawlersDatas[SelectBrawelAddPoinl];
         PrefabsBrawel[2].SetActive(true);
         GetVeluePowerPoints = Random.Range(14, 40);
         Save_214BS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl+1] += GetVeluePowerPoints;
        // _mainMenuBs._brawlersDatas[SelectBrawelAddPoinl + 1].PresentSliderLevelUp += SaveBS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl+1];
         PrefabsBrawel[3].GetComponent<CardPrefabData_214BS>().cardBrawlersData214Bs = mainMenu214Bs._brawlersDatas[SelectBrawelAddPoinl + 1];
         PrefabsBrawel[3].SetActive(true);
         Save_214BS.save_BS().SaveGameBS();
    }

    private void CaseMega5()
    {
           SelectBrawelAddPoinl = Random.Range(2, ToatalOpenBrawel - 2);
           GetVeluePowerPoints = Random.Range(14, 40);
           Save_214BS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl-2] += GetVeluePowerPoints;
          // _mainMenuBs._brawlersDatas[SelectBrawelAddPoinl - 2].PresentSliderLevelUp += SaveBS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl-2];
           PrefabsBrawel[0].GetComponent<CardPrefabData_214BS>().cardBrawlersData214Bs = mainMenu214Bs._brawlersDatas[SelectBrawelAddPoinl - 2];
           PrefabsBrawel[0].SetActive(true);
           GetVeluePowerPoints = Random.Range(14, 40);
           Save_214BS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl-1] += GetVeluePowerPoints;
          // _mainMenuBs._brawlersDatas[SelectBrawelAddPoinl - 1].PresentSliderLevelUp += SaveBS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl-1];
           PrefabsBrawel[1].GetComponent<CardPrefabData_214BS>().cardBrawlersData214Bs = mainMenu214Bs._brawlersDatas[SelectBrawelAddPoinl - 1];
           PrefabsBrawel[1].SetActive(true);
           GetVeluePowerPoints = Random.Range(14, 40);
           Save_214BS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl] += GetVeluePowerPoints;
          // _mainMenuBs._brawlersDatas[SelectBrawelAddPoinl].PresentSliderLevelUp += SaveBS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl];
           PrefabsBrawel[2].GetComponent<CardPrefabData_214BS>().cardBrawlersData214Bs = mainMenu214Bs._brawlersDatas[SelectBrawelAddPoinl];
           PrefabsBrawel[2].SetActive(true);
           GetVeluePowerPoints = Random.Range(14, 40);
           Save_214BS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl+1] += GetVeluePowerPoints;
          // _mainMenuBs._brawlersDatas[SelectBrawelAddPoinl + 1].PresentSliderLevelUp += SaveBS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl+1];
           PrefabsBrawel[3].GetComponent<CardPrefabData_214BS>().cardBrawlersData214Bs = mainMenu214Bs._brawlersDatas[SelectBrawelAddPoinl + 1];
           PrefabsBrawel[3].SetActive(true);
           GetVeluePowerPoints = Random.Range(14, 40);
           Save_214BS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl+2] += GetVeluePowerPoints;
           //_mainMenuBs._brawlersDatas[SelectBrawelAddPoinl + 2].PresentSliderLevelUp += SaveBS.save_BS().saveDataBS.ProgresValueBrawelsBS[SelectBrawelAddPoinl+2];
           PrefabsBrawel[4].GetComponent<CardPrefabData_214BS>().cardBrawlersData214Bs = mainMenu214Bs._brawlersDatas[SelectBrawelAddPoinl + 2];
           PrefabsBrawel[4].SetActive(true); 
           Save_214BS.save_BS().SaveGameBS();
    }
}
