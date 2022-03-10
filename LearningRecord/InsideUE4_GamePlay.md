注意: 类体结构以旧版本为主，目前以能看懂源码为主，具体深入到某一个类时，以源码为主！

# Actor and Component

## UObject

> 元数据，反射生成，GC垃圾回收，序列化，编辑器可见，Class Default Object.

## Actor

> Replication / 网络复制，Spwan / 创建销毁，Tick / 心跳.

### Actor Hierarchy / 层级

> TArray<AActor*> Children，Actor 中存放了子 Actors 的数组.
>
> `注意:`
>
> 1. AActor::AttachToActor()，通过子 Actor 完成 Actor 父子关系的搭建.

### Tranform / 变换

> 在 Unity 中通过带 transform/变换 的 GameObject 来代表游戏中的对象.
>
> Ue 中的 Actor 不仅仅是3D游戏对象的表述，而还可代表整个世界的运行规则等种种元素，其变换属性封装在 SceneComponent 中，即使是 Actor 的 GetActorLocation,SetActorLocation 等操作 transform 的方法，最终都是转发到 SceneComponent 下执行的.

## Component / 组件

> Ue 借鉴 Unity 的组件式构建对象的方法，通过 UActorComponent 的派生类来组装 Actor 的各项功能.

### SceneComponent / 场景组件

> Transform 变换仅存放于该组件中.
>
> 仅 SceneComponent 的组件之间可相互嵌套.
>
> `注意:`
>
> 1. AActor::AttachToComponent(...)，通过子组件完成组件父子层级的搭建.
> 2. 一个 Actor 可能包含多个 SceneComponent 组件，需要通过参数指定具体应附加到哪一个插槽，跟随父 Actor 哪一个 SceneComponent 的变换，其本身变换通过在 Location,Roator,Scale上应用 Rule 来计算.
> 

### ActorComponent / Actor 组件

> ActorComponent 仅仅能附加于 Actor 对象下，不能够相互嵌套.
>
> `注意 : `
>
> 1. Ue 更推崇使组件功能单一，不希望出现大管家之类的组件.
> 2. Ue 仍不希望游戏逻辑代码出现在组件中，而 Unity 的脚本作组件挂载.

## Actor and Component / 关系

> TSet<UActorComponent*> OwnedComponents，Actor 通过集合保存着其在游戏 当前Level 下拥有的所有组件，其中一个组件作 RootComponent，一般为 SceneComponent.
>
> TArray<UActorComponent*> InstanceComponents ，Actor 通过 TArray 保存着所有的实例化组件(创建蓝图类时定义的组件).

# Level and World

## Level / 关卡

> Level 相当于 Actors 的容器.
>

```
Class ULevel -> UObject
-------------
TArray<AActor*> Actors; / Level 下的所有 Actors
ALevelScriptActor* LevelScriptActor; / 关卡蓝图
TArray<UModelComponent*> ModelComponents; / Level 下的基元 BSP Geometry
-------------
AWorldSettings* WorldSettings(Actors[0]);
```

### WorldSettings

> 存放着与关联 Level 相关的设置.
>
> `注意:`
>
> 1. 若 WorldSettings 关联的 Level 为 World 的 PersistentLevel，则该 WorldSettings 将作为整个 World 的 WorldSettings.

### LevelScriptActor / 关卡蓝图

> 关卡蓝图可包含此关卡下的一些运行规则，提供编写脚本的功能.
>
> `注意:`
>
> 1. Ue 不希望在 LevelScriptActor / 关卡蓝图 中出现太多逻辑代码.
> 2. LevelScriptActor 派生于 AActor，具备挂载组件的功能，但是不允许你挂载组件.

## World / 世界

> 对所有 Levels 的组装.
>
> `注意:`
>
> 1. 可以以 SubLevel 方式进行组装，也可以以 WorldComposition 方式进行组装.

```
Class UWorld -> UObject
-------------
TArray<ULevel*> Levels; / World 下的所有 Levels
AGameMode* AuthorityGameMode; / 游戏模式
AGameState* GameState; / 游戏状态
UWorldComposition* WorldComposition; / Levels 组合
FPhysScene* PhysicsScene; / 各 Level 共享的全局物理
-------------
ULevel* PersistentLevel; / 主关卡
ULevel* CurrentLevel; / 当前关卡
TArray<ULevelStreaming*> StreamingLevels; / 动态关卡流
UGameInstance* OwningGameInstance; / World 拥有的 GameInstance
TArray<TAutoWeakObjectPtr<AController>> ControllerList;
TArray<TAutoWeakObjectPtr<APlayerController>> PlayerControllerList;
TArray<TAutoWeakObjectPtr<APawn>> PawnList;
```

### PersistentLevel / 主关卡

> 即 World 初始加载的默认关卡，每个关卡均有独立的 WorldSettings，而在 World 范围内起作用的配置项需要以 PersistentLevel / 主关卡 为主.

### EWorldType / World 类型

> World 不仅仅只有一种类型，一个世界也不仅仅只有一个World.

```
namespace EWorldType
{
	enum Type
	{
		None,		// An untyped world, in most cases this will be the vestigial worlds of streamed in sub-levels
		Game,		// The game world
		Editor,		// A world being edited in the editor
		PIE,		// A Play In Editor world
		Preview,	// A preview world for an editor tool
		Inactive	// An editor world that was loaded but not currently being edited in the level editor
	};
}
```

# WorldContext and GameInstance and Engine

## WorldContext

> 用于管理跟踪 World 的管理类.
>
> 可以保存切换 World 的过程信息，与目标 World 的上下文信息.
>
> 还保存着 World 下 Level 切换的上下文信息.
>
> `注意:`
>
> 1. WorldContext 可以管理 World 的更替，但是不应由外部直接操作，Ue内部负责.

```
Class FWorldContext -> UWorld
-------------
UGameInstance* OwningGameInstance; / ???
UWorld* ThisCurrentWorld; / 当前 World 类型
UGameViewportClient* GameViewport; / 
-------------
FString TravelURL; / 切换的下一目标 Level
uint8 TravelType; / 切换的下一目标 Level 类型
```

### Level Traveling / 关卡切换

> OpenLevel : 
>
> 先设置当前 World 的 WorldContext 中的 TravelURL，然后在 UEngine::TickWorldTravel 中判断 TravelURL 是否非空来真正执行 Level 的切换.
>
> `注意:`
>
> 1. 关卡切换的信息不存放于 World 中，虽然 LoadStreamLevel 在切换时可以存放于 World 中，但是 World 的 PersistentLevel 在切换时，会将当前 World 释放.

## GameInstance

> 保存当前 World 的 WorldContext，以及其他整个游戏的信息.

```
UGameInstance| -> UClass | ◇-> FWorldContext
-------------
ULocalPlayer* CreateLocalPlayer(...); / 创建Player
AGameModeBase* CreateGameModeForURL(...); / GameMode的重载修改
-------------
FWorldContext* WorldContext;
TArray<ULocalPlayer*> LocalPlayers; / 管理本地Player
UOnlineSession* OnlineSession; / 网络会话管理
```



## Engine

> GEngine，源码开始的地方，其引用一个 UEngine.
>
> `注意:`
>
> 1. World 与 Level 的切换的实际发生地是 Engine.

```
Class UEngine
-------------
TIndirectArray<FWorldContext> WorldList; / 所有 World
-------------
```

### UGameEngine

> 一般 GameEngine 下只有一个 WorldContext，直接通过 GameInstance 引用.

```
Class UGameEngine -> UEngine
-------------
UGameInstance* GameInstance;
-------------
```



### UEditorEngine

> 一般有两个 WorldContext，一个用于 EditorWorld，一个用于 PlayWorld / PIE World，通过 WorldContext 下的 GameInstance 间接引用.

```
Class UGameEngine -> UEngine
-------------
UWorld* PlayWorld;
UWorld* EditorWorld;
TArray<FEditorViewportClient*> AllViewportClients;
-------------
```



# GameMode and GameState

## GameMode / 模式

> 游戏的唯一逻辑操纵者.
>
> 一个 World 下只会有一个 GameMode  实例，即PersistentLevel 下的 GameMode.  
>
> `注意:`
>
> 1. 每个 Level 下也存着独立的 GameMode 实例.

```
Class AGameMode -> AInfo
-------------
void InitGame(...); / 初始化游戏
void SetMatchState(...; / 设置游戏运行状态
-------------
FName MatchState; / 游戏运行状态
AGameSession* GameSession; / 游戏会话用于网络联机
AGameState* GameState; / 存储游戏状态
uint32 bUseSeamlessTravel ：1; / 启用无缝切换
```

 ### Responsibility / 职责

1. Class 登记

   > 记录基本的游戏类型信息，用于在需要时通过 UClass 反射可以自动 Spawn 出对象并添加至关卡中. 

2. 控制游戏内实体的 Spawn

   > 包括 玩家，AI 的加载与释放，生成的位置，所处的状态，数目等等.

3. Level 的无缝切换

   > AGameModeBase::bUseSeamlessTravel = true 后可以实现无缝切换.
   >
   > 1. 标记出要在过渡关卡中存留的 Actors
   > 2. 转移至过渡关卡
   > 3. 标记出要在最终关卡中存留的 Actors
   > 4. 转移至最终关卡
   >
   > `注意:`
   >
   > 1. 为避免同时加载两个大地图，则需要引入很小的过渡关卡作中转，减少转换时的资源损耗.
   > 2. 若为设置过渡关卡，则默认创建一个空关卡.

4. 多人游戏的同步

   > 标识整个游戏运行的状态.

### Travelling GameMode / 模式切换

> 在关卡切换时，World 下的 GameMode 也会发生变换.

- 非无缝切换

  > AGameModeBase::bUseSeamlessTravel = false.
  >
  > 新的 World 加载时，当前的 GameMode 将被释放，根据新 World 的配置生成新的 GameMode.

- 无缝切换

  > AGameModeBase::bUseSeamlessTravel = true.
  >
  > CurrentWorld -> TransitionWorld : GameMode 也将被迁移，即 TransitionWorld 下保存着 CurrentWorld 的 GameMode.
  >
  > TransitionWorld -> NewWorld : 根据配置重新生成一个 GameMode.

### GameMode and LevelScriptActor 

> GameMode 更注重整个 World 下，所有 Levels 的通用规则与逻辑，如胜利条件，怪物刷新等.
>
> LevelScriptActor 更注重具体 Level 下表现行为.
>
> GameMode 只在 Sever 中存在(单机游戏也是 Server)，因此对于 Client 的状态与逻辑，GameMode 无法控制，需要通过客户端具体关卡的 LevelScriptActor / 关卡蓝图 中的逻辑控制.

## GameState / 游戏状态

> 保存游戏的状态数据，包含整个游戏的状态数据以及所有的 PlayerState.
>
> `注意:`
>
> 1. GameState 在客户端存在，GameMode 下的状态数据可通过 GameState 传递.

```
Class AGameState -> AInfo
-------------
void SetMatchState(...); / 同步游戏运行状态
void AddPlayerState(...); / 管理 World 下的 PlayerState
-------------
Fname MatchState;
TArray<class APlayerState*> PlayerArray;
```

## GameSession / 游戏会话

> 针对网络 Session 的一个方便管理的类.

![v2-732b99e7784299a93449256f076eea76_r](Images\v2-732b99e7784299a93449256f076eea76_r.png)



**Questions:**

- BSP 基元组件 与 网格体组件关系？
- PersistentLevel 与 CurrentLevel 有什么关系？
- Level 下会有自己的 GameMode？？
- 对 World 的概念不是很理解
- OpenLevel 是用于切换 Level ？还是 World ？
- UGameViewportClient？？？
- 项目杂，不好下手

