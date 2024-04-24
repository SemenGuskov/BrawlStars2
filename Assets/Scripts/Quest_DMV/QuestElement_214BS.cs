using UnityEngine;
using System.IO.IsolatedStorage;

[CreateAssetMenu( menuName = "QuestData", fileName = "QuestElement")]
public class QuestElement_214BS : ScriptableObject
{
  [SerializeField] private int _valueDoneQuest;
  [SerializeField] private int _coinsPrizeValue;
  [SerializeField] private int _crystalPrizeValue;
  public TypeQuest TypeQuest;

  public int MaxValueSliderBS
  {
    get { return _valueDoneQuest; }
    set { _valueDoneQuest = value; }
  }
  public int CoinsPrizeBS
  {
    get { return _coinsPrizeValue; }
    set { _coinsPrizeValue = value; }
  }
  public int CrystalsPrizeBS
  {
    get { return _crystalPrizeValue; }
    set { _crystalPrizeValue = value; }
  }
}
public enum TypeQuest
{
  TROPHIES,
  BRAWELS,
  GAMETIME,
  OPENBIGCHEST,
  OPENMEGACHEST
}
