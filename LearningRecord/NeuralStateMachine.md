# Siggraph Asia 2019 - 用于角色与场景交互动画的神经状态机

# The Current Progress / 当前进度

- Unity初级编程 - 中级编程 / √
- 动画系统demo实践 完成模型导入-> 动画绑定 -> 状态机组织动画 / √
- 工具 fbx -> motiondate -> 中间数据 / √
- AIAnimation框架，神经状态机了解 / ing
- ue4状态机 + AI + 行为树
- 着手Ue版动画系统的架构

# Outline / 概要

> `With the Neural State Machine as the core machinery, we achieve the smooth transitions in high-level states with a goal-driven control while realizing precise scene interactions with a bi-directional character control scheme and volumetric sensors.`
>
> 以神经网络状态机为核心机制，通过目标驱动控制实现高级状态的平滑过渡，通过双向角色控制方案与体积传感器实现精确的场景交互

# Neural State Machine / 神经状态机

> `The Neural State Machine consists of a Motion Prediction Network and a Gating Network. `
>
> 神经状态机主要由两部分组成，如下图，一部分为 Gating Network / 门控网络，另一部分为 Motion Prediction Network / 运动预测网络



![image-20220210105722924](C:\Users\Yundid\AppData\Roaming\Typora\typora-user-images\image-20220210105722924.png)

## Gating Network / 门控网络

>  `The Gating Network decides the blending coefficients of expert weights based on the given goal and the phase of the motion to dynamically generate the Motion Prediction Network. The intuition behind this design is to encode different modes of motion in drastically different tasks separately in multiple experts to avoid blurry motions and adapt to different tasks. We further modulate the expert blending weights using a learned cyclic function to ensure the state will move forward in time.`
>
> 门控网络决定了专家权重的混合系数，进而动态的生成运动预测网络.
>
> 专家混合系数会进一步调节以保证运动状态将及时更新

### Input / 输入

> `Input Features of the Gating Network: We design the input features of the gating network such that the expert weights are selected and interpolated according to both the action labels and phase values. At each frame i, the input of the Gating Network Xˆ i is computed by composing two vectors as follows: Xiˆ = Pi ⊗ X′`
>
> Pi : 2D相位矢量
>
> X' : 含有当前动作，目标位置，目标朝向，沿整个运动轨迹的目标动作

### Output / 输出

> ω = Ω(Xˆ;µ) = σ(W′2 ELU( W′ 1 ELU( W′0 Xˆ + b′0 ) + b′1 ) + b′2)
>
> `ω is the blending coefficients of the expert weights to compute the network parameters of the Motion Prediction Network; `
>
> 门控网络将通过以上运算得出专家权重的混合系数以用于计算运动预测网络的网络参数，即用于生成运动预测网络

## Motion Prediction Network / 运动预测网络

> `The Motion Prediction Network is the main component of our system where it computes the pose of the character in the current frame, given the pose in the previous frame, the geometry of the surrounding environment, and the high-level instructions including the goal location and the action state.`
>
> 运动预测网络基于之前帧中的角色姿势，周边环境的几何体，含有目标位置和动作状态的高级指令，最终计算当前帧角色的姿势，其含有两个模块，分别是编码器模块与预测模块

- Encoder Module / 编码器模块

  > `This module receives the components of the character state in the previous frame and encodes them individually using simple three-layer networks.`
>
> 该模块提取角色状态中的四个分量，并使用简单的三层网络分别编码

- Prediction Module / 预测模块

  > `This module receives the output of the encoder module and predicts the state of the character in the current frame. The prediction module is a three-layer network whose weights are dynamically blended from a group of expert weights with coefficients from the Gating Network.`
  >
  > 预测模块接受编码器模块的输出对当前帧的角色状态进行预测，该网络层的权重由混合系数与专家权重组合动态混合而成

### Input / 输入

> `The inputs of the Motion Prediction Network Xi at frame i consist of four components, namely the Frame Input Fi, Goal Input Gi, Interaction Geometry Input Ii and Environment Geometry Input Ei, such Xi = {Fi , Gi , Ii , Ei }.`
>
> 预测网络于当前帧的输入包含四部分，F(i)，G(i)，I(i)，E(i)

- Frame Input F(i)

  > 1. 角色在 i-1 帧的**角色姿势**(23个关节的位置、旋转值与相对于根坐标的速度)
  > 2. **根**在采样时间段(in the past/future in a 2 second window)内的**轨迹线数据**(采样范围内的坐标、前向向量数据)，相对于 i-1 帧
  > 3. 采样时间段内连续的**行为标签**，该行为标签会在每一个t轨迹点上由0到1变化

- Goal Input G(i)

  > 1. 目标位置，目标沿采样轨迹线的朝向
  > 2. 目标点的热动作标签(目标行为标签)

- The Interaction Geometry Input I(i) and Environment Geometry Encoder Input E(i)

  > 角色周围交互对象的体积表示

### Output / 输出

> `The outputs are used to animate the character, directly fed back into the inputs or blended with the user inputs to be a control signal for the next iteration. `
>
> 该网络层的输出将用于动画化角色，并且将直接反馈到输入或者与用户输入混合，形成控制信号用于下一次迭代预测 - 自回归

- 角色坐标系统中的角色姿态预测结果
- 在角色坐标系统中的未来的（1秒内）根的轨迹
- 在目标坐标系统中的未来的（1秒内）根的轨迹
- Goal Output G0(目标数据的更新值)，含更新后的位置，朝向与目标行为等
- 关键关节的接触点标签，用于IK
- 当前的相位更新

# Goal-Driven Character Control / 目标驱动的角色控制

> `Our system has two modes of control: the high-level goal-driven mode and the low-level locomotion mode.`
>
> 该系统提供两个控制模式，高级目标驱动模式，低级运动模式，并且可以无缝切换

- High-level goal-driven mode / 高级目标驱动模式

  > 鼠标选中目标对象，再通过键盘按键执行欲执行的行为

- Low-level locomotion mode / 低级运动模式

  > 键盘控制角色行走/奔跑

# Bi-Directional Control Scheme / 双向控制方案

> `The idea of the bi-directional controller is to infer the motion from both the egocentric and goal point of view, match both predictions during runtime, and feedback such inference into the Neural State Machine to increase the precision of the character to reach the goal during the tasks`
>
> 双向控制方案可以从角色与目标两个角度同时出发，预测角色的轨迹，运行时将两种预测都反馈给神经状态机，以提高角色轨迹的精度
>
> `Instead, predicting such information in the goal-space gives more accurate values for where the character would actually need to be, and back-transforming those into root-space during runtime enables avoidance of such error accumulation. `
>
> 双向控制方案可以从目标角度出发，更精确地提供角色的轨迹预测值，并于运行时将信息反向转换至角色根空间，解决了单向控制方案存在的误差累积问题，尤其在数据量不足时，由随机位置运动到目标点，效果显著
>
> `In more detail, the bi-directional controller is part of the Neural State Machine and computes the future trajectory in the goal-centric coordinate system `
>
> 双向控制时神经状态机的一部分，从目标坐标系出发计算角色未来的根轨迹

# Volumetric Sensors / 体积传感器

> `We use two voluemtric sensors to evaluate the status of the body with respect to the object: the Environment Sensor and the Interaction Sensor.`
>
> 使用体积感知器来评估角色与目标物体的空间状态，一个是环境感知器，一个是交互感知器

- Environment Sensor / 环境感知器

  > `To recognize the surrounding geometry of the character and let it affect the motion in the next frame, we use a volumetric sensor that we call the Environment Sensor that has a cylindrical shape. The collision between objects/environment and a cylindrical volume of radius R and height H is evaluated while the character is moving and fed into the Environment Geometry Input Ei.`
  >
  > Environment Sensor 使用一个半径为 R，高度为 H 的圆柱体，在角色运动时评估角色与目标物体的碰撞，并将结果写入Ei，传至神经状态机中，影响角色下一帧的运动
  >
  > `Within the volume, spheres of radius r << R are sampled and their intersections with the objects/environment are tested.`
  >
  > 圆柱体中将使用半径为 r<<R 的球体对目标物体与圆柱体的交集部分进行采样，这样可以提供连续的输入用于碰撞计算，从而产生更平滑的动作

- Interaction Sensor / 交互感知器

  > `We prepare another volumetric sensor that we call the Interaction Sensor to provide further details of the object geometry from the goal point of view.`
  >
  > Interaction Sensor 可以从目标几何体出发，提供目标几何体的具体细节，如椅子的扶手，以便角色作出更精确的动作
  >
  > `As the Environment Sensor can be too coarse, and the character can be moving, the fine details of the object, such as the arm rests of the chair, can be missed.`
  >
  > Environment Sensor 从角色出发，以圆柱体 + 球体感知周围物体，可能忽略目标物体的细节，而通过 Interaction Sensor 可以弥补该缺陷

# Data Preparation / 数据准备

- Motion Capture / 动捕数据

- Motion  Labelling / 动作标签

  > 每一帧的数据都会标记一个动作标签，标签含有以下内容
  >
  > 1. 当前动作标签
  >
  > 2. 目标动作标签
  >
  > 3. 当前的相位标量
  >
  > 相位标量用于确定角色在 周期运动(行走)/非周期运动 中的具体位置信息

- - - - -

**Questions :** 

- 相位向量？
- 预测模块预测处状态，怎么进行的状态过渡？哪一模块负责了值的写入？
- 训练得出的数据集的作用在于？更好的预测？在哪一模块被使用？




- - - -

