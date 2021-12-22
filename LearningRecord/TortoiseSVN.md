# TurtoiseSVN

>  SVN乌龟客户端

## ----------First Things-----------

1. 领取SVN授权账号
2. checkout项目组代码调试

## -------Basic Operatings-------

## CheckOut 检出提取

> 将远程代码库中的项目clone到本地指定目录，创建一个工作副本

1. URL of repository

   > 远程代码库的url地址
   >
   > 具体菜鸟教程 or CSDN 需要时检索 版本库浏览器简化了一系列操作

   `注意:`

   1. checkout时的版本地址不能直接使用地址栏中的地址，需要版本库页面生成的Repository URL地址
   2. svn不会自动创建远程代码库的目录，直接将最后目录的文件clone下来，因此需要将远程库中指定的文件夹包含到自己指定的目录层级中

2. Checkout directory

   > clone代码库的目录层深度，中文版本直接对即可

   - Fully recursive：全递归。检出完整的目录树，包含所有的文件或子目录；
   - Immediate children,including folders：直接子节点，包含文件夹。检出当前所选目录（在本文中对应目录为 cgi_oss，下同），包含其中的文件或子目录，但是不递归展开子目录；
   - Only file chlidren：仅文件子节点。检出当前所选目录，包含所有文件，但是不检出任何子目录；
   - Only this item：仅此项。只检出目录，不包含其中的文件或子目录；
   - omit externals：忽略外部设备，默认不选；
   - choose items：选择项目，默认不选；

3. Revision

   > 版本信息选择

   - Head revison: 最新版本代码
   - Revision: 根据展示的log历史版本选择指定版本进行clone

## Commite 提交

> 当你已经修改了代码，你需要Commit到repository，这样repository才会更新
>
> add -  添加至版本控制系统 
>
> commit - 将更改上传至远程仓库
>
> 具体菜鸟教程 or CSDN 需要时检索 版本库浏览器简化了一系列操作

## UpDate 更新

> 当你已经Checkout了一份源代码有段时间， Update以便与repository同步，保证手上的代码有最新的变更
>
> 具体菜鸟教程 or CSDN 需要时检索 版本库浏览器简化了一系列操作

## -------Other Operatings--------

## Revert 回退

> Revert 可以重置对工作副本的修改，他可以重置一个或者多个文件/目录

## Merge 合并 + Resolve 解决

> Merge可以自动处理可安全合并的东西，其余的会当做冲突
>
> Resolve是在用户手动解决冲突后通过该操作告知版本库如何处理这些冲突

## Brunch / Tag

> Subversion 建立分支与标签的方法, 就只是复制该项目, 使用的方法就类似于硬连接 (hard-link) 所以这些操作只会花费很小, 而且是固定的时间

- - -

# AIAnimation

