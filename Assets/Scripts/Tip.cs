using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tip : MonoBehaviour
{
    public static Tip _instance;
    private TMP_Text Content;
    private Button closeBtn;

    private void Awake()
    {
        if (_instance==null)
        {
            _instance = this;
        }
        Content = transform.Find("Content").GetComponent<TMP_Text>();
        closeBtn = transform.Find("CloseBtn").GetComponent<Button>();
        Hide();
    }
    public void ShowNotEnoughMoney()
    {
        Content.text = "金币不够";
        closeBtn.onClick.AddListener(Hide);
        gameObject.SetActive(true);
    }

    public void Show()
    {
        ShowNotEnoughMoney();
    }

    void Hide()
    {
       gameObject.SetActive(false); 
    }
}
