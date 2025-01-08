using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProp : MonoBehaviour
{
    public static PlayerProp _instance;

    private int _coin = 1000;

    public int Coin
    {
        get => _coin;
        set
        {
            _coin = value;
            //刷新金币UI
            PlayerPropUI._instace.CoinUpdate();
        }
        
    }

    private void Awake()
    {
        if (_instance==null)
        {
            _instance = this;
        }
        
    }
}
