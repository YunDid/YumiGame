# Unity Animation Systems / Unity 动画系统

# The Current Progress / 当前进度

- Unity初级编程 - 中级编程 / √
- 动画系统demo实践 完成模型导入-> 动画绑定 -> 状态机组织动画 / ing
- 工具 fbx -> motiondate -> 中间数据
- ue4状态机 + AI + 行为树
- 着手AIAnimation框架，着手动画系统的改写

# Animation Data / 动画数据

> `U3D Document : Animation data is stored as an asset called an Animation Clip.`
>
> `An Animation Clip can store any GameObject animation.`
>
> `Animation Clips are the fundamental building blocks of Unity’s animation systems. `
>
> 动画数据被存储为动画切片，动画切片为动画系统的基本构件

## Animation Clip / 动画切片

#### Values / 值

> `U3D Document : The values of an Animation Clip are usually, but not always, represented by Animation Curves.`
>
> 值数据总是以曲线的形式体现
>
>  `Animation Curves contain information about the way the GameObject you’re animating changes. `
>
> 动画曲线包含了游戏对象动画化的方式信息

#### Bindings / 绑定

> `U3D Document : The bindings of an Animation Clip are a way of connecting the values to a particular field of a GameObject or component.`
>
> 绑定 : 将值与游戏对象或组件的具体字段建立关联
>
> `1. The path through the Hierarchy to the GameObject’s Transform component`
>
> 先将值与游戏对象的相应组件建立关联
>
> `2. The path from that Transform component to a particular field`
>
> 再将值与相应组件的具体字段建立关联
>
> `注意:`
>
> 1. 每个值都具有其意义，其意义取决于与其一对一绑定的特定字段

## Animation Mode / 动画化方式

> `U3D Document : When an animation is playing, the current time for its Animation Clip changes. At any given time, the values for all the bindings are being checked and the fields that those bindings correspond to have their values set.`
>
> 动画一旦开始播放，其时间轴上的时间也将变化，进而完成动画化
>
> 1. 任意一个时间点，该时间点下的所有绑定对应的值都将被检查
> 2. 并且与该值也将被设置到其绑定的字段上

# Animation Blending / 动画混合

> `U3D Document : When you play more than one Animation Clip at the same time, Unity blends them together. The result of the blend is then applied to the bindings. `
>
> 当播放超过一个的动画切片时，Unity会将这些动画混合后应用于绑定
>
> `U3D Document : To blend Animation Clips, each animation has a relative weight. These weights are used to calculate how much influence each individual Animation Clip has on the final animation. `
>
> 动画权重的意义在于指出被混合的每一个动画切片对最终动画的影响

## Animator Controller / 动画控制器

> `U3D Document : An Animator Controller is a way of controlling when an Animation Clip starts playing and how it’s blended with other Animation Clips. `
>
> 动画控制器用于控制动画切片的播放时机以及动画切片之间的混合方式
>
> `U3D Document : They are a collection of logical States, containing one or more Animation Clips. `
>
> 动画控制器是一组逻辑状态的集合，包含一个或多个动画切片
>
> `U3D Document : The Animator Controller takes a path between these States, evaluating the Animation Clip(s) in the State currently being played. `
>
> 控制器将选取状态之间的一条路径来评估当前状态下应播放的动画切片
>
> `U3D Document : The States are connected by Transitions, which blend the Animation Clips of the States they connect together. `
>
> 状态通过 transition 来完成过渡混合

### Animator Transition / 状态过渡

> `U3D Document : Transitions are used to blend two animations together. `
>
> Transitions 被用于状态之间的过渡混合
>
> `注意:`
>
> 1. 默认 Entry 下的过渡是不可预览的，即没有以下各 Settings

- Exit Time / 退出时间

  > float 类型，表明当前状态播放百分之 n(n为退出时间 * 100) 后开始过渡，若想当前状态至少播放一次完毕后再过渡，该值需要大于1

- Transition Offset / 过渡偏移

  > `U3D Document : You want the animations you’re blending to do so smoothly, so it’s important for the animations to be in phase like they were when you were manually adjusting the weights of the Circle and Square Animation Clips. `
  >
  > 动画混合时为了使混合更自然，因此被混合的动画应该处于相位态，即上一个动画从50%结束时，下一个动画不能从头开始而应该也从50%处开始播放，这样才能在调整权重之后动画过渡更自然
  >
  > `注意:`
  >
  > 1. 偏移时间应该根据退出时间而定，自上一动画的退出时间点来设置下一动画的偏移量

--------

**Questions: **

- ~~动画切片的组成 - 绑定是什么概念？一对一绑定是什么东西？~~

--------

2022/1/7 21:42 - 2022/1/10 17:52

# Animation Windows / 动画窗口

## Keyframes / 关键帧

> `U3D Document : These keyframes hold information on the value of the Animation Curve at a specific time, as well as how to interpolate the values in-between.`
>
> 关键帧记录有曲线在特定时间下的特定值，以及在两值之间插值的方式

## Keyframes Tangents / 关键帧切线

> `U3D Document : The value of an Animation Curve at any given time is the interpolation between the previous and next Keyframe. The exact value of this interpolation is calculated using the tangents of the Keyframes.`
>
> 关键帧切线可以用于计算两关键帧之间任意时刻的插值
>
> `U3D Document : Each Keyframe has two tangents: An in-tangent (on the left), An out-tangent (on the right)`
>
> 每个关键帧有两个切线，一个为内切线(左侧)，一个为外切线(右侧)
>
> `U3D Document : The exceptions to this are the first and last keyframes: the in- and out-tangents of the first and last Keyframes are connected to each other for the purposes of editing looped animation.`
>
> 但是第一个关键帧与最后一个关键帧的切线相互连接，便于编辑循环动画

# Model-Specific Animation / 模型动画

## Fundamentals / 基础

> `U3D Document : Models in Unity are represented by a Mesh of triangles. When you want to animate a model, the Mesh must be deformed so that its triangles change position and shape. `
>
> 模型是由三角形组成的网格体表示的，当动画化模型时，其网格体需要作出改变，以便其三角形改变位置与形状
>
> `U3D Document : Models can contain too many triangles for each of them to be moved individually. The higher the definition of a model, the greater the number of triangles. `
>
> 但是模型越复杂，其所包含的三角形越多，因此当改变网格体时，手动逐个操作具体的三角形是不现实的
>
> `U3D Document : Instead of moving each triangle individually during animation, models are skinned before they are animated.`
>
> 取而代之的是在动画化模型之前，先对模型进行蒙皮
>
> `U3D Document : Skinning gives each of the vertices making up the triangles a dependence on a bone. This bone is then moved using animation data and the associated vertices work out where they should be based on the bone’s position and rotation.`
>
> 蒙皮使模型的三角形顶点依附于骨骼而运动，形成动画数据控制骨骼的移动，骨骼带动绑定到其上的三角形顶点的运动
>
> `U3D Document : Bone hierarchies and the way they affect meshes are part of Rigs.`
>
> 骨骼影响网格体运动的方式由 Rigs 决定
>
> `U3D Document : In Unity, bones are represented by Transforms.`
>
> 在Unity中，骨骼由 Transforms 表示

### Forward Kinematics / FK正向动力学

> `U3D Document : This means that child Transforms move relative to their parents.`
>
> 子变换依赖于父变换，由父变换带动子变换

### Inverse Kinematics / IK逆向动力学

> `U3D Document : This is where the end of a chain of bones has its position or rotation set, and then the positions and rotations of bones further up the chain are set via an algorithm to accommodate the end bone’s position and rotation.`
>
> IK中，骨骼链的末端骨骼有其位置与旋转集，骨骼链更深层次的骨骼运动将由算法计算，来适应末端骨骼的位置与旋转

## Model-Specific Import Settings / 模型导入设置

> `U3D Document : When models are imported from digital content creation (DCC) programs, they have animation settings that are split into two sections: `
>
> `1. Model-specific settings, which affect all animations imported with that model.`
>
> `2. Animation-specific settings, which affect individual animations imported with that model.`
>
> 当模型是由GCC程序集导入时，其动画设置具有针对于整个动画模型的设置，也具有针对于某个具体动画切片的设置，以下为部分 Model-specific settings
>

- Import Constraints

  > 是否导入相应的关节约束

- Import Animation

  > 是否将模型对应的动画导入，若不勾选则无其余动画设置

- Baking animations / 烘焙动画

  > `U3D Document : This determines whether animations imported as inverse kinematics (IK) or simulation data should be converted into forward kinematics (FK) through a process called baking. `
  >
  > 该设置表明以 IK 或 仿真数据 导入的动画，是否应该被转换为 FK 数据，烘焙后将以 FK 格式存储动画数据
  
- Resampling Animation Curves / 重新采样

  > `U3D Document : This setting determines whether animations imported with euler angles for their rotations should have these converted to quaternion angles instead. `
  >
  > 该设置表明是否应该将以欧拉角定义旋转的数据应转换为以四元数定义
  >
  > `注意: `
  >
  > 1. this option is only available for models with generic rigs, as humanoid rigs are automatically resampled. 
  > 2. if an animation makes a rotation greater than 180 degrees between frames.  注意是否存在180°旋转

- Animation Compression / 动画压缩优化

  > `The Animation Compression setting refers to how the animation’s size, both on disk and in memory, can be reduced by making approximations from the original imported file. `
  >
  > 该设置可以选择 对原始动画的近似方式 来减少动画数据在内存以硬盘中所占的大小
  >
  > 1. off / 不压缩
  > 2. Keyframe Reduction / 减少关键帧
  > 3. Optimal / 最优

- Custom Properties / 定制属性

# Cutting Imported Animation Clips / 剪切动画切片

> `U3D Document : You’ll use animation-specific settings to cut an imported Animation Clip. One of the most common uses for cutting animation is using motion capture (or mocap) data, but it can be used to adjust any imported animation. `
>
> 使用 animation-specific 针对动画切片的设置完成对导入动画的剪切

## Timeline / 时间轴

> `U3D Document : The animation timeline shows all of the animation data for the current Animation Clip`
>
> 时间轴显示了当前选中动画切片的动画数据
>
> `U3D Document : There are handles you can drag to set the start and end of the Animation Clip to cut the take.`
>
> 通过拖拽切片来对动画切片进行剪切，也可通过 Start 与 End 完成对剪切点的选择

## Timeline Settings / 时间轴设置

- Loop Time / 循环时间

  > `U3D Document : If the Loop Time setting is enabled, the animation will begin again at the start once it finishes. `
  >
  > 只有选中了 Loop Time 选项，动画才会循环播放

- Loop Pose / 循环姿势

  > `U3D Document : The Loop Pose setting changes the values of the keyframes in the Animation Clip so that they match at the start and end. `
  >
  > 选中 Loop Pose 会改变关键帧的值以便该动画切片的关键帧在 start 与 end 处可匹配关联，使其不会在循环时发生突变，循环更自然

- Cycle Offset / 周期偏移

  > `U3D Document : Cycle Offset adjusts when the Animation Clip actually starts in the frame range you have selected. `
  >
  > Cycle Offset 可用于调整剪切后的该动画真正开始的时间，相对于选中 start 的偏移量
  >
  > `U3D Document : It is measured in Normalized Time, which means that a value of 0.2 would start the Animation Clip 20% of the way into the selected frame range.`
  >
  > 该值若为0.2，则代表由剪切后切片的20%处开始播放，注意此时 Plane 预览面板的动画时间初始值也随之变化
  >
  > `U3D Document : When blending similar animations, it makes sense for them to be in phase. `
  >
  > 该设置在混合动画时很有用，被混合的动画切片可能需要具备相应的条件，比如设置标准化的起始姿势

## Root Motion / 根运动

> `U3D Document : Root nodes are used to define Root Motion in animations. Root Motion is when an animation causes GameObjects to offset from their previous position, rather than just moving in absolute terms.This means you can make movements look a lot more realistic, as they can be based on the animation itself and not simply scripted. `
>
> 根运动是指一个动画导致游戏对象的位置发生变动，而不是通过绝对值移动，这意味着你可以作出更自然的移动，因为这些移动将基于动画本身
>
> `U3D Document : You can fix these things by baking some elements of the Root Motion into the pose. This means they won’t affect the Root Motion at all.`
>
> 可以将切片的 Root Motion 中某些元素 bake into the pose 来使这些元素不会影响根运动

-------
**Questions:** 

- simulation data 仿真是个什么样的动画数据？
- rather than just moving in absolute terms 什么意思？
- Root Motion / 根运动

-------

2022/1/11 15:42