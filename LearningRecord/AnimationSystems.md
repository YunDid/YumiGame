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

## Animation Events / 动画事件

> `U3D Document : Animation Events call methods in MonoBehaviour scripts. In order for an Animation Event to call a method from a script, the script must be attached to the same GameObject as the Animator component through which the Animation Clip is playing.`
>
> 动画事件调用 MonoBehaviour 脚本下的方法，为了保证事件能够调用到脚本中的方法，该方法必须被附加同一个游戏对象上

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

### Triangle Mesh / 三角网格

> `U3D Document : Generally, animated models have a skinned mesh. `
>
> 动画化的模型一般都会有一个蒙皮网格体
>
> `U3D Document : Skinning is the process of connecting each vertex of a mesh to one or multiple bones and then giving those bones a weight to affect that vertex. `
>
> 而蒙皮使模型每个网格体的顶点会关联到一个或多个骨骼，这些骨骼被赋予了权重来决定对顶点移动的影响程度
>
> `U3D Document : In Unity, bones are represented by the Transforms of a model，which are part of GameObjects, so each vertex moves with a weighted combination of the Transforms it is skinned to. `
>
> 在Unity中，骨骼通过模型的 Transforms 来表示，即游戏对象上的 transform 组件，所以网格体顶点的移动将跟随其附加到的所有 Transforms 权重组合的变化而变化 
>
> `注意:`
>
> 1. 一个模型可能有多个游戏对象用以表示多个骨骼

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

## Animation-Specific Import Settings / 切片导入设置

### Cutting Imported Animation Clips / 剪切动画切片

> `U3D Document : You’ll use animation-specific settings to cut an imported Animation Clip. One of the most common uses for cutting animation is using motion capture (or mocap) data, but it can be used to adjust any imported animation. `
>
> 使用 animation-specific 针对动画切片的设置完成对导入动画的剪切

### Timeline / 时间轴

> `U3D Document : The animation timeline shows all of the animation data for the current Animation Clip`
>
> 时间轴显示了当前选中动画切片的动画数据
>
> `U3D Document : There are handles you can drag to set the start and end of the Animation Clip to cut the take.`
>
> 通过拖拽切片来对动画切片进行剪切，也可通过 Start 与 End 完成对剪切点的选择

### Timeline Settings / 时间轴设置

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

### Root Motion / 根运动

> `U3D Document : Root nodes are used to define Root Motion in animations. Root Motion is when an animation causes GameObjects to offset from their previous position, rather than just moving in absolute terms.This means you can make movements look a lot more realistic, as they can be based on the animation itself and not simply scripted. `
>
> 根运动是指一个动画导致游戏对象的位置发生变动，而不是通过绝对值移动，这意味着你可以作出更自然的移动，因为这些移动将基于动画本身
>
> `U3D Document : For example, if a GameObject is animated to move forward on its z-axis, then with Root Motion, the GameObject would continue to move further and further along the z-axis as the animation loops. Without Root Motion, whenever the animation loops, the GameObject would return to where it started and then move forward in its z-axis again. `
>
> 例如动画中游戏对象将沿z轴移动，那么场景中随着动画的循环播放，游戏对象将一直沿z轴移动，但是如果没有根运动，那么场景中游戏对象只会随动画循环播放而不断地从初始位置移动，再恢复，再移动
>
> `U3D Document : You can fix these things by baking some elements of the Root Motion into the pose. This means they won’t affect the Root Motion at all.`
>
> 可以将切片的 Root Motion 中某些元素 bake into the pose 来使这些元素不会影响根运动

- Root Node / 根节点

  > `U3D Document : The Root node is used as a reference for this Motion.`
  >
  > 根节点用作根运动的参考

### Additional Settings / 其他设置

#### Mirror Setting / 镜像设置

> `U3D Document : This particular setting is exclusively for humanoid rigged animation.`
>
> 镜像设置针对于人形动画
>
> `U3D Document : When enabled, the Mirror setting flips the animation on the YZ plane down the character’s middle. Since this flips both the pose and the Root Motion, you can use it for making a left turn into a right turn, for example.`
>
> 勾选镜像设置后，模型YZ平面将以人物中心为轴翻转
>
> `注意:`
>
> 1. 翻转后根运动也将受影响

#### Additive Reference Pose Setting / 附加引用姿势

> `U3D Document : By using Additive Animation, you can build on and make alterations to any existing animation. `
>
> 该设置可以以已存在的动画为基础，并在此基础上作出更改，更改将覆盖原绑定的值
>
> `U3D Document : Since Additive Animation is added to an existing animation, it’s stored as deltas from a Reference Pose. Deltas are small differences or changes.`
>
> 因为附加动画已被附加至已存在的动画，所以附加动画以针对于参考/原动画姿势的增量形式存储
>
> `U3D Document : Make an animation be treated as Additive Animation :`
>
> `1. In the Inspector, enable Additive Reference Pose`
>
> `2. Select the frame number that should serve as the reference pose.`
>
> 创建 Additive Animation 的方式是先勾选附加选项，然后选择作为参考姿势的帧

#### Curves / 曲线

> `U3D Document : When Animation Clips are imported, their curves are locked and will appear as read-only. However, as part of the import process, more curves can be added so you can edit them. These curves can be used to store data that can vary over the course of the animation and should not be confused with the standard Animation Curves you have used when creating and editing Animation Clips.  `
>
> 此曲线区别于动画曲线，该曲线用于存储动画播放过程中随之改变的数据，用于编辑
>
> 1.  Select the Add (+) button under the Curves foldout. 
> 2.  Name the curve, so its value can be found at runtime. 
> 3.  Make sure the associated Animator Controller has a parameter with the same name as your curve. 
>
> `注意:`
>
> 1. 确保该曲线名称与该动画切片附加到的控制器某参数具有相同的名称

#### Events / 事件

> `U3D Document : In the Animation Importer, where there is an option for the Animation Clip to have an Animation Event added.`
>
> 导入动画模型时，可以为动画切片在没有具体游戏对象上下文的情况下添加事件
>
> `注意:`
>
> 1. 注意添加事件调用方法名需要与之后将调用的方法一致

-------
**Questions:** 

- simulation data 仿真是个什么样的动画数据？
- rather than just moving in absolute terms 什么意思？
- Root Motion / 根运动
- Curves / 曲线 曲线的名称和某控制器参数要相同？为什么要相同，是因为这个曲线控制的就是该参数嘛？

-------

2022/1/11 15:42 - 2022/1/11 21:35

-------

# Model Rig /  模型Rig

> `U3D Document : Rigs are a way of defining the structure of the model being imported and are used to define how animations play.`
>
> Rig 定义了模型导入时的结构以及其所有附加动画的播放方式

## Configuring Generic Rigs / 配置 Generic Rig

- Animation Type setting / 动画类型设置

  > 1. None
  > 2. Legacy
  > 3. Generic
  > 4. Humaniod

  **Humaniod Animation Type / 人形动画类型**

  > `1. The model has animations that are intended to be played through another Humanoid model with a different hierarchical structure.`
  >
  > 当本模型动画的用途为被不同层级结构下的人形模型使用时，需要将模型动画类型设置为 Humaniod
  >
  > `2. You’re using the model to play animations that are from Humanoid models with a different hierarchical structure.`
  >
  > 当本模型的动画使用的是不同层级结构下其他模型的动画时，需要将模型动画类型设置为 Humaniod
  >
  > `3. You want to use the built-in Humanoid features, such as arm and leg IK or target matching.`
  >
  > 当使用内置人形功能时，需要将模型动画类型设置为 Humaniod

- Avatar Definition / Avatar 定义

  > `U3D Document : Avatars are an asset representation of the model’s Rig. They take different forms depending on whether the Rig is Generic or Humanoid.`
  >
  > Avatar 是资产，在 Project 窗口可见，代表了模型的 Rig，Avatar 类型由模型 Rig 类型决定

- Root Node / 根节点设置

- Skin Weights / 蒙皮权重

  > `U3D Document : The Skin Weights setting allows you to adjust how many bones a vertex can be skinned to. `
  >
  > 可以设置一个网格体顶点可以附加多少骨骼，默认为4个

- Optimize Game Objects / 优化游戏对象

  > `U3D Document : Models can have very complicated hierarchies. This can result in having many GameObjects that are there simply to define the positions of the vertices of a skinned mesh. `
  >
  > 模型可能有复杂的层级结构，这将导致其附加有多个游戏对象仅用于表示蒙皮网格体的顶点位置
  >
  > `U3D Document : If Optimize GameObjects is enabled, all GameObjects that have no components on them are removed. The Skinned Mesh is then moved directly by the animation. `
  >
  > 启用该设置将使模型上所有没有其他组件的游戏对象被移除，蒙皮骨骼的运动将由动画驱使
  >
  > `U3D Document : To keep the GameObject(s), you need to use the Expose Extra Transforms settings. `
  >
  > 通过 Expose Extra Transforms 选项可以选择保留某些游戏对象而不被优化移除

- Generic Avatar Masks / Avatar 遮罩

  > `U3D Document : Avatar Masks are a way of preventing animation data from being written to its binding. `
  >
  > Avatar Masks 可以用于防止动画数据的值被写入到绑定
  >
  > `U3D Document : Transform data is not used from sources that have been masked.`
  >
  > 变换数据将不会被写入到被遮罩的源
  >
  > `注意:`
  >
  > 1. It’s important to remember that Avatar Masks only mask Transform data. They do not mask data on the same GameObject as a masked Transform.

## Configuring Humaniod Rigs / 配置 Humaniod Rig

> `U3D Document : The core difference between Generic Rigs and Humanoid Rigs is their Avatars. Humanoid Rigs require Avatars to play their animations, which is not the case for Generic Rigs. This is because Humanoids are a special case; their Transform hierarchy is mapped to the bones of a human-like shape.`
>
> Humanoid Rigs 区别于 Generic Rigs 的点就是 Humanoid Avatars，Humanoid Rigs 要求由 Humanoid Avatars 播放动画，人形模型的 Transform 被映射到 human-like shape 上的骨骼

### Animation Playback Process / 人形动画播放过程

> `U3D Document : Under normal circumstances, in order for an animation to be shared among multiple targets, each target must have an identical hierarchy with identical names to those on the Animation Clip. This is because the names of Transforms are used to construct the bindings of an Animation Clip. If the hierarchy through which an Animation Clip is being played doesn’t have a specific binding, the binding is just ignored. This means that if the names don’t match, the animation won’t play.`
>
> 标准绑定方式 : 要实现动画切片在不同对象下的共享，需要使播放该切片的游戏对象群具有与动画切片相同的名称层级结构 (因为切片就是通过名称来建立的绑定)，即需要具有动画切片绑定要求的字段，如果没有该字段，绑定无法建立，则动画播放时将忽略这些绑定
>
> `U3D Document : When an imported model is a Humanoid, its Animation Clips are no longer played using just standard bindings. Instead, the parts of the Animation Clips that match the Humanoid definition are played through the Avatar. `
>
> Humanoid 动画绑定 : 当导入的模型为 Humanoid 时，将不再使用标准建立切片名称与对象动画化字段的直接绑定，而是先建立与 Avatar 的 Mapping/绑定，最后由 Avatar 将值写入到对象的字段上，完成动画的播放
>
> `U3D Document : At import time, Animation Clips from Humanoid models are converted from writing to Transforms directly to writing to Muscles instead. These are called Muscle Clips. At runtime, Muscle Clips are converted back to write to Transforms. `
>
> Humanoid 动画绑定 : 在导入时，会将人形模型的动画切片作转换，使绑定由 与对象字段的直接绑定 转换为 与肌肉 的绑定，转换后形成 Muscle Clips，再将值 写入到 / 绑定 到对象的动画化字段上
>
> `U3D Document : Because all humanoids have this mapping, any Humanoid Animation Clip can be played through any Humanoid model.`
>
> 所有 humanoids 具有该映射(肌肉绑定)，因此该动画切片可以被所有人形模型共享

On import : Animation Clip with Transform bindings → Humanoid Avatar → Muscle Clip

At runtime : Muscle Clip → Humanoid Avatar → set Transform properties

### Avatar configuration / Avatar 配置

#### Mapping / 绑定

> `U3D Document : The mapping defines exactly which of the model’s Transforms is linked to which of the pre-defined Humanoid bones.`
>
> 定义模型的 Transforms 具体绑定到 Avatar 哪一个预定义的人形骨骼上
>
> `U3D Document : Each dot on the diagram refers to a bone. If the dot has a solid outline then the bone is required in order for the mapping to work. If the dot has a dotted outline, the bone is optional. The more optional bones you map, the higher the quality of the retargeting.`
>
> human-like shape 上的每一个点代表骨骼，实心代表必须建立人形模型与该骨骼的映射，非实心表示可选，可选骨骼越多，重定向质量越高

- Automap 自动完成骨骼的映射

- Animation Pose / 标准姿势

  > `U3D Document : They form a reference pose from which animations are measured. Each rotation and translation in an animation is compared to this reference pose when it’s converted to and from a Muscle Clip. Because this pose is so important, Unity uses a standard animation pose as the target all humanoid models should aim for: the T-pose.`
  >
  > Avatar 中每个 Transforms 将具有旋转与位置属性，他们将形成一个参考姿势，这些属性在进行 Avatar <--> Muscle Clip 之间的转换时会被参考，因此 Unity 使用 T-pose 作为默认参考姿势，建议在 Mapping 时将 pose 强制为 T-pose

#### Muscles & Settings / 肌肉设置

> `U3D Document : Muscle definitions exist as a range within or beyond which a bone is expected to rotate on a given axis. `
>
> 肌肉以范围的形式存在，代表骨骼绕指定轴可旋转的范围

- Normalised Range / 统一化范围

  > `U3D Document : This range is normalised, which means that rotations at one end of the range would have a value of 0 and rotations at the other end of the range would have a value of 1.`
  >
  > 标准的范围为 [0,1]
  >
  > `U3D Document : Transform rotations are converted into these normalised rotation ranges at import time. The normalised rotation ranges are then converted back into Transform rotations at runtime.`
  >
  > Muscle 将于 导入时 转换为 Normalised Range 统一范围，运行时再进一步根据具体 Muscle 范围定义转换为 Transform rotations 具体旋转，这样可以方便于重定向，因为不同人形模型的 Muscle 范围定义可能不同，当动画某一帧要求旋转指定角度时，需要先参照 Avatar 的 Muscle 的标准范围，再进一步转换为实际 Transform rotations

#### Humanoid Avatar Masks / Avatar 遮罩

> `U3D Document : Avatar Masks are a way of preventing animation data from being written to its binding. `
>
> Avatar Masks 可以用于防止动画数据的值被写入到绑定
>
> `U3D Document : Transform data is not used from sources that have been masked.`
>
> 变换数据将不会被写入到被遮罩的源
>
> `注意:`
>
> 1. It’s important to remember that Avatar Masks only mask Transform data. They do not mask data on the same GameObject as a masked Transform.

-------

**Question :** 

- Avatar Masks 的具体设置不是很理解
- You want to use the built-in Humanoid features, such as arm and leg IK or target matching. 谁使用内置人形功能？人形功能是什么样的功能？
- Normalised Range 与 Transform rotations 的转换

-------

2022/1/12 15:51