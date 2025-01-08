using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager _instance;
    public GameObject BuyGroundWin;
    public GameObject BuildPanel;
    public GameObject PlayerPropUI;
    public GameObject Tip;

    private void Awake()
    {
        if (_instance==null)
        {
            _instance = this;
        }
    }

    private void Start()
    {
        HideAll();
    }

    public void HideAll()
    {
        BuyGroundWin.SetActive(false);
        //BuildPanel.SetActive(false);
        //PlayerPropUI.SetActive(false);
        Tip.SetActive(false);
    }
    public void ShowBuyGroundWin()
    {
        //HideAll();
        BuyGroundWin.SetActive(true);
    }
    /*public void ShowBuildPanel()
    {
        //HideAll();
        BuildPanel.SetActive(true);
    }*/
    public void ShowPlayerPropUI()
    {
        //HideAll();
        PlayerPropUI.SetActive(true);
    }
    public void ShowTip()
    {
        //HideAll();
        Tip.SetActive(true);
    }

}
