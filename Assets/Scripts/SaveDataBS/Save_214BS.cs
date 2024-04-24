using System;
using System.Collections.Generic;
using UnityEngine;
using System.IO.IsolatedStorage;

public class Save_214BS : MonoBehaviour
{
        #region SingeltonSaveSystem
        
        private static Save_214BS _save214Bs;
        public static Save_214BS Instance => _save214Bs;
        
        private Save_214BS()
        { 
            byte dgtfergegtiybj = 0;
            _save214Bs = this;
        }
        public static Save_214BS save_BS()
        {
            byte gvtdbfsvitunvij = 0;
            if (false)
            {
                while (false)
                {
                    var bs214 = SystemInfo.deviceName;
                }
            }
            if (_save214Bs == null)
            {
                _save214Bs = Instance;
            }
            return _save214Bs;
        }
    
        #endregion

        private string SaveKey_214BS = "saveBs";
       /// public Sprite _startSpriteIcon;
        
        public SaveDataBS saveDataBS;

         [SerializeField] private MainMenu_214BS mainMenu214Bs;
         [SerializeField] private GameTimer_214BS mainGameTimer214Bs;
        private int _steteFactory;
        
        public void SaveDataInitBS()
        {
            // DeleteDataBS();
            if (!PlayerPrefs.HasKey(SaveKey_214BS)) { FirstSaveBS(); }
            else { LoadDataBS(); }
        }
        private void FirstSaveBS()
        { 
             // GameData
            saveDataBS.CoinsBS = 0;
            saveDataBS.CrystalsBS = 0;
            saveDataBS.TotalCoinsReceivedBS = 0;
            saveDataBS.TotalCrystalsReceivedBS = 0;
            saveDataBS.TotalOpenFreeBoxesBS = 0;
            saveDataBS.TotalOpenBigBoxesBS = 0;
            saveDataBS.TotalOpenMegaBoxesBS = 0;
            //saveDataBS.TotalOpenTrophiesBS = 0;
            saveDataBS.TotalOpenSkinsBS = 0;
            saveDataBS.TotalGameHourBS = 0;
            saveDataBS.TotalGameMinBS = 0;
            
            saveDataBS.BrawlPassPresentLevelBS = 0;
            saveDataBS.BrawlPassPresentStateBS = 0;
            
            saveDataBS.TotalCountPathtoGloryBS = 0;
            saveDataBS.PathElementClaim = new bool [500];
            saveDataBS.TotalOpenBrawelsBS = new int [57];
            saveDataBS.LevelBrawelsBS = new int [57];
            for (int i = 0; i < saveDataBS.LevelBrawelsBS.Length; i++)
            {
                saveDataBS.LevelBrawelsBS[i] = 1;
            }
            saveDataBS.ProgresValueBrawelsBS = new int [57];
            
            saveDataBS.QuestTrophyElements = new bool [10];
            saveDataBS.QuestTrophyElements[0] = true;
            saveDataBS.QuestBigBoxElements = new bool [10];
            saveDataBS.QuestBigBoxElements[0] = true;
            saveDataBS.QuestMegaBoxElements = new bool [10];
            saveDataBS.QuestMegaBoxElements[0] = true; 
            saveDataBS.QuestBrawelsElements = new bool [12];
            saveDataBS.QuestBrawelsElements[0] = true;
            saveDataBS.QuestGameTimeElements = new bool [10];
            saveDataBS.QuestGameTimeElements[0] = true; 
           // saveDataBS.TotalQuestBrawelsBS = new Dictionary<int, int>();
            
            //Indicators
            saveDataBS.BrawelIndicatorValue = 0;
            saveDataBS.QuestIndicatorValue = 0;
            
            //  UserData
            saveDataBS.UserIconBS = 0;
            saveDataBS.UserNameBS = "User_Name";
            saveDataBS.UserNameColorBS = Color.white;
            saveDataBS.UserAvatarIndexBS = 0;
            saveDataBS.UserLevelBS = 0;
            
            // Settings
            saveDataBS.AudioClipBS = new List<AudioClip>(100);
            saveDataBS.SoundsBS = true;
            saveDataBS.MusicBS = true;
            SaveGameBS(); 
        }
        public void LoadDataBS()
        {
            if (PlayerPrefs.HasKey(SaveKey_214BS)) 
            {
                saveDataBS = JsonUtility.FromJson<SaveDataBS>(PlayerPrefs.GetString(SaveKey_214BS)); 
            }
        }
        public  void SaveGameBS() 
        {
            if (false)
            {
                while (false)
                {
                    var bs214 = SystemInfo.deviceName;
                }
            }
            PlayerPrefs.SetString(SaveKey_214BS, JsonUtility.ToJson(saveDataBS));
        }
        public void DeleteDataBS()
        {
            PlayerPrefs.DeleteKey("TotalOpened");
            PlayerPrefs.DeleteKey("LastOpened");
            mainMenu214Bs.ResetProgress_214BS();
            PlayerPrefs.DeleteKey(SaveKey_214BS);
            FirstSaveBS();
        }

        private void Start()
        {
            mainGameTimer214Bs.hour_214BS = saveDataBS.TotalGameHourBS;
            if (false)
            {
                while (false)
                {
                    var bs214 = SystemInfo.deviceName;
                }
            }
            mainGameTimer214Bs.min_214BS += saveDataBS.TotalGameMinBS;
            InvokeRepeating("UpdateData", 1, 60);
        }

        private void UpdateData()
        {
            SaveGameBS();
            if (false)
            {
                while (false)
                {
                    var bs214 = SystemInfo.deviceName;
                }
            }
            LoadDataBS();
        }

        private void OnApplicationQuit()
        {
            saveDataBS.TotalGameHourBS = mainGameTimer214Bs.hour_214BS;
            if (false)
            {
                while (false)
                {
                    var bs214 = SystemInfo.deviceName;
                }
            }
            saveDataBS.TotalGameMinBS = mainGameTimer214Bs.min_214BS;
            SaveGameBS();
        }

        [Serializable] 
        public class SaveDataBS
        {
            // GameData      
            public int CoinsBS;
            public int CrystalsBS;
            public int TotalCoinsReceivedBS;
            public int TotalCrystalsReceivedBS;
            public int TotalOpenFreeBoxesBS;
            public int TotalOpenBigBoxesBS;
            public int TotalOpenMegaBoxesBS;
            public int[] TotalOpenBrawelsBS;
            public int[] LevelBrawelsBS;
            public int[] ProgresValueBrawelsBS;

            public bool[] QuestTrophyElements;
            public bool[] QuestBigBoxElements;
            public bool[] QuestMegaBoxElements;
            public bool[] QuestBrawelsElements;
            public bool[] QuestGameTimeElements;
            //public Dictionary<int,int> TotalQuestBrawelsBS;
            public int TotalOpenSkinsBS;
            public int TotalGameHourBS;
            public int TotalGameMinBS;
            
            public int BrawlPassPresentLevelBS;
            public int BrawlPassPresentStateBS;
            
            public int TotalCountPathtoGloryBS;
            public  bool[] PathElementClaim;
            //Indicators
            public int BrawelIndicatorValue;
            public int QuestIndicatorValue;
            
            //  UserData
            public int UserIconBS;
            public string UserNameBS;
            public Color UserNameColorBS;
            public int UserAvatarIndexBS;
            public int UserLevelBS;
            
            // Settings
            public List<AudioClip> AudioClipBS;
            public bool SoundsBS;
            public bool MusicBS;
        }
        
}
