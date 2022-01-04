# AIAnimations

## 初识问题汇总

1. ~~动画数据？~~
2. ~~unity3D已有的内置算法已经可实现补间动画了吗？~~
3. ~~IK系统？~~
4. fbx/animation 动画文件？ 模型文件
5. tensorflow算法训练 训练什么？输入输出？预期产出？
6. 补间动画？ 动画融合与向量矫正？物理反馈？
7. Siggraph2019？

## 计划学习路线

- Unity3D基础 / √
- Unity3D动画系统 / √
- Unity3D模型 + 模型导出格式 / ing
- AIAnimations拓展

# Unity3D 编辑器

## Tools

> 播放/暂停/步进

## Scene / Camera

> 显示视图

## Project

> 资源库

## Hierarchy

> scene场景中的各对象的层级关系，注意存在属性继承

## Inspector

> 属性

## Status

> Unity3D进程，输出，调试信息

# Unity3D基础概念

## GameObjects / 游戏对象

>  `U3D Document : They do not accomplish much in themselves but they act as containers for Components, which implement the functionality.`
>
> GameObject是u3d中所有对象的实体容器，可以认为每一个对象(包括角色，场景，特效)均由一个GameObject形成
>
> 但是仅由GameObject无法使该对象具有相应的功能和属性，需要向该GameObject添加一系列组件来满足对特性行为/属性的需求
>
> GameObject有一个默认的不可移除的组件为Transform组件，该组件使该GameObject具有了位置与方向的属性

- activeInHierarchy - 继承关系下孩子活跃状态的判断，当父对象设置为不活跃时，子对象仍活跃但是于Hierarchy为不活跃
- activeSelf - 判断游戏对象的活跃状态
- SetActive - 设置游戏对象的活跃状态

## Component / 组件

> `U3D Document : Components define the behaviour of that GameObject.`
>
> 组件定义游戏对象的行为，即游戏对象的具体行为需要由相应的组件支持，包括属性

## Scripts / C#脚本

> `U3D Document : In technical terms, any script you make compiles as a type of **component**, so the Unity Editor treats your script like a built-in component. You define the members of the script to be exposed in the Inspector, and the Editor executes whatever functionality you’ve written.`
>
> 脚本可用来自动响应玩家的输入并控制场景中游戏对象的行为，游戏过程中的事件
>
> 资源库中创建的脚本被编译为组件，可以为某个游戏对象添加该组件，编译器将对该对象执行该脚本实现你脚本编写的行为

## Tag / 标签

> `U3D Document : Tags help you identify GameObjects for scripting purposes. They ensure you don’t need to manually add GameObjects to a script’s exposed properties using drag and drop, thereby saving time when you are using the same script code in multiple GameObjects.`
>
> 将GameObject分组用于简化C#脚本操作，无需将具体对象引入到脚本的公共区域进行逻辑操作，仅需通过GameObject所属的标签来统一操作
>
> GameObject.FindWithTag() 可按标签来查找对象

## Layer / 层

> `U3D Document : Layers in Unity define which GameObjects can interact with different features and one another.`
>
> 将GameObject分组用于各组件的相互交互
>
> Camera : 仅渲染场景的一部分
>
> Light : 仅照亮场景的某些部分
>
> Collision : 使用 Layer Collision Matrix(层碰撞矩阵) 来管理游戏对象之间的碰撞

## Rotation and Orientation / 旋转与方向

> 欧拉角 + 四元数

- - -
**Questions :**

- 欧拉角 + 四元数
-  世界坐标与相对坐标？如何调整一个游戏对象的世界坐标
- 全局坐标/局部坐标？

2021/12/22 - 2021/12/23 

- - -

# Unity3D Scripts / 脚本

## Basic Code Structure / 初始结构

```c# 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Class Name : 需要与脚本文件名相同否则该脚本无法作为组件附加到游戏对象中
    MonoBehaviour : 内置类，用于规范可附加到游戏对象中的组件类的行为标准

    注意: 
    	1.脚本对象的构造由编译器编译时完成，但是脚本文件类的构造函数为运行时构造，所以不要再为其设置构造函数进行初始化了 
    	2.当类继承自MonoBehaviour时使用构造函数会使构造函数在不需要的时间被调用，并且在许多情况下可能会导致 Unity 崩溃
 */

public class QuickStart : MonoBehaviour
{
    //Start is called before the first frame update
    void Start()
    {
        //进行所有成员初始化的理想位置
        //Start()函数于 before the first frame update 但是于运行时调用
    }

    //Update is called once per frame
    void Update()
    {
        //处理游戏对象的帧更新
        //响应事件，随时间推移需要处理的任何事件，任何行为
    }

    public int LookatMe; //仅public成员再Inspector面板中可见且可操作
}

```

## Instantiating Prefabs at run time / 运行时实例化预制件

> 工厂模式来创建对象，通过Instantiate接口函数完成运行时对GameObject引用的赋值，即完成对象的创建

```c# 
//Instantiate实例化
TypeOfPrefeb reTurnReference = Instantiate(Prefeb, new Vector3(0, 0, 0), Quaternion.identity);
```

### First Example - The Wall

**场景描述**

> 需要使用基本预制件构造一堵墙，即通过基本mesh构件逐行循环构造形成一堵墙
>
> 但是mesh可以由不同的GameObject类型组成，如何做到不需要更改代码？随心所欲的更改该墙的基本构件的类型呢？
>
> 通过Instantiate接口函数使用PreFab引用创建对象，你需要做的便只需要运行时更替该引用的实际实体即可，该墙的脚本无需更改

```c# 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int y = 0; y < height; ++y)
        {
            //固定height逐行构建
            for (int x = 0; x < width; ++x)
            {
                //通过引用构建对象，引用实体于运行时给定
                Instantiate(block, new Vector3(x, y, 0), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public GameObject block; //墙基本构件的引用
    public int width = 10; //墙宽
    public int height = 4; //墙高
}

```

### Second Example - Fire

**场景描述:**

> 欲实现开火效果
>
> - 子弹需要根据用户的的实际操作于运行时生成
> - 子弹发生碰撞时的粒子效果需要于运行时生成
> - 被子弹射中的对象需要由完美态到破损态，GameObject的实体替换需要由运行时完成
>
> 通过Instantiate接口函数使用PreFab引用创建对象，你需要做的便只需要运行时指定/更替该引用的实际实体即可，无需对代码作出修改

```c# 
//子弹
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    // This script launches a projectile prefab by instantiating it at the position
    // of the GameObject on which it is placed, then then setting the velocity
    // in the forward direction of the same GameObject.    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //子弹对象的创建
            Rigidbody p = Instantiate(projectile, transform.position, transform.rotation);
            //为子弹赋予一个速度向量
            p.velocity = transform.forward * speed;
        }
    }
    
    public Rigidbody projectile; //设置为刚体防止赋予实体时类型错误
    public float speed = 4; //速率
}


//完美态 -> 破损态
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WreckOnCollision : MonoBehaviour
{
    // Update is called once per frame
    void OnCollisionEnter()
    {
        Destroy(gameObject);
        //wreckedVersion需要指定为一个破损态的GameObject
        Instantiate(wreckedVersion,transform.position,transform.rotation);
    }
    
    public GameObject wreckedVersion;
}

```

## Event Functions / 事件函数

> `U3D Document : These functions are known as event functions since they are activated by Unity in response to events that occur during gameplay.`
>
> 脚本区别于程序，程序会一直持续执行直到其执行完毕，但是脚本不是，脚本依附于其包含的事件函数，当特定的事件发生时，会由相应的事件函数作出响应处理，这是u3d会暂时将控制权转交给相应的脚本，当该事件处理完毕，脚本将马上交还控制权

### Regular Update Events

> `U3D Document : A key concept in games programming is that of making changes to position, state and behavior of objects in the game just before each frame is rendered.`
>
> 游戏类似于动画，需要逐帧渲染，这要求在下一帧渲染前对游戏对象的位置,状态,行为等属性作出改变

#### Update()

> `U3D Document : Update is called before the frame is rendered and also before animations are calculated.`
>
> 1. before the frame is rendered. 在下一帧被渲染之前被调用
> 2. before animations are calculated. 在计算动画之前

#### FixedUpdate()

> `U3D Document : FixedUpdate is called just before each physics update. Since the physics updates and frame updates do not occur with the same frequency, you will get more accurate results from physics code if you place it in the FixedUpdate function rather than Update.`
>
> 1. before each physics update. u3d物理系统的更新类似于帧更新，均为离散逐步更新，但是物理帧更新与帧更新的频率不同，FixedUpdate()对物理的更新更准确

#### LateUpdate()

> `U3D Document : LateUpdate function can be used for the situation that to be able to make additional changes at a point after the Update and FixedUpdate functions have been called for all objects in the scene and after all animations have been calculated. `
>
> 1. after the Update and FixedUpdate functions have been called. 在Update()和FixedUpdate()被调用之后，作出额外的操作
> 2. after all animations have been calculated. 在所有动画计算完毕之后作出额外的操作
>
> 例如相机需要实时朝向目标对象，但是相机方向的调整必须在目标对象位置作出变动之后update()之后，再进行调整，也就是说相机必须实时朝向目标对象改动后的位置

### Initialization Events

#### Awake()

> `U3D Document : The Awake function is called for each object in the scene at the time when the scene loads`
>
> 1. when the scene loads. 在场景加载时，为场景中的每个对象调用Awake()使其能够初始化

#### Start()

> `U3D Document : The Start function is called before the first frame or physics update on an object.`
>
> 1. before the first frame or physics update on an object. 在对象首次执行帧更新or物理更新之前需要被调用进行的初始化

`注意:`

1. `all the Awakes will have finished before the first Start is called.`

   > 所有的Awakes初始化均会在第一个start之前，注意一些重复初始化问题，而且Start可借助Awake完成一些初始化
   
2. `Using the constructor when the class inherits from MonoBehaviour will make the constructor to be called at unwanted times and in many cases might cause Unity to crash.`

   > 脚本的构造函数可能会在你不期望的时机被调用，甚至导致unity崩溃，所有尽量不要使用构造函数完成初始化

### GUI events

> GUI控件上发生的相应事件，与帧更新的处理方式不同

#### OnGUI()

> `U3D Document : Unity has a system for rendering GUI controls over the main action in the scene and responding to clicks on these controls. This code is handled somewhat differently from the normal frame update and so it should be placed in the OnGUI function, which will be called periodically.`
>
> 用于GUI控件的渲染以及发生在其上的点击事件的响应

### Physics events

> `U3D Document : The physics engine will report collisions against an object by calling event functions on that object’s script.`
>
> U3D使用脚本中的事件函数来处理发生在对象上的碰撞

**Collider / Trigger**

> Collider 可以认为是记录对象空间占位信息的组件，只有具有 Collider 组件的对象，才会由物理系统去计算发生在该对象上的碰撞
>
> 若仅仅想检测碰撞，但是却不希望影响该对象的移动，而可以在inspector面板中将 Collider 勾选配置为 Trigger，可以仅检测碰撞而不产生碰撞效果，具体响应可在下面事件中作出

#### OnCollisionEnter() / OnTriggerEnter()

#### OnCollisionStay() / OnTriggerStay()

####  OnCollisionExit() / OnTriggerExit()

## Order of execution for event functions / 事件的执行顺序

> `U3D Document : Unity orders and repeats event functions over a script’s lifetime.`
>
> 在一个脚本的生命周期内，例如场景加载时，帧更新时，修改对象属性时等等会 包含/触发 一系列的u3d事件函数
>
> 具体需要时参考U3D Document

### Script lifecycle overview / 脚本的生命周期概述

- First Scene Load / 场景第一次加载时
- Editor / 编辑属性时
- Before the first frame update / 第一次帧更新前
- In between frames / 帧之间
- Update order / 更新时
- Animation update loop / 动画更新循环时
- Rendering / 渲染时
- Coroutines / 协程相关
- When the object is destroyed / 对象销毁时
- When quitting / 退出时

## Coroutines / 协程

> `U3D Document : A coroutine allows you to spread tasks across several frames. In Unity, a coroutine is a method that can pause execution and return control to Unity but then continue where it left off on the following frame.`
>
> 一个脚本中的普通事件函数只能在一帧完成，如果需要有一定的过渡效果，就必须将该事件函数处理的任务分散在多个帧中逐步完成，协程允许将一个任务分散在多个帧中执行，它可以在某一帧中停止执行，将控制权返还给unity，随后在下一帧继续执行因暂停而未完成的任务

## Attributes  / 特性

> `U3D Document : Attributes are markers that can be placed above a class, property or function in a script to indicate special behaviour.`
>
> 类似于ue4的uproprety宏定义，用于表明某些属性，方法，类的特殊行为，例如是否在的inspectors窗口中显示public属性

## Important Class / 内置类

> 目前版本暂时略，需要时自查文档即可

- - -

**Questions : **

- UEGamePlay框架
- prefab is instantiated / 预制件的实例化，在什么情景下算实例化成功？资产中的预制件算不算？场景中的预制件算不算？脚本属性中的预制件引用对应的实体算不算？
- MonoBehaviour instance is created？ GameObject with the script component is instantiated
- ~~collider and Trigger~~
- ~~刚体与碰撞体~~


- - -

2021/12/24 - 2021/12/25

- - -

# Unity3D Animation / 动画

> `U3D Document :Unity’s Animation features include retargetable animations, full control of animation weights at runtime, event calling from within the animation playback, sophisticated state machine hierarchies and transitions, blend shapes for facial animations, and much more.`

## Animation Workflow / 动画流程

  1. Animation clips are imported from an external source or created within Unity. In this example, they are imported motion captured humanoid animations.
  2. The animation clips are placed and arranged in an Animator Controller. This shows a view of an Animator Controller in the Animator window. The  States (which may represent animations or nested sub-state machines) appear as nodes connected by lines. This Animator Controller exists as an asset in the Project window.
  3. The rigged character model (in this case, the astronaut “Astrella”) has a specific configuration of bones which are mapped to Unity’s common Avatar format. This mapping is stored as an Avatar asset as part of the imported character model, and also appears in the Project window as shown.
  4. When animating the character model, it has an Animator component attached. In the Inspector view shown above, you can see the Animator Component which has both the Animator Controller and the Avatar assigned. The animator uses these together to animate the model. The Avatar reference is only necessary when animating a humanoid character. For other types of animation, only an Animator Controller is required.

## Animation Window / 动画窗口

> `U3D Document : The Animation Window in Unity allows you to create and modify Animation Clips directly inside Unity, the Animation window shows the timeline and keyframes of the Animation for the currently selected GameObject or Animation Clip Asset.`
>
> 用于对动画切片进行编辑的工具，该窗口展示了选中游戏对象上动画的时间轴与关键帧
>
> 操作详情略，忘记时文档自寻

### Windows Interface / 界面布局

#### Playback and frame navigation controls / 回放与帧导航控制

- Record Mode for Playback / 录制模式

  > 录制模式下，对游戏可动画化属性的任何更改，都会在该时间轴位置处添加关键帧

- Preview Mode for Playback / 预览模式

  > 预览模式下，若不是通过属性列表修改的属性，均不会自动创建关键帧，需要手动添加关键帧
  >
  > 1. shift + k 为更改属性/所选属性添加关键帧
  > 2. k 为当前属性列表中的所有属性添加关键帧
  > 3. inspector视图中对相应属性右键添加关键帧
  > 4. 属性列表为指定属性添加关键帧

- Frame Navigation Controls / 帧导航控制

> alt + > 下一关键帧 / alt + < 上一关键帧
>
> \> 下一帧 / < 上一帧
>
> 空格 暂停

#### The Animated Properties list / 已动画化的属性列表

> 该列表将显示选定动画化的游戏对象的已动画化的属性，可以添加其余可动画化属性来完成更多动画效果

#### The Animation Timeline / 动画时间轴

> 可以使用该时间轴，在某个时间点设置期望属性值后插入关键帧，完成动画效果
>
> 该时间轴的单位为 秒:帧

- Dopesheet timeline mode / 关键帧清单模式

  > 详细操作见文档

- Curves timeline mode / 曲线时间轴模式

  > 详细操作见文档
### Rotation Interpolation Types / 旋转插值类型

- Quaternion Interpolation  / 四元数插值

  > 两个旋转之间的最短路径进行平滑插值
  >
  > 不能表示大于180°的旋转
  >
  > 对xyz任意一条曲线的更改，其余曲线均可能被影响，对任意一条曲线的插入关键帧，其余曲线都插入

-  Euler Angles Interpolation / 欧拉角插值

> 可以表示任意角度的旋转
>
> xyz三条曲线相互独立
>
> 围绕多个轴进行旋转时，可能导致插值瑕疵，如万向锁

## Animation Clips / 动画切片

> `U3D Document : Unity’s animation system is based on the concept of Animation Clips, which contain information about how certain objects should change their position, rotation, or other properties over time. Each clip can be thought of as a single linear recording. Unity supports importing animation from external sources, and offers the ability to create animation clips.`
>
> 动画切片可以理解为一个线性录制，它包含了某个对象的可动画化属性如何随时间变化而变化
>
> u3d中的动画切片可从外部导入也可自行创建

### Animation from External Sources / 由外部源导入

> `U3D Document : These External files can contain animation data in the form of a linear recording of the movements of objects within the file.`
>
> 这些外部源文件可以通过 线性记录文件中对象移动 的方式存储动画数据
>
> 详细略，此前为略读了解概念版本

- Humanoid animations captured at a motion capture studio

  > 可导入来自动作捕捉的动画

- Animations created from scratch by an artist in an external 3D application (such as Autodesk® 3ds Max® or Autodesk® Maya®)

  > 可导入外部3D软件创建的动画

- Animation sets from 3rd-party libraries (eg, from Unity’s asset store)

  > 可导入第三方库中的动画集

- Multiple clips cut and sliced from a single imported timeline.

  > 也可是单个时间轴切割形成的多个动画切片

### Animation Created and Edited Within Unity /  由Unity创建并编辑

- The position, rotation and scale of GameObjects

  > 可以由游戏对象的位置，旋转，缩放形成

- Component properties such as material color, the intensity of a light, the volume of a sound 

  > 可以由组件的属性形成，例如材质颜色变化，光照强度变化，声音强弱变化
  >
  > - Float
  > - Color
  > - Vector2
  > - Vector3
  > - Vector4
  > - Quaternion / 四元数
  > - Boolean

- Properties within your own scripts including float, integer, enum, vector and Boolean variables

  > 脚本中的属性成员

- The timing of calling functions within your own scripts 

  > 脚本中函数的调用时机

### Animation Events / 动画事件

> `U3D Document : You can increase the usefulness of Animation clips by using Animation Events, which allow you to call functions in the object’s script at specified points in the timeline.`
>
> 可以将动画化对象脚本中的某些函数作为事件添加至动画切片中时间轴中某个时间点上，作为动画事件增加动画切片的用途
>
> `注意:`
>
> 1. 在时间轴的某个时间点添加事件后，需要将其与对应对象脚本的函数建立绑定，若该函数带有参数，还必须指定参数
> 2. 该事件需要作为该动画作用对象的组件进行附加

## Animation Controller / 动画控制器

> `U3D Document : The Animator Controller acts as a “State Machine” which keeps track of which clip should currently be playing, and when the animations should change or blend together.`
>
> Controller 用于跟踪当前状态需要播放哪一个动画切片，并管理各切片应何时改变或何时混合
>
> `U3D Document : An Animator Controller allows you to arrange and maintain a set of animations for a character or other animated Game Object.The controller has references to the animation clips used within it, and manages the various animation states and the transitions between them using a so-called State Machine.`
>
> Controller 包含对动画切片的引用，通过状态机，Controller 可以管理各动画状态与状态之间的转换
>
> `U3D Document : However even if you just have a single animation clip you still need to place it into an animator controller to use it on a Game Object.`
>
> 动画切片若想作用于游戏对象，需要通过 Animation Controller 附加到游戏对象上，因此即使只有一个动画切片，也需要由 Animation Controller 控制管理

#### Layer / 动画层

> `U3D Document : This allows you to have multiple layers of animation within a single animation controller working at the same time, each controlled by a separate state machine. A common use of this is to have a separate layer playing upper-body animations over a base layer that controls the general movement animations for a character.`
>
> at the same time ，a single animation controller，multiple layers of animation，在一个controller下，同一时刻可以有多种动画同时播放，每个动画分别由独立的状态机控制，例如为了使人物移动更自然，在整体move的base动画层播放时，仍可添加一个上身动画层同时播放以时该动作更自然
>
> `U3D Document : Unity uses Animation Layers for managing complex state machines for different body parts. `
>
> 动画层可用来处理不同身体部位的复杂状态机，即同时处理不同身体部位的动画，各个部位使用单独的状态机

**Mask / 遮罩**

> `U3D Document : The mask specifies the body parts on which to apply the animation. `
>
> 遮罩用来具化动画应该应用在哪一个身体部位上

**Blending Type / 混合类型**

> `U3D Document : The Blending type specifies how the animation is applied.`
>
> 混合类型用来规范各动画层应如何工作

- Override / 覆盖 : to use the animation on this layer, replacing the animation on previous layers.

- Additive / 附加 : to add the animation on this layer on top of the animation from previous layers.

  For additive blending to be successful, the animation on the additive layer must contain the same properties as the previous layers.

### Parameters / 动画参数

> 这东西到底是干啥的？？？

### Animation State Machines / 动画状态机

> `U3D Document : It is common for a character or other animated Game Object to have several different animations that correspond to different actions it can perform in the game.State machine enable you to control and sequence the animation clips that you want to use on your character or object.`
>
> 动画状态机允许你控制动画切片，在游戏对象发生某些行为时，可以播放你想与之对应的动画
>
> `U3D Document : Taken together, the set of states, the set of transitions and the variable to remember the current state form a state machine.`
>
> 状态集合，状态过渡集合，以及标识记录当前状态的变量形成了状态机

#### State / 状态

> `U3D Document : Each state has a Motion associated with it that will play whenever the machine is in that state.`
>
> 在 Animation Controller 中以被线条连接的结点表示，它可以是某个clip动画，也可以是一个子状态机
>
> 每种状态对应一种行为，只要在该状态下，就会一直执行该行为直至该状态结束

#### State Machine Transitions / 状态过渡

> `U3D Document : The options for the next state that a character can enter from its current state are referred to as state transitions. `
>
> 从当前状态到下一可进入状态的这些选择被称为状态过渡
>
> `U3D Document : Each view in the animator window has an Entry and Exit node. These are used during State Machine Transitions.`
>
> `The Entry node is used when transitioning into a state machine. `
>
> `The Exit node is used to indicate that a state machine should exit.`
>
> 状态机中的开始与退出结点用于过渡
>
> `U3D Document : It is possible to mix state machine transitions with regular state transtitions, so it is possible to transition from state to state, from a state to a statemachine, and from one statemachine directly to another statemachine.`
>
> 状态机可支持状态机过渡与常规过渡的混合，状态机 <-> 状态机 <-> 状态 <-> 状态 均可支持 

#### State Machine Behaviours / 状态机行为

> `U3D Document : State Machine BehavioursA State Machine Behaviour is a special class of script. In a similar way to attaching regular Unity scripts(MonoBehaviours) to individual GameObjects, you can attach a StateMachineBehaviour script to an individual state within a state machine. This allows you to write code that will execute when the state machine enters, exits or remains within a particular state.`
>
> 状态机行为是特殊的用于状态机的脚本，该脚本可以附加于状态机的某种状态下，可以在该状态进入，更新，退出，移动等等时机调用
>
> 该脚本包含的类继承自 StateMachineBehaviour 类

- State Machine Behaviours / 状态机行为
- State Behaviours / 状态行为

#### Target Matching / 目标匹配

> `U3D Document : Often in games, a situation arises where a character must move in such a way that a hand or foot lands at a certain place at a certain time.`
>
> 角色的移动有时需要在动画结束后使得某个身体部位固定到某一个位置，可以在正确点调用 animator.MatchTarget() 函数完成部位结束位置的固定
>
> 前提 : 
>
> 1. 需匹配部位在动画发生时的位置
> 2. 需匹配部位在动画结束时的位置

```c# 
using UnityEngine;
using System;

[RequireComponent(typeof(Animator))] 
public class TargetCtrl : MonoBehaviour {

    protected Animator animator;    
    
    //the platform object in the scene
    public Transform jumpTarget = null; 
    void Start () {
        animator = GetComponent<Animator>();
    }
    
    void Update () {
        if(animator) {
            if(Input.GetButton("Fire1"))         
                animator.MatchTarget(jumpTarget.position, jumpTarget.rotation, AvatarTarget.LeftFoot, 
                                                       new MatchTargetWeightMask(Vector3.one, 1f), 0.141f, 0.78f);
        }       
    }
}
```



#### Forward Kinematics / FK正向运动学 :

> `U3D Document : Most animation is produced by rotating the angles of joints in a skeleton to predetermined values. The position of a child joint changes according to the rotation of its parent and so the end point of a chain of joints can be determined from the angles and relative positions of the individual joints it contains. This method of posing a skeleton is known as forward kinematics.`
>
> 将关节旋转至预定义的旋转角度可形成动画，子关节的旋转随其父节点的旋转的改变而改变，因此一条关节链的终点可以由该链所包含的关节的角度与相对位置来确定，这种构建骨架的方式称为正向运动学
>
> 简言之，即根据父关节的旋转来计算得出每个子关节的位置

- 自带运动曲线，自然

  > 由父关节带动子关节的运动，因此动画更自然，走路，投弧线更自然一些 

- 存在万向锁问题

#### Inverse Kinematics / IK逆向运动学

> `U3D Document : Given a chosen position in space, work backwards and find a valid way of orienting the joints so that the end point lands at that position. This approach is known as Inverse Kinematics (IK) and is supported in Mecanim for any humanoid character with a correctly configured Avatar.`
>
> 预先给定的不是该关节的旋转角度，而是空间中的位置，在逆向找到关节定位的方式，最终使得关节链的终点位于该位置
>
> 简言之，由末端子关节的位置移动来得出每个父关节的旋转

- 当末端控制器收到物体或空间限制时，IK更方便

  > 动画涉及牵引，推拉，支撑等可能导致父关节随之变动的动画，IK更方便一些

#### Root Motion / 根运动

> 暂略

## Avatar for Humanoid Animation / Avatar系统

> `U3D Document : Unity’s Animation system also has numerous special features for handling humanoid characters which give you the ability to retarget humanoid animation from any source (for example: motion capture; the Asset Store; or some other third-party animation library) to your own character model, as well as adjusting muscle definitions. These special features are enabled by Unity’s Avatar system, where humanoid characters are mapped to a common internal format.`
>
> Avatar系统主要用于处理人形角色动画，它允许我们将任何源中的人形动画重定向到我们的场景人物模型中，使其具有相同动画，并且我们可以重新调整肌肉定义

## Animationtor Component / 动画组件

> `U3D Document : Each of these pieces - the Animation Clips, the Animator Controller, and the Avatar, are brought together on a GameObject via the Animator Component. This component has a reference to an Animator Controller, and (if required) the Avatar for this model. The Animator Controller, in turn, contains the references to the Animation Clips it uses.`
>
> 动画需要应用到场景中的游戏对象上，而GameObject的属性行为由组件赋予，因此无论 Animation Clips，Animation Controller or Avatar 均需要通过  Animationtor 组件附加到场景中的游戏对象上，仅当对象为人形角色时才会附加Avatar资源的引用


- - -

**Questions : **

- ~~the object to be animated~~

- ~~the animations~~

- ~~The timing of calling functions within your own scripts~~

  > ~~脚本中函数的调用时机~~

- ~~动画剪辑的关键帧和曲线~~

- ~~Animation Events 动画事件~~

  > ~~functions that are called at specified points along the timeline.~~
  >
  > ~~这些函数将在时间轴上的指定点被调用~~

- ~~Animation view~~

- ~~创建动画切片时该动画切片应应用于哪一个游戏对象是否可选定？创建动画切片的正确方式时什么？需要先确定动画化对象再去创建其相应的切片吗？~~

- ~~如何为指定游戏对象创建动画切片？~~

- ~~State Machines consist of **States**, **Transitions** and Events 事件怎么体现~~

- 骨骼

- where humanoid characters are mapped to a common internal format.？？？映射为一种什么样的内部格式

- Multiple clips cut and sliced from a single imported timeline. ？？？

- 曲线的关键点？曲线的关键点一旦添加，关键帧清单模式下也会给相应位置添加关键帧，那这个关键点为什么要和关键帧的概念区分开？

- 万向锁？？？

- 旋转插值类型？？？

- character 是什么概念？？人形角色？

- Controllor 状态机的输入参数概念？？该参数的意图在于什么？

- 状态机的各个状态为什么会自动循环？

- transition设置了切换的条件为什么会无效？使用的是默认的参数作比较

- 状态的进入明白，状态机何时进入？为什么设置了相应的进入行为但是却没有被调用？

- 标识当前状态的变量？？？？ the variable to remember the current state？？？？

- 动画层的顺序会有先后显示的含义吗？比如在上面的动画会覆盖下面的动画

- 动画层mask怎么用？

- Animation Layer syncing 动画层同步？？


- - -

2021/12/27 - 2021/12/30

- - -

## Blend Trees / 混合树

>  `U3D Document : Blend Trees are a special type of state in an Animation State Machine.`
>
> 混合树是状态机中一种特殊的状态
>
> `U3D Document : A common task in game animation is to blend between two or more similar motions. `
>
> 其可以混合多种类似的动画
>
> `U3D Document : The amount that each of the motions contributes to the final effect is controlled using a blending parameter, which is just one of the numeric animation parameters associated with the Animator Controller.`
>
> 多种动画对最终效果的影响通过 blending parameter 控制，该参数为动画参数之一
>
> `U3D Document : In order for the blended motion to make sense, the motions that are blended must be of similar nature and timing. `
>
> 被混合的动画需要具有相似的性质与时机，以时混合动画更合理

- - -

**Questions :** 

- Blend Trees 混合多种动画切片为一个混合动画切片？
- Input Manager
- 动画模型的导入格式


- - -

2021/12/30 16:50

- - -

# Unity3D Input Manager / 输入

>  `U3D Document : The Input Manager window allows you to define input axes and their associated actions for your Project. `
>
>  在 Input Manager 完成输入轴的定义与响应操作的关联/绑定

## Input Type / 输入类型

> `U3D Document : The type of input that controls the axis.`
>
> 控制虚拟轴的输入类型

- Key or Mouse Button / 鼠标/键盘的按钮
- Mouse Movement / 鼠标移动
- JoyStick Axis / 鼠标杆轴

## Controls / 控件

 - Key

   > `U3D Document : refers to any key on a physical keyboard, such as W, Shift, or the space bar.`
   >
   > physical keyboard，物理键盘的输入

 - Button

   > `U3D Document : refers to any button on a physical controller (for example, gamepads), such as the X button on an Xbox One controller.`
   >
   > physical controller，游戏控制器的输入，例如手柄

`注意:`

1. 区分控件类型与输入类型，关系为用户的输入操作将激活相应的控件

## Virtual Axis (plural : Axes) / 虚拟轴

> `U3D Document : Every Project you create has a number of input axes created by default. These axes enable you to use keyboard, mouse, and joystick input in your Project straight away.`
>
> 虚拟轴可以在用户执行输入操作时，接受[-1,1]之间的某个值，该值可用于脚本，从而处理该输入操作将触发的事件

### Properties / 轴属性

| **属性**                                        | **功能**                                                     |
| :---------------------------------------------- | :----------------------------------------------------------- |
| **Name**                                        | 轴名称。使用此名称可以通过脚本来访问轴。                     |
| **Descriptive Name, Descriptive Negative Name** | 这些值已弃用，不起作用。以前在启动时会在 Rebind Controls 屏幕上为用户显示这些值，但该屏幕也已弃用。 |
| **Negative Button, Positive Button**            | 用于分别沿负向和正向推动轴的控件。这些控件可以是键盘上的键，也可以是游戏杆或鼠标上的按钮。 |
| **Alt Negative Button, Alt Positive Button**    | 用于分别沿负向和正向推动轴的备用控件。                       |
| **Gravity**                                     | 不存在输入时，轴下降到中性点的速度（以单位/秒表示）。        |
| **Dead**                                        | 在应用程序对移动操作进行记录之前，用户需要移动模拟摇杆的距离。在运行时，所有模拟设备在该范围内的输入将被视为 null。 |
| **Sensitivity**                                 | 轴向目标值移动的速度（以单位/秒表示）。仅用于数字设备。      |
| **Snap**                                        | 如果启用此属性，按下对应于反方向的按钮时，轴值将重置为零。   |
| **Type**                                        | 这是控制此轴的输入类型。从以下值中进行选择： 键或鼠标按钮 (Key or Mouse button) 鼠标移动 (Mouse Movement) 游戏杆轴 (Joystick Axis) |
| **Axis**                                        | 这是用于控制此轴的连接设备的轴。                             |
| **JoyNum**                                      | 这是控制此轴的连接游戏杆。可以选择特定游戏杆，或查询所有游戏杆的输入。 |



## Map / 映射

> `U3D Document : A virtual axis (plural: axes) is mapped to a control, such as a button or a key. When the user activates the control, the axis receives a value in the range of [–1..1]. You can use this value in your scripts.`
>
> 用户的输入操作 -> 激活相应的控件 -> 该控件映射到的轴可以接受相应的[-1,1]之间的某个值 -> 从而脚本获取该值
>
> `U3D Document : To map a key or button to an axis, enter its name in the Positive Button or Negative Button property in the Input Manager.`
>
> 建立控件与虚拟轴的映射的方式即为设置虚拟轴的 Positive Button 属性 or Negative Button 属性，建立虚拟轴与控件的绑定

## Using virtual axes in scripts / 脚本中使用虚拟轴

> `U3D Document : To access virtual axes from scripts, you can use the axis name.`
>
> 使用虚拟轴的名称便可以在脚本中获取轴的值

- Input.GetAxis("AxisName") 获取 AxisName 轴的值
- Input.GetButtonDown("AxisName") 对于非移动操作的轴，类比ue4操作映射，应使用该函数获取轴值

# Unity3D Models / 模型

> `U3D Document : Models are files that contain data about the shape and appearance of 3D objects, such as characters, terrain, or environment objects.Model files can contain a variety of data, including meshes, materials, and textures. They can also contain animation data, for animated characters.`
>
> 模型是包含3D对象形状和外观数据的文件，例如角色，地形，或环境对象
>
> 模型还可以包含动画数据，若对象为动画化的对象，还可以包含网格体，材质以及纹理等

- - -

**Questions :** 

- 轴的值时干啥用的？
- 输入类型与控件类型的关系模糊？
- 人物移动的话应该算key类型的控件，长按如何处理的？如何通过轴的值去处理长按操作的？
- 是否非移动型的操作映射都可以使用GetButtonDown来接受轴值呢？


- - -

2021/12/30 21:00

1. ue4状态机
2. AI项目结构
3. 工具导入
4. 骨骼
5. 模型文件
6. 导入
7. 碰撞范围