# Skeletal Mesh Animation System - Ue骨架网格体动画系统

# The Current Progress / 当前进度

- Unity初级编程 - 中级编程 / √
- 动画系统demo实践 完成模型导入-> 动画绑定 -> 状态机组织动画 / √
- 工具 fbx -> motiondate -> 中间数据 / √
- ue4状态机 + AI + 行为树 / ing
- 着手AIAnimation框架，着手动画系统的改写



- **Animation Sequences**
- **Anim Montages**
- **Morph Targets**
- **Skeletal Controls**
- **State Machines**

- [动画混合](https://docs.unrealengine.com/4.27/zh-CN/AnimatingObjects/SkeletalMeshAnimation/NodeReference/Blend) - 使用不同混合节点进行完成。
- [动画节点](https://docs.unrealengine.com/4.27/zh-CN/AnimatingObjects/SkeletalMeshAnimation/NodeReference) - 用于在输入姿势上执行如混合、直接骨骼操控等操作。
- [动画序列](https://docs.unrealengine.com/4.27/zh-CN/AnimatingObjects/SkeletalMeshAnimation/Sequences/UserGuide) - 可直接放入AnimGraph中驱动最终动画姿势。
- [混合空间](https://docs.unrealengine.com/4.27/zh-CN/AnimatingObjects/SkeletalMeshAnimation/Blendspaces/UserGuide) - 可在AnimGraph中使用，以基于变量混合姿势。
- [骨架控制](https://docs.unrealengine.com/4.27/zh-CN/AnimatingObjects/SkeletalMeshAnimation/NodeReference/SkeletalControls) - 可直接用于驱动骨架内骨骼的节点。
- [空间转换](https://docs.unrealengine.com/4.27/zh-CN/AnimatingObjects/SkeletalMeshAnimation/NodeReference/SpaceConversion) - 可切换姿势在局部空间或组件空间内的节点。
- [状态机](https://docs.unrealengine.com/4.27/zh-CN/AnimatingObjects/SkeletalMeshAnimation/StateMachines) - 是一系列图表、规则和变量，可决定角色要进入的动画状态。
- [同步组](https://docs.unrealengine.com/4.27/zh-CN/AnimatingObjects/SkeletalMeshAnimation/SyncGroups) - 可用于保留已同步不同长度的相关动画。



- Code Driven
- Data Driven
- 虚拟骨骼
- 坐标系
- Mesh空间
- 骨骼空间
- 坐标系的变换与渲染
- 4*4矩阵

# Skinned Mesh Animation / 骨骼蒙皮动画

> 骨骼蒙皮动画独立出了两个概念，一个是骨骼，一个是蒙皮，其核心原理是由骨骼来决定模型顶点的最终世界坐标，动画数据直接包含的不是模型顶点变换数据，而是骨骼的运动信息，进而由骨骼变换来驱动 Skinned Mesh 顶点的变形，进而形成动画

- Skinned Mesh 应包含 动画数据，骨骼数据，含Skin Info的Mesh数据，BoneOffset Matrix 骨骼偏移矩阵用于组织动画

## Bone Struct / 骨骼结构

### Bone  and Joint Defination / 骨骼关节定义

> 骨骼可以理解为一个**坐标空间**.
>
> 关节为骨骼坐标空间的原点，用来描述骨骼的位置(以该关节为原点的骨骼)，骨骼位置即该原点在父坐标空间(骨骼)中的位置，关节不仅决定了骨骼空间的位置，又是骨骼空间的旋转与缩放中心.
>
> `注意:`
>
> 1. Bone 下的位置信息不是真实骨骼的位置，因为该骨骼并不实际存在，而是该坐标空间(骨骼)原点在父坐标空间(骨骼)中的位置信息
> 2. 4*4 的矩阵可以用来同时描述骨骼的位置，旋转，缩放信息
> 3. 骨骼的长度由关节位置与蒙皮结果决定

### Bone Hierarchy / 骨骼层级

> 骨骼层级为嵌套的坐标空间，父坐标空间的变换带动子坐标空间变换.
>
> 可以认为 root 骨骼的父坐标空间为世界坐标空间，root 骨骼的位置即整个骨骼体系在世界坐标中的位置，进而由父骨骼的运动驱动子骨骼的运动，子骨骼的运动信息将由计算自动得出.
>
> `注意:`
>
> 1. 可使用额外骨骼用于定位动画模型整体的世界坐标，一般会在人双脚之间额外添加一根 root 骨骼，并不是实际存在，但是可以以此为准，使得当设置整个人物模型位置为(0,0,0)时，可以使人物在地面之上

### UpdateBoneMatrix Update / 骨骼更新

> 根据时间从动画数据中获取当前时刻的 *Transform* Matrix 变换矩阵

**TransformMatrix 变换矩阵** 

> TransformMatrix 可以记录骨骼坐标空间相对于坐标原点的变换信息(骨骼的变换信息)，逐帧更新
>
> `注意:`
>
> 1. TransformMatrix 变换信息是相对于父骨骼而言的
> 2. 变换信息可包含位置，旋转，缩放信息
> 3. 动画数据也可包含骨骼旋转，缩放信息，动画数据，因此动画关键帧数据可仅通过四元数表示，而位置由 TransformMatrix 表示

**CombinedMatrix 世界变换矩阵**

> 骨骼最终带动的网格顶点的变换需要使用 CombinedMatrix 世界变换矩阵

## Skinned Mesh / 蒙皮网格体

> Skinned Mesh 实际上是具有 Skin Info 此类蒙皮信息的特殊网格体.
>
> `注意:`
>
> 1. 网格体模型的顶点定义在网格体模型坐标系中，而骨骼关节定义在骨骼坐标系中，若要使骨骼驱动网格体顶点于世界坐标系中的变换，需要  Skin Info 此类蒙皮信息 使网格体顶点可以与骨骼关节建立关联.

### Skin Info / 蒙皮信息

> Skin Info 可定义在顶点中，包含有最大链接骨骼数，关联到的骨骼实例数组，对应到每个骨骼实例的作用权重数组

## Mesh deform / Mesh 形变

> 骨骼网格体动画，骨骼随时间变换，顶点位置随骨骼变换，而每个顶点又可关联多根骨骼，在将顶点与相应骨骼建立关联后，可依次计算顶点在各个骨骼驱动下的世界坐标，进而根据权重进行加权平均，得到最终在多根骨骼影响下的世界坐标
>
> `注意:`
>
> 1. 实际上是依据关联骨骼坐标空间下的 TransformMatrix 计算其在该骨骼空间影响下的世界坐标，该 TransformMatrix 会逐帧更新的

### Vertex Calculation Process / 单个骨骼下的顶点变换计算流程

> Mesh Vertex (Mesh Space) -- [BoneOffsetMatrix] -> Mesh Vertex (Bone Space) -- [BoneCombinedTransformMatrix] -> Mesh Vertex (World Space)

1. 要通过骨骼计算出顶点的世界变换，需要先将顶点坐标变换至关联骨骼的骨骼坐标空间中
2. 利用关联骨骼的世界变换，计算变换后顶点的世界坐标

#### BoneOffset Matrix / 骨骼偏移矩阵

> BoneOffset Matrix 可以将模型顶点坐标变换至关联骨骼的坐标空间.
>
> `注意:`
>
> 1. BoneOffset Matrix 保存在 Bone 下，以便当 Bone 关联多个顶点时，无需保存每个顶点在骨骼坐标空间的坐标，只需要保存变换方式即可，只需通过该变换计算坐标
> 2. 因为 BoneOffset Matrix 需要根据对应骨骼在初始姿势下的 TransformMatrix 得出，因此其包含的相关信息依赖于对应 TransformMatrix 

#### BoneOffsetMatrix and BoneCombinedTransformMatrix 关系

- 一般为互为逆矩阵

> 若 Mesh Space 与 World Space 坐标原点重合，即 Mesh 与 World 空间重合，则它们为互为逆矩阵的关系.
>
> `注意:`
>
> 1. 若 Mesh 与 World 空间不重合，则需要先将顶点数据由 Mesh Space 变换至 World Space，再执行后续变换

​	由 指定Bone Space 变换至 World Space，需要通过其 TransformMatrix(指定Bone Space 至 父Bone Space 的变换矩阵 ) 向上逐层变换，直至由 Root Bone Space 得到 Combined Transform Matrix (由 Bone Space 到 World Space 的变换矩阵)，可通过此矩阵计算得出 指定Bone Space 中的变换在 World Space 下的变换，由于 World Space 与 Mesh Space 重合，即得到了 指定Bone Space 到 Mesh Space 的变换矩阵，反之即为逆矩阵

- Initial Pose / 初始姿势

  > 骨骼层级建立后的还未动画化的初始姿势，一般为T型

## Calculation Process / 流程概要

- 载入并建立骨骼层次结构，根据 Initial Pose 计算 TransformMatrix，进而计算 BoneOffset Matrix
- 载入含 Skin Info 蒙皮信息的 Mesh 数据
- 逐帧获取动画数据，更新各骨骼的 Transform Matrix，计算各 Bone Space 至 World Space 的变换矩阵 CombinedMatrix
- 对网格各个顶点根据 Skin Info 信息，通过 BoneOffset Matrix 关联至相应 Bone Space，进而计算各骨骼影响下的世界坐标的加权平均，用于最终顶点的渲染
