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

- 动画切片的组成 - 绑定是什么概念？一对一绑定是什么东西？

--------

2022/1/7 21:42 - 2022/1/10 17:52