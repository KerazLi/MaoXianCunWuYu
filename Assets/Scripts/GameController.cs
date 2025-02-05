using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameController : MonoBehaviour
{
    public static GameController _instance;
    //土地信息
    public GroundProperties _currentSelectGroundProperties;
    private GameObject SelectGroundTip;
    
    // Start is called before the first frame update
    private void Awake()
    {
        if (_instance==null)
        {
            _instance = this;
        }
        SelectGroundTip = GameObject.Find("SelectTip");
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
                SelectGroundTip.transform.position = hit.collider.transform.position;
                SelectGroundTip.transform.localScale = new Vector3(hit.collider.transform.localScale.x / 3, 1,
                    hit.collider.transform.localScale.z / 3);

                //print(_currentSelectGroundProperties.State);
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (_currentSelectGroundProperties!=null)
            {
                if (_currentSelectGroundProperties.State==0)
                {
                    //BuyGroundWin._instance.Show();
                    UIManager._instance.ShowBuyGroundWin();
                                                                             
                    print(0);
                }else if (_currentSelectGroundProperties.State==1)
                {
                    //UIManager._instance.ShowBuildPanel();
                    //显示建造窗口
                    
                    BuildPanel._instance.ShowBuildTypeList();
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
