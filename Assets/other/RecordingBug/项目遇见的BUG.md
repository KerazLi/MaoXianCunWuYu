# 项目遇见的BUG

### 1.购买土地点击购买时出现空指针问题

>解决方法：通过判断语句确定GameController脚本的单例模式未实例化出现空指针异常
>
>```c#
>//GameController
>	public static GameController _instance;
>     
>    // Start is called before the first frame update
>    private void Awake()
>    {
>        _instance = this;
>    }
>```
>
>```C#
>//BuyGroundWin => BuyGround()
>if (PlayerProp._instance )
>        {
>            if (GameController._instance)
>            {
>                if (PlayerProp._instance.Coin>=GameController._instance._currentSelectGroundProperties.price)
>                {
>                    //购买土地
>                    PlayerProp._instance.Coin -= GameController._instance._currentSelectGroundProperties.price;
>                    //变更土地状态
>                    GameController._instance._currentSelectGroundProperties.State = 1;
>                    print("购买成功");
>                    Hide();
>                }
>                else
>                {
>                    //TODO:出现提示金币不足
>                    print("金币不足");
>                } 
>            }else 
>            {
>                print("GameController._instance is null");
>            }
>            
>        }
>        else
>        {
>            print("PlayerProp._instance  is null");
>        }
>```
>

#### 2.土地选择框根据代码无法显示土地选择框

>原因：子物体的Pos和父物体Pos一样
>
>解决：子物体的Pos的Y轴应该为1.1才能显示