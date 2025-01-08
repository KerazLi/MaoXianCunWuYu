using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyGroundWin : MonoBehaviour
{
    public static BuyGroundWin _instance;
    private Button buyButton;
    private Button closeButton;
    

    private void Awake()
    {
        if (_instance==null)
        {
            _instance = this;
        }
        buyButton=transform.Find("BuyButton").GetComponent<Button>();
        closeButton=transform.Find("CloseBtn").GetComponent<Button>();
        Hide();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        buyButton.onClick.AddListener(BuyGround);
        closeButton.onClick.AddListener(Hide);
        Hide();
    }
    
    
    public void Show()
    {
        gameObject.SetActive(true);
    }

    private void BuyGround()
    {
        if (PlayerProp._instance )
        {
            if (GameController._instance)
            {
                if (PlayerProp._instance.Coin>=GameController._instance._currentSelectGroundProperties.price)
                {
                    //购买土地
                    PlayerProp._instance.Coin -= GameController._instance._currentSelectGroundProperties.price;
                    //变更土地状态
                    GameController._instance._currentSelectGroundProperties.State = 1;
                    print("购买成功");
                    Hide();
                }
                else
                {
                    Tip._instance.Show();
                } 
            }else 
            {
                print("GameController._instance is null");
            }
            
        }
        else
        {
            print("PlayerProp._instance  is null");
        }


    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
