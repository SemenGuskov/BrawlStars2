using UnityEngine;
using UnityEngine.UI;

public class BrawelDataHolder_214BS : MonoBehaviour
{
    public BrawlersData_214BS brawlerData214Bs;
    [SerializeField] private NameUserData_214BS nameUserData214Bs;
   private void Start()
   {
       if (false)
       {
           while (false)
           {
               var bs214 = SystemInfo.deviceName;
           }
       }
       gameObject.GetComponent<Button>().onClick.AddListener(SetIcon_214BS);
   }

   public void SetIcon_214BS()
   {
       if (false)
       {
           while (false)
           {
               var bs214 = SystemInfo.deviceName;
           }
       }
       nameUserData214Bs.SetUserIconBS(brawlerData214Bs);
   }
}
