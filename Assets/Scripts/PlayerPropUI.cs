using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerPropUI : MonoBehaviour
{
    public static PlayerPropUI _instace;
    public TMP_Text coinText;

    private void Awake()
    {
        if (_instace==null)
        {
            _instace = this;
        }
        
    }

    private void Start()
    {
        CoinUpdate();
    }

    public void CoinUpdate()
    {
        coinText.text = PlayerProp._instance.Coin.ToString();
    }
}
