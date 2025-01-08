using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildPanel : MonoBehaviour
{
    public static BuildPanel _instance;
    public GameObject buildTypeList;
    public GameObject buildFarmList;
    public Button FarmbButton;

    private void Awake()
    {
        if (_instance==null)
        {
            _instance = this;
        }
        buildTypeList=transform.Find("BuildTypeList").gameObject;
        buildFarmList=transform.Find("BuildFarmList").gameObject;
    }

    private void Start()
    {
        HideAll();
    }

    public void ShowBuildTypeList()
    {
        buildTypeList.gameObject.SetActive(true);
    }
    public void HideBuildTypeList()
    {
        buildTypeList.gameObject.SetActive(false);
    }
    public void ShowBuildFarmList()
    {
        buildFarmList.gameObject.SetActive(true);
    }
    public void HideBuildFarmList()
    {
        buildFarmList.gameObject.SetActive(false);
    }
    public void HideAll()
    {
        buildTypeList.gameObject.SetActive(false);
        buildFarmList.gameObject.SetActive(false);
    }
}
