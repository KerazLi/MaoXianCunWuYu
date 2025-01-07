using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //土地信息
    private GroundProperties _groundProperties;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit,1000))
        {
            if (hit.collider.CompareTag($"Ground"))
            {
                //print("Ground");
                _groundProperties = hit.collider.GetComponent<GroundProperties>();
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (_groundProperties!=null)
            {
                if (_groundProperties.State==0)
                {
                    //TODO:购买土地的提示框
                    print(0);
                }else if (_groundProperties.State==1)
                {
                    //显示建造窗口
                    print(1);
                }
            }
        }
    }
}
