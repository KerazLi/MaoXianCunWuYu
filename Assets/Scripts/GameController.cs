using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameController : MonoBehaviour
{
    public static GameController _instance;
    //土地信息
    public GroundProperties _currentSelectGroundProperties;
    
    // Start is called before the first frame update
    private void Awake()
    {
        _instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsOnUI())
        {
            return;
        }
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit,1000))
        {
            if (hit.collider.CompareTag($"Ground"))
            {
                //print("Ground");
                _currentSelectGroundProperties = hit.collider.GetComponent<GroundProperties>();
                print(hit.collider.name);
                //print(_currentSelectGroundProperties.State);
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (_currentSelectGroundProperties!=null)
            {
                if (_currentSelectGroundProperties.State==0)
                {
                    //TODO:购买土地的提示框
                    BuyGroundWin._instance.Show();
                    print(0);
                }else if (_currentSelectGroundProperties.State==1)
                {
                    //显示建造窗口
                    print(1);
                }
            }
            else
            {
                print("_currentSelectGroundProperties is null" );
            }
        }
    }

    private bool IsOnUI()
    {
        bool isOnUI=EventSystem.current.IsPointerOverGameObject();
        return isOnUI;
    }
}
