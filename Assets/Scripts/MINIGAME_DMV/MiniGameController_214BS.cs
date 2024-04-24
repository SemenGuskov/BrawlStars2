using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using System.IO.IsolatedStorage;

public class MiniGameController_214BS : MonoBehaviour
{
  [SerializeField] private GameObject EmptyCell;
  [SerializeField] private GameObject BombCell;
  [SerializeField] private GameObject CoinsCell;
  [SerializeField] private GameObject CrystalsCell;

  private TypeMiniGame _typeMiniGame;

  [SerializeField] private List<GameObject> Group9Rows;
  [SerializeField] private List<GameObject> InstalProps;
  int countPush;

    private void Start()
    {
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        ChooseTypeMiniGame(0);
    }

    public void BackButton()
    {
        if (SpawnMiniGames.DestroyMiniGameEvent != null) SpawnMiniGames.DestroyMiniGameEvent.Invoke(gameObject);   
    }

    private void OnEnable()
    {
        countPush = 0;
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        StartCoroutine(ScaleCells());
    }

    private void OnDisable()
    {
        for (int i = 0; i < InstalProps.Count; i++)
        {
            Destroy(InstalProps[i]);
        }
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        InstalProps.Clear();
    }

    public void ChooseTypeMiniGame(int numbertype)
    {
        if (numbertype == 0)
        {
            _typeMiniGame = TypeMiniGame.Easy_214BS;
        }

        if (numbertype == 1)
        {
            _typeMiniGame = TypeMiniGame.Hard_214BS;
        }

        Group9Rows[0].SetActive(true);

        for (int i = 0; i < Group9Rows.Count; i++)
        {
            if (_typeMiniGame == TypeMiniGame.Easy_214BS)
            {
                int BombCellIndex = Random.Range(0, 4);
                Group9Rows[i].GetComponent<Group4Cells_214BS>().Cells_214BS[BombCellIndex].GetComponent<CellData_214BS>().InitCell_214BS(TypeCell.Bomb_214BS);
            }
            else if (_typeMiniGame == TypeMiniGame.Hard_214BS)
            {
                int BombCellIndex = Random.Range(2, 4);
                Group9Rows[i].GetComponent<Group4Cells_214BS>().Cells_214BS[BombCellIndex].GetComponent<CellData_214BS>().InitCell_214BS(TypeCell.Bomb_214BS);
                int BombCellIndexSecond = Random.Range(0, 2);
                Group9Rows[i].GetComponent<Group4Cells_214BS>().Cells_214BS[BombCellIndexSecond].GetComponent<CellData_214BS>().InitCell_214BS(TypeCell.Bomb_214BS);
            }
        }

        SetRevardCell();
    }
    public void SetRevardCell()
    {
        for (int i = 0; i < Group9Rows.Count; i++)
        {
            for (int j = 0; j < Group9Rows[i].GetComponent<Group4Cells_214BS>().Cells_214BS.Count; j++)
            {
                if (Group9Rows[i].GetComponent<Group4Cells_214BS>().Cells_214BS[j].GetComponent<CellData_214BS>()._typeCell_214BS == TypeCell.Empty_214BS)
                {
                    int BombCellIndex = Random.Range(0, 2);

                    if (BombCellIndex == 0)
                    {
                        Group9Rows[i].GetComponent<Group4Cells_214BS>().Cells_214BS[j].GetComponent<CellData_214BS>()._typeCell_214BS = TypeCell.Empty_214BS;
                    }
                    else
                    {
                        Group9Rows[i].GetComponent<Group4Cells_214BS>().Cells_214BS[j].GetComponent<CellData_214BS>()._typeCell_214BS = TypeCell.Coins_214BS;
                    }
                }
            }
        }
    }

    public void OpenCell(GameObject CellObject)
    {
        countPush++;
        switch (CellObject.GetComponent<CellData_214BS>()._typeCell_214BS)
        {
            case TypeCell.Empty_214BS:
                InstalProps.Add(Instantiate(EmptyCell, CellObject.transform.position, Quaternion.identity, CellObject.transform));
                StartCoroutine(ScaleCells());
                break;
            case TypeCell.Bomb_214BS:
                InstalProps.Add(Instantiate(BombCell, CellObject.transform.position, Quaternion.identity, CellObject.transform));
                StartCoroutine(OpenAllCells());
                break;
            case TypeCell.Coins_214BS:
                InstalProps.Add(Instantiate(CoinsCell, CellObject.transform.position, Quaternion.identity, CellObject.transform));
                StartCoroutine(ScaleCells());
                break;
            case TypeCell.Crystal_214BS:
                InstalProps.Add(Instantiate(CrystalsCell, CellObject.transform.position, Quaternion.identity, CellObject.transform));
                StartCoroutine(ScaleCells());
                break;
        }
    }

    private IEnumerator OpenAllCells()
    {
        for (int i = countPush - 1; i < Group9Rows.Count; i++)
        {
            for (int j = 0; j < Group9Rows[i].GetComponent<Group4Cells_214BS>().Cells_214BS.Count; j++)
            {
                Group9Rows[i].GetComponent<Group4Cells_214BS>().Cells_214BS[j].transform.DOScale(1, 0.2f);
                Group9Rows[i].GetComponent<Group4Cells_214BS>().Cells_214BS[j].GetComponent<CellData_214BS>().GetComponent<Button>().interactable = false;
                if (Group9Rows[i].GetComponent<Group4Cells_214BS>().Cells_214BS[j].GetComponent<CellData_214BS>()._typeCell_214BS == TypeCell.Bomb_214BS)
                {
                    yield return new WaitForSeconds(0.2f);
                    InstalProps.Add(Instantiate(BombCell, Group9Rows[i].GetComponent<Group4Cells_214BS>().Cells_214BS[j].transform.position, Quaternion.identity, Group9Rows[i].GetComponent<Group4Cells_214BS>().Cells_214BS[j].transform));
                    //OpenCell(Group9Rows[i].GetComponent<Group4Cells>().Cells[j]);
                }
            }
        }
        StopCoroutine(OpenAllCells());
    }

    private IEnumerator ScaleCells()
    {
        if (countPush > 0)
        {
            for (int j = 0; j < Group9Rows[countPush - 1].GetComponent<Group4Cells_214BS>().Cells_214BS.Count; j++)
            {
                Group9Rows[countPush - 1].GetComponent<Group4Cells_214BS>().Cells_214BS[j].GetComponent<CellData_214BS>().GetComponent<Button>().interactable = false;
            }
        }

        if (countPush < Group9Rows.Count)
        {
            for (int j = 0; j < Group9Rows[countPush].GetComponent<Group4Cells_214BS>().Cells_214BS.Count; j++)
            {
                Group9Rows[countPush].GetComponent<Group4Cells_214BS>().Cells_214BS[j].transform.DOScale(1, 0.2f);
                yield return new WaitForSeconds(0.1f);
            }
            Group9Rows[countPush].SetActive(true);
        }
        StopCoroutine(ScaleCells());
    }


}

public enum TypeMiniGame
{
    Easy_214BS = 9,
    Hard_214BS = 18
}

public enum TypeCell
{
    Empty_214BS = 0,
    Bomb_214BS = 1,
    Coins_214BS = 2,
    Crystal_214BS = 3
}
