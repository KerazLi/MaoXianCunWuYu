using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundProperties : MonoBehaviour
{
    //土地状态 0 未购买，1 购买,2 建造
    
    public int state = 0;
    public int price = 200;
    private GameObject hasBuyRes;
    private GameObject InitPrefab;

    private void Awake()
    {
        hasBuyRes = Resources.Load<GameObject>("Prefab/HasBuy")?? throw new ArgumentNullException("Resources.Load<GameObject>(\"Prefab/HasBuy\")");
        InitPrefab = transform.Find("InitPrefab").gameObject;
    }

    public int State
    {
        get
        {
            return state;
        }
        set
        {
            state = value;
            StateChange();
        }
    }

    void StateChange()
    {
        if (State==1)
        {
            //hasBuyRes = Resources.Load<GameObject>("Prefab/HasBuy") ?? throw new ArgumentNullException("Resources.Load<GameObject>(\"Prefab/HasBuy\")");
            GameObject HasBuildGobj = Instantiate(hasBuyRes, GameController._instance._currentSelectGroundProperties.transform, true);
            HasBuildGobj.transform.localPosition = new Vector3(0, 0.5f, 0);
            HasBuildGobj.transform.name = "HasBuy";
            InitPrefab.SetActive(false);
        }
        
    }

    
    // Start is called before the first frame update
}
