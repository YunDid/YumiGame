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

> `U3D Document : Linearly interpolating is finding a value that is some percentage between two given values.`
>
> 线性插值可以找到两个值之间的某个过渡值，该值在两者之间且满足一定的百分比
>
> `U3D Document : The third parameter in each case is still a float representing how much to interpolate.`
>
> 第三个 Percentage 用于表示该如何插入
>
> `注意:`
>
> 1. lerp 函数仅仅是得到两值之间的某插值，注意是得到，若需要使用还需要将该函数返回值作为相应值类型变量进行处理，例如实现光照颜色随时间的平滑过渡，需要使用lerp得到过渡值并将该值赋值给光照颜色属性

- Mathf.Lerp (float From, float To, float Percentage);

  > 可用于两值之间的线性插值
  >
  > `U3D Document : Under some circumstances Lerp functions can be used to smooth a value over time.`
  >
  > 该func有时还可以用于使某值/属性随时间平滑变化，即将From设置为该值/属性，To设置为期望不断逼近的某值，Percentage设置插入方式，若不想随帧率插入，可将该 Percentage*Time.deltaTime，使其随时间以s为单位平滑变化

- Vector3.Lerp (Vector3 From, Vector3 To, float Percentage);

  > 可用于两向量之间的线性插值

- Color.Lerp (Color From, Color To, float Percentage);

  > 可用于两颜色之间的线性插值


----------

**Questions: **

- Render 与 Renderer ？
- GetKeyDown 与 GetKey ？

------------------

# Destroy / 销毁

> `U3D Document : The Destory function can be used to remove game objects or components from game objects at run time.`s
>
> Destroy 函数可以用于 运行时销毁 场景中的游戏对象或者游戏对象上的某组件，其第二个参数可以设置相应的延时
>
> `注意: `
>
> 1. 销毁游戏对象的同时，其组件也将销毁
> 2. 脚本可通过 gameObject 直接获取其所附加的游戏对象的引用

```c# 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDestory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //销毁本游戏对象
        if (Input.GetKeyDown(KeyCode.Space)) {
            Destroy(gameObject, 1f);
        }

        //销毁其他游戏对象
        if (Input.GetKeyDown(KeyCode.A))
        {
            Destroy(other, 1f);
        }

        //销毁组件
        if (Input.GetKeyDown(KeyCode.B))
        {
            Destroy(GetComponent<Renderer>(), 1f);
        }
    }

    public GameObject other;
}
```

# GetButton 和 GetKey / 获取输入

> Unity 的输入不预先设置轴映射和操作映射来区别按下与持续按下，而是通过三个函数判断输入状态，返回 true or false
>
> Button 与 Key 的区别在于其使用方式，都可获取输入状态，但是 key 要求参数使用指定按键 KeyCode，而 button 可以通过 InputManager 自定义输入，参数使用 ButtonName 即可

- GetKeyDown / GetButtonDown

  > 按下的那帧为true，其余为false

- GetKey / GetButton

  > 持续按下的所有帧均为true，包括按下那一帧

- GetKeyUp /GetButtonUp

  > 松开按键的那一帧为true，其余为false

# GetAxis / 获取轴

> 类似于 GetButton/GetKey，但是其返回值不是 bool 类型而是介于[-1,1]之间的 float 类型，正向驱动轴的按钮按下将使轴趋向于1
>
> 即按下该轴绑定的按钮，该轴便会有值，并且能双向驱动，当松开时，该轴的值将恢复0

- Gravity : 松开按钮时轴值恢复0的速度
- Sensitivity : 按下轴时轴趋向 -1 or 1 的速度
- Dead : 使用操作杆时设置，忽视某些细微操作导致的误触，可设置可忽略的范围
- Snap : 若勾选，则按下对应反方向的按钮时，轴将重置为0，若未勾选，按下反方向的按钮时轴值从当前值开始变化

```c# 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float axis = Input.GetAxis("Horizontal");
        transform.position = new Vector3(axis, transform.position.y, transform.position.z);
    }
}
```



# OnMouseDown / 鼠标点击

> OnMouseDown 函数用于处理于 GUI控件 或者碰撞体上的点击

```C# 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(-transform.forward * 500f);
        GetComponent<Rigidbody>().useGravity = true;
    }
}

```

# GetComponent / 获取组件

> 可通过 GetComponent\<Type> 函数获取某游戏对象上的组件并设置其属性
>
> `注意:`
>
> 1. 若组件与获取组件的脚本附加于同一个游戏对象上，则可以直接 GetComponent\<Type>
> 2. 若需要获取的组件附加于其他游戏对象上，则需要先获取对应游戏对象，再通过该游戏对象调用 GetComponent\<Type> 方法
> 3. GetComponent\<Type> 方法很消耗性能，因此一般仅在初始化时调用一次获取组件，而不逐帧调用

```c# 
using UnityEngine;
using System.Collections;

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject otherGameObject;


    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxCol;


    void Awake()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }


    void Start()
    {
        boxCol.size = new Vector3(3, 3, 3);
        Debug.Log("The player's score is " + anotherScript.playerScore);
        Debug.Log("The player has died " + yetAnotherScript.numberOfPlayerDeaths + " times");
    }
}
```



# DeltaTime / 时间增量

> `U3D Document : The interval in seconds from the last frame to the current one (Read Only).`
>
> Time.deltaTime 为当前帧与上一帧的间隔时间，以秒/s为单位，只读不可修改 
>
> `U3D Document : An important thing to remember when handling time-based actions like this is that the game’s framerate is not constant and neither is the length of time between Update function calls.`
>
> 以时间为基准的运动，不能逐帧实现，因为游戏帧率不是恒定的，即每一次 update 调用的时间间隔不是恒定的，逐帧实现的运动将导致运动不均匀
>
> `U3D Document : The solution is to scale the size of the movement by the frame time which you can read from the Time.deltaTime property.`
>
> 能够使得运动更均匀顺滑的解决方案是通过 Time.deltaTime 属性值来缩放运动距离大小，随着帧率的变化，Time.deltaTime 也将随之变化，因此对象的移动速度将保持不变

```c# 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    public float speed = 0.0000000000005f;
}

```



# Instantiate / 运行时实例化

> 以发射器为例，可以完成运行时创建预制件的克隆体
>
> `注意:`
>
> 1. 预制件创建的初始位置一般通过 barried 来设置，barried 为一个空游戏对象用于占位子弹发射位置
> 2. 子弹的销毁不在if中完成，而是将销毁脚本附加于预制件上
> 3. 可以使用 Launcher 空游戏对象用于在层级中管理枪支与barried，并将发射脚本置于 Launcher 上

```c# 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Bullet = Instantiate(Bullet, barried.position, barried.rotation);
            Bullet.AddForce(barried.up * 500);
        }
    }

    public Rigidbody Bullet;
    public Transform barried;
}
```



# Invoke / 延时调用

> Invoke 可以完成某个方法的延时调用来完成对延时有要求的函数调用系统

- Invoke(string FuncName,float DelayTime)

  > 可以完成 FuncName 的延时调用，以秒/s为单位，DelayTime秒后调用

- InvokeRepeating(string FuncName,float DelayTime,float IntervalTime)

  > 可以完成 FuncName 的延时调用，以秒/s为单位，DelayTime秒后调用，并且每隔IntervalTime秒重复调用

- CancelInvoke(string FuncName)

  > 可以关闭对 FuncName 延时重复调用

----------

2022/1/6 15:43

----------

# Properties / 属性

> 通过属性访问器来访问成员而不是通过 public 来访问的优势在于
>
> 1. 可是使该成员 只读/只写，省去相应访问器即可
> 2. 访问器中可添加一些方法

```c# 
using UnityEngine;
using System.Collections;

public class Player
{
    //成员变量可以称为字段
    private int experience;

    //Experience 是一个基本属性
    public int Experience
    {
        get
        {
            //其他一些代码
            return experience;
        }
        set
        {
            //其他一些代码
            experience = value;
        }
    }
```



# Generics / 泛型

> where 关键字指定泛型类型约束

- Generics  Class

  > public class ClassName\<T> {}

- Generics  Function

  > public returnType FuncName\<T> () {}

- Generic Constraint / 泛型约束

  > 区别于c++，c++仅仅起暗示作用并不会实际约束，而c#会对期望的类型作出约束
  
  public class ClassName\<T> where T : ConstraintList {}
  
  public returnType FuncName\<T> ()  where T : ConstraintList {}
  
  ConstraintList / 约束列表 : 
  
  1. Struct T类型必须为值类型
  2. new() T类型必须包含无参的公共构造函数，构造函数约束需要出现在约束列表的最后
  3. class T类型必须为引用类型
  4. ClassName T类型必须为 ClassName 类型或派生自 ClassName 基类类型
  5. InterfaceName T类型必须已实现 InterfaceName 接口

# Member Hiding / 成员隐藏

> 在进行上转型时，为了能够调用父类的方法或属性，因此将子类的同名方法或属性前加 new 关键字进行隐藏，正常通过子类引用调用时并无影响，但是在上转型时，将隐藏子类的成员，而调用父类的成员

```c# 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fasther {

    public int para = 10;

    public virtual void SayHello() {
        Debug.Log("Hello! Father!");
    }
}

public class Childern : Fasther
{
    new public void SayHello()
    {
        Debug.Log("Hello! Children!");
    }
}

public class Inheritated : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Fasther father = new Childern();
        father.SayHello();

        Childern children = new Childern();
        children.SayHello();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
```

---------------

**Questions:**

1. new 关键字隐藏的意义是什么？没有new在上转型时，不仍然会调用父类的方法吗，为何需要new呢？
2. virtual 需要搭配 override ，只有其中一个将表示什么意思

---------------

# Overriding / 重写

> c#中重写需要将父类被重写的方法添加 virtual 关键字声明为虚函数，子类添加 override 关键字指明重写

# Interface / 接口

> c#接口也有泛型，实现接口时使用 : + 接口 即可

```c# 
using UnityEngine;
using System.Collections;

//This is a basic interface with a single required
//method.
public interface IKillable
{
    void Kill();
}

//This is a generic interface where T is a placeholder
//for a data type that will be provided by the 
//implementing class.
public interface IDamageable<T>
{
    void Damage(T damageTaken);
}
```



# Extension Methods / 拓展方法

> Extension Methods 拓展方法可以不创建某个类的派生类，也不更改某个类，但是为该类"新增"了公用的方法
>
> `注意:`
>
> 1. 拓展方法需要有一个静态类作容器
> 2. 拓展方法本身也为静态方法，但是可以像实例方法一样调用
> 3. 拓展方法的参数指定拓展的类型，前需要有关键字this
> 4. 拓展方法仍不可访问拓展类的私有成员

```c# 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extend : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform trans = GetComponent<Transform>();
        trans.Logout();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public static class Container {
    public static void Logout(this Transform trans) {
        Debug.Log("Tranform 类中被\"添加\"了这个方法啦！");
    } 
}
```



# Lists and Dictionaries / 列表与字典

> List 为动态数组，以泛型方式创建，并制定元素类型，提供Add，Remove，Sort，Clear等接口
>
> Dictionarie 类似于map，以键值对形式存储元素
>
> `注意:`
>
> 1. 需要先引用命名空间 System.Collections.Generic;

```c# 
// List
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SomeClass : MonoBehaviour
{
    void Start () 
    {
        //This is how you create a list. Notice how the type
        //is specified in the angle brackets (< >).
        List<BadGuy> badguys = new List<BadGuy>();

        //Here you add 3 BadGuys to the List
        badguys.Add( new BadGuy("Harvey", 50));
        badguys.Add( new BadGuy("Magneto", 100));
        badguys.Add( new BadGuy("Pip", 5));

        badguys.Sort();

        foreach(BadGuy guy in badguys)
        {
            print (guy.name + " " + guy.power);
        }

        //This clears out the list so that it is
        //empty.
        badguys.Clear();
    }
}

// Dictionarie

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SomeOtherClass : MonoBehaviour 
{
    void Start ()
    {
        //This is how you create a Dictionary. Notice how this takes
        //two generic terms. In this case you are using a string and a
        //BadGuy as your two values.
        Dictionary<string, BadGuy> badguys = new Dictionary<string, BadGuy>();

        BadGuy bg1 = new BadGuy("Harvey", 50);
        BadGuy bg2 = new BadGuy("Magneto", 100);

        //You can place variables into the Dictionary with the
        //Add() method.
        badguys.Add("gangster", bg1);
        badguys.Add("mutant", bg2);

        BadGuy magneto = badguys["mutant"];

        BadGuy temp = null;

        //This is a safer, but slow, method of accessing
        //values in a dictionary.
        if(badguys.TryGetValue("birds", out temp))
        {
            //success!
        }
        else
        {
            //failure!
        }
    }
}
```



-----

2022/1/6 21:48

