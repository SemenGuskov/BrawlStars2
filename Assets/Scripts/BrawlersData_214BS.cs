using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu( menuName = "BrawlersData", fileName = "Brawlers")]
public class BrawlersData_214BS : ScriptableObject
{
 //public bool UnlockBrawelStatus;
 //public bool ChooseBrawelStatus;
 public int BraewlIndex;
 public Sprite BraewlesIcon;
 public List<Texture2D> BraewlesSkin;
 public int BraewlesSkinIndexSelected;
 public string NameBrawles;
 public TypeBrawles TypeBrawles;
 public DropType DropType;
 //public int LevelBrawles;
 public int Offense;
  public int Defense_214BS;
 public int Untility;
 //public int PresentSliderLevelUp;

 public List<AudioClip> BrawelsSounds;
}

public enum TypeBrawles
{
 DESTROYER_214BS,
 TANK_214BS,
 SUPPORT_214BS,
 ASSASIN_214BS,
 HYBRID_214BS
}
public enum DropType
{
 INITIAL_BRAWLER_214BS,
 PATH_TO_GLORY_214BS,
 RARE_214BS,
 SUPER_RARE_214BS,
 EPIC_214BS,
 MYTHICAL_214BS,
 LEGENDARY_214BS,
 CHROMATIC_214BS
}
