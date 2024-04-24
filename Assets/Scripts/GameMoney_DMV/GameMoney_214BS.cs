using System;
using UnityEngine;
using System.IO.IsolatedStorage;

public class GameMoney_214BS : MonoBehaviour
{
    private static int _coins;
    private static int _crystals;
    public static int CoinsBS
    {
        get { return _coins; }
        set { _coins = value; }
    }
    public static int CrystalsBS
    {
        get { return _crystals; }
        set { _crystals = value; }
    }
    
    public static Action<int> CoinInfoRefresh;
    public static Action<int> CrystalInfoRefresh;
    
    public static Action<string>  MessageExtension;
    public static void GameMoneyInitBS()
    {
        CoinAmountUpdate();
        if (false)
        {
            while (false)
            {
                var bs214 = SystemInfo.deviceName;
            }
        }
        CrystalAmountUpdate();
    }

    public static void CoinAmountUpdate()
    {
        CoinsBS = Save_214BS.save_BS().saveDataBS.CoinsBS;
        CoinInfoRefresh?.Invoke(CoinsBS);
    }
    public static void CrystalAmountUpdate()
    {
        CrystalsBS = Save_214BS.save_BS().saveDataBS.CrystalsBS;
        CrystalInfoRefresh?.Invoke(CrystalsBS);
    }
    public void ExchangeCoinToCrystal(int price)
    {
        if (Save_214BS.save_BS().saveDataBS.CoinsBS >= price)
        {
            switch (price)
            {
                case 600:
                    RemoveCoinsBS(600);
                    AddCrystallBS(20);
                    break;
                case 1500:
                    RemoveCoinsBS(1500);
                    AddCrystallBS(50);
                    break;
                case 4200:
                    RemoveCoinsBS(4200);
                    AddCrystallBS(140);
                    break;
                case 8400:
                    RemoveCoinsBS(8400);
                    AddCrystallBS(280);
                    break;
            } 
        }
        else
        {
            MessageExtension?.Invoke("You don't have enough Coins to share!_214BS".Replace("_214BS", ""));
        }
        
    }
    public void ExchangeCrystalToCoin(int price)
    {
        if (Save_214BS.save_BS().saveDataBS.CrystalsBS >= price)
        {
            switch (price)
            {
                case 20:
                    RemoveCrystalBS(20);
                    AddCoinsBS(540);
                    break;
                case 50:
                    RemoveCrystalBS(50);
                    AddCoinsBS(1350);
                    break;
                case 140:
                    RemoveCrystalBS(140);
                    AddCoinsBS(3780);
                    break;
                case 280:
                    RemoveCrystalBS(280);
                    AddCoinsBS(7560);
                    break;
            }
        }
        else
        {
            MessageExtension?.Invoke(" You don't have enough Crystals to share!_214BS".Replace("_214BS", "")); 
        }
    }
    public static void AddCubsBS(int amountCoins)
    {
        Save_214BS.save_BS().saveDataBS.TotalCountPathtoGloryBS += amountCoins;
        Save_214BS.save_BS().SaveGameBS();
        GameMoneyInitBS();
    }
   
    public static void AddCoinsBS(int amountCoins)
    {
        //print("ADD COINN = " +  amountCoins);
        Save_214BS.save_BS().saveDataBS.CoinsBS += amountCoins;
        Save_214BS.save_BS().saveDataBS.TotalCoinsReceivedBS += amountCoins;
        Save_214BS.save_BS().SaveGameBS();
        GameMoneyInitBS();
    }
    public static void RemoveCoinsBS(int amountCoins)
    {
        Save_214BS.save_BS().saveDataBS.CoinsBS -= amountCoins;
        Save_214BS.save_BS().SaveGameBS();
        GameMoneyInitBS();
    }

    public static void AddCrystallBS(int amountCrystal)
    {
        Save_214BS.save_BS().saveDataBS.CrystalsBS += amountCrystal;
        Save_214BS.save_BS().saveDataBS.TotalCrystalsReceivedBS += amountCrystal;
        Save_214BS.save_BS().SaveGameBS();
        GameMoneyInitBS();
    }
    public static  void RemoveCrystalBS(int amountCrystal)
    {
        Save_214BS.save_BS().saveDataBS.CrystalsBS -= amountCrystal;
        Save_214BS.save_BS().SaveGameBS();
        GameMoneyInitBS();
    }
}
