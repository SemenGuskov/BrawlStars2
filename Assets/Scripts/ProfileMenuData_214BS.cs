using UnityEngine;
using UnityEngine.UI;

public class ProfileMenuData_214BS : MonoBehaviour
{
   [SerializeField] private Text OpenFreeBoxBS;
   [SerializeField] private Text OpenBigBoxBS;
   [SerializeField] private Text OpenMegaBoxBS;
   [SerializeField] private Text TotalCoinsBS;
   [SerializeField] private Text TotalCrystalsBS;
   [SerializeField] private Text TotalSkinsBS;
   [SerializeField] private Text TotalGameTimeBS;

   public void TotalsInitBS()
   {
      Save_214BS.save_BS().SaveGameBS();
      Save_214BS.save_BS().LoadDataBS();
      OpenFreeBoxBS.text = Save_214BS.save_BS().saveDataBS.TotalOpenFreeBoxesBS.ToString();
      OpenBigBoxBS.text = Save_214BS.save_BS().saveDataBS.TotalOpenBigBoxesBS.ToString();
      OpenMegaBoxBS.text = Save_214BS.save_BS().saveDataBS.TotalOpenMegaBoxesBS.ToString();
      TotalCoinsBS.text = Save_214BS.save_BS().saveDataBS.TotalCoinsReceivedBS.ToString();
      TotalCrystalsBS.text = Save_214BS.save_BS().saveDataBS.TotalCrystalsReceivedBS.ToString();
      TotalSkinsBS.text = Save_214BS.save_BS().saveDataBS.TotalOpenSkinsBS.ToString();
      InitTime();
   }

   private void InitTime()
   {
      for (int i = 0; i < 5; i++)
         TotalGameTimeBS.text =
            $"{Save_214BS.save_BS().saveDataBS.TotalGameHourBS:00}:{Save_214BS.save_BS().saveDataBS.TotalGameMinBS:00}";
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
      TotalsInitBS();
   }
}
