# Some Keys for Programming / 关键点

---------------
# The Current Progress / 当前进度

- Unity初级编程 - 中级编程 / ing
- 动画系统demo实践 完成模型导入-> 动画绑定 -> 状态机组织动画
- 工具 fbx -> motiondate -> 中间数据
- ue4状态机 + AI + 行为树
- 着手AIAnimation框架，着手动画系统的改写
-----------

# ForeachLoop / 循环

``` c#
using UnityEngine;
using System.Collections;

public class ForeachLoop : MonoBehaviour 
{   
    void Start () 
    {
        string[] strings = new string[3];
        
        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";
        
        foreach(string item in strings)
        {
            print (item);
        }
    }
}
```

# Awake and Start / 初始化方法

> 执行前提 : 必须将含该方法的脚本作为组件附加至游戏对象上，否则不会执行

- Awake : 在加载场景时执行且仅执行一次，若该脚本组件已附加但是未被激活，仍将执行

- Start : 在第一帧更新之前执行且仅执行一次，已附加的组件必须为激活态才会执行

# FixUpdate and Update / 更新方法

- FixUpdate : 以固定时间间隔调用，每调用一次均完成一次物理计算，因此物理运动需要在此更新
- Update : 下一帧执行前调用，但各帧的时间间隔不一，因此时间间隔不固定，一些简单非物理运动等可以在此更新

```c# 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        print("FixedUpdate deltaTime : " + Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        print("Update deltaTime : " + Time.deltaTime);
    }
}
```



# Enabling and Disabling Components / 启用禁用组件

- `ComponentName.enabled`属性来启用或禁用组件

```c# 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enabled : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)) {
            render.enabled = !render.enabled;
        }
    }

    public MeshRenderer render;
}
```



# Activating GameObjects / 激活游戏对象

- activeInHierarchy - 继承关系下孩子活跃状态的判断，当父对象设置为不活跃时，子对象仍活跃但是于Hierarchy为不活跃，即不会在场景中显示
- activeSelf - 判断游戏对象的活跃状态
- SetActive - 设置游戏对象的活跃状态



# Translate and Rotate func / 变换与旋转方法

> transform 为 Transform 类的一个实例，可直接使用该实例下的变换方法 (不好意思，暂不深究，先笼统解释下=-=)

```c# 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            //给该对象一个向前的速度向量，参数结果仍然为一个Vector3向量
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //类似于给该对象绕up所在的轴一个转速
            transform.Rotate(-Vector3.up, turnSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //给该对象一个向后的速度向量，参数结果仍然为一个Vector3向量
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }

    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

}
```



# Camera LookAt / 朝向

> transform 实例下提供 LookAt 方法设置所附加对象的朝向，但是仅仅是朝向，不会跟随移动

```c# 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
    }

    public Transform target;
}

```



-----------

2022/1/5 21:50

# Linear Interpolation / 线性插值

