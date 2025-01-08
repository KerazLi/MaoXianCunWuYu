using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundProperties : MonoBehaviour
{
    //土地状态 0 未购买，1 购买,2 建造
    
    public int state = 0;

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
            GameObject hasBuyRes = Resources.Load<GameObject>("Prefab/HasBuy") ?? throw new ArgumentNullException("Resources.Load<GameObject>(\"Prefab/HasBuy\")");
            GameObject HasBuildGobj = Instantiate(hasBuyRes, GameController._instance._currentSelectGroundProperties.transform, true);
            HasBuildGobj.transform.localPosition = new Vector3(0, 0.5f, 0);
            HasBuildGobj.transform.name = "HasBuy";
        }
        
    }

    public int price = 200;
    // Start is called before the first frame update
}
