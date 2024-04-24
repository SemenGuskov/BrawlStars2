using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrawelsOpenCounter_214BS : MonoBehaviour
{
    [SerializeField] private GameObject OpenPanelBrawels;
    [SerializeField] private GameObject ClosePanelBrawels;

     [SerializeField] private Text totalOpen_214BS;
     [SerializeField] private Text totalCards_214BS;

    private int CountUnlockBrawels;
    
    public  List<Transform> _ChildCards;
    
    public void CountUnlock()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        OnEnable();
    }
    private void OnEnable()
    {
        for (int i = 1; i < Save_214BS.save_BS().saveDataBS.TotalOpenBrawelsBS.Length; i++)
        {
            _ChildCards[0].transform.SetParent(OpenPanelBrawels.transform);
            _ChildCards[0].GetComponent<CardPrefabData_214BS>().UnlockCard_214BS = true;
            _ChildCards[0].GetComponent<CardPrefabData_214BS>().InitCard_214BS();
            
            if (Save_214BS.save_BS().saveDataBS.TotalOpenBrawelsBS[i] != 0)
            {
                _ChildCards[i].transform.SetParent(OpenPanelBrawels.transform);
                _ChildCards[i].GetComponent<CardPrefabData_214BS>().UnlockCard_214BS = true;
                _ChildCards[i].GetComponent<CardPrefabData_214BS>().InitCard_214BS();
            }
            else
            { 
                _ChildCards[i].GetComponent<CardPrefabData_214BS>().UnlockCard_214BS = false;
                _ChildCards[i].GetComponent<CardPrefabData_214BS>().InitCard_214BS();
            }
        }
        InitOpenCounter();
    }
   
    public void InitOpenCounter()
    {
        int TotalCards_214BS = OpenPanelBrawels.transform.childCount + ClosePanelBrawels.transform.childCount;
        totalCards_214BS.text = "/" + TotalCards_214BS;
        totalOpen_214BS.text = OpenPanelBrawels.transform.childCount.ToString();
    }
}
