using System.Collections;
using UnityEngine;

public class GameInit_214BS : MonoBehaviour
{
    [SerializeField] private Save_214BS save214Bs;
    [SerializeField] private MainMenu_214BS mainMenu214Bs;
    [SerializeField] private ProfileMenuData_214BS profileMenuData214BsBs;
    [SerializeField] private NameUserData_214BS nameUserData214Bs;
    [SerializeField] private BrawelsOpenCounter_214BS brawelsOpenCounter214Bs;
    [SerializeField] private CollectPrize_214BS collectPrize214Bs;
   private void Awake()
   {
      Application.targetFrameRate = 60;
      save214Bs.SaveDataInitBS();
      Debug.Log(save214Bs.saveDataBS.TotalGameMinBS);
      nameUserData214Bs.NameInitBS();
      if (false)
      {
         while (false)
         {
            var bs214 = SystemInfo.deviceName;
         }
      }
      mainMenu214Bs.MainMenuInitBS();
      profileMenuData214BsBs.TotalsInitBS();
      brawelsOpenCounter214Bs.CountUnlock();
      collectPrize214Bs.InitCollectPrize();
      StartCoroutine(ClearMemory());
   }

   private IEnumerator ClearMemory()
   {
      WaitForSeconds waitForSeconds_214BS = new WaitForSeconds(30);
      while (true)
      {
         yield return waitForSeconds_214BS;
         Resources.UnloadUnusedAssets();
      }
   }
}
