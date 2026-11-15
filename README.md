# PCL2 2.14.0.0 反编译修复版（可编译）

> 本仓库是 **Plain Craft Launcher 2（PCL2）2.14.0.0 经 ILSpy 反编译、并系统修复后可以编译（且可运行）的源码**。
> 未修改的原始反编译输出在 [`raw-decompiled`](../../tree/raw-decompiled) 分支。

> **制作**：反编译、全部修复、文档由 **DSH**（DeepSeek Harness 编码智能体，模型 **DeepSeek-V4.1-Flash-1017**）完成；项目维护者与需求方为 **LoneExplorer337**。

## 编译

```
cd src
dotnet build -c Release
```

| 项目 | 值 |
| --- | --- |
| 目标框架 | .NET Framework 4.8（`net48`，WPF + WinForms，`LangVersion 14.0`） |
| 构建环境 | Windows + .NET SDK（实测 11.0.100-rc.1）；NuGet 需要能拉到 `Microsoft.NETFramework.ReferenceAssemblies 1.0.3`（本机未装 4.8 引用程序集时靠它） |
| 依赖 | `src/libs/` 内 18 个 DLL（上游程序内嵌的第三方库，已随仓库提供，无需另下） |
| 实测结果 | **0 个错误 / 256 个警告 / 44 秒**（单文件配置） |
| 产物 | `src/bin/Release/net48/Plain Craft Launcher 2.exe`（5,974,528 字节，**单文件**：13 个依赖库已内嵌为资源，运行时由 `AppDomain.AssemblyResolve` 从 `PCL.Resources` 直接加载）；输出目录只剩 exe + `.exe.config` + `.pdb` |
| 运行 | 单文件实测：启动 ALIVE、日志 68 行、**0 条 E 级错误、0 条「无法加载文件或程序集」** |

## 相对原始反编译输出做了什么

### 一、让它能编译（约 800 处机械修复）

| # | 问题 | 处理 |
| --- | --- | --- |
| 1 | XAML 限定 `clr-namespace:PCL;assembly=Plain Craft Launcher 2` 导致 MC1000 | 去掉 `;assembly=...` |
| 2 | VB `WithEvents` 属性与 XAML 生成字段冲突（CS0102/CS0111，1636+98 条） | 818 个属性改写为 `Hook_X(value)` + 构造函数里调用 |
| 3 | 标记编译器重复生成 `_CreateDelegate`（CS0111） | 删除 48 处源码副本 |
| 4 | 27 个 `VB$AnonymousDelegate_N` 被 ILSpy 整类丢弃（CS0246） | 用 `ilspycmd -il -t` 取 IL 签名后重建声明 |
| 5 | `JToken.op_Implicit(...)` / `OneOf<,>.op_Implicit(...)` 显式调用（CS0571，116 处） | 改为强制转换；接口泛型转换经 `OneOfHelper.From` 绕开 C# 限制 |
| 6 | VB 宽松委托转换：0 参 lambda 绑到带参委托（CS1593，32 处） | 按委托签名补参数 |
| 7 | 嵌套类型缺失（`ManagedFile`/`HashMethod`/`ChildrenAction`/`RefAction<T>`） | 补 `using` 别名与限定名 |
| 8 | VB 允许未赋值局部变量（CS0165，15 处） | 显式初始化；闭包自引用改为 `new C((C)null)` |
| 9 | `__ldtoken(<PrivateImplementationDetails>…)` 静态数组（CS0103） | 反射解出原始数组值后写显式初始化 |
| 10 | 枚举与整数混用（CS0266/CS0030）、`TaskExtensions` 歧义（CS0104）、`Main` 解析歧义（CS0119）等 | 逐点改写 |
| 11 | VB Module → C# `static class`（CS1106）、类型名等于成员名（CS0542） | `ModBase`/`ModMain` 改 static；`Validate` 类改名 `ValidateBase` |

### 二、两处「能编译但运行必崩」的失真（关键）

1. `((BaseLogger)this).Format(...)`：IL 里是非虚调用 `call`，ILSpy 写成 C# 的 `((Base)this).X`，而 C# 按虚派发 → 调用自身重写 → **无限递归栈溢出**（实测 `0x800703E9`）。改为 `base.Format(...)`。
2. `this.InputDelegate = (Func<object>)(object)InputDelegate;`：VB 的宽松转换没有 cast，C# 对值类型泛型实例化必定抛 `InvalidCastException`（实测启动即 XamlParseException）。字段改为 `Delegate` 类型后按原语义赋值/取回。

### 三、功能性改动（很小）

- **主题全部解锁**：`ModSecret.ThemeCheckOne` 直接返回 `true`（原版按赞助等级/隐藏主题记录判定）。
- **删除赞助界面**：`关于` 页的「赞助者」卡片（40 余 KB 的内联名单 + 生成/输入土豆码按钮）、系统设置的识别码/土豆码按钮、个性化页的赞助提示面板与主题解锁覆盖层；`关于` 与 `特别鸣谢` 两张卡片保留原样。
- **删除主题的悬浮描述**（8 条 ToolTip）。

其余逻辑（含更新检查、公告、遥测开关等）保持原版行为未动。

## 与其它仓库的关系

| 仓库 | 内容 |
| --- | --- |
| 本仓库 `main` | 反编译 + 修复后的**可编译**源码（本文件所在分支） |
| 本仓库 `raw-decompiled` | **未修改**的 ILSpy 原始输出（不可编译，仅作对照） |
| [PCL-SERVER-BY-LoneExplorer337](https://github.com/LoneExplorer377/PCL-SERVER-BY-LoneExplorer337) | 在本源码基础上继续改造的成品：服务端模式、下载页客户端/服务端切换、插件页、界面缩放、品牌化，并附带 `REPORT.md`（17 节逆向报告）与 Release |

## 已知限制

- 源码来自反编译，变量名/控制流与原作者实际代码不完全一致（ILSpy 输出，非官方源码）。
- 编译期仍以 `src/libs/` 里 18 个 DLL 作为引用，但 csproj 中 13 个引用均已设 `<Private>false</Private>`，输出目录不再复制它们（单文件运行）。`.exe.config` 可选，只放 .NET 4.8 声明与 Newtonsoft 绑定重定向。
- 未包含原始 exe、图标以外的二进制资源与上游作者的构建脚本。

## 免责声明

1. 本仓库内容来自对公开分发程序的**反编译**，用于互操作研究、技术学习与兼容性修复。
2. Plain Craft Launcher 2 的著作权归原作者 **Meloong-Git** 与 **成都瓜皮龙科技有限公司** 所有（软件著作权登记号 2020SR0875133）。本仓库**不主张**对上述代码的任何著作权。
3. 按「现状」提供，不含任何担保；使用后果由使用者自行承担。
4. 若权利人认为本仓库内容不妥，请通过 Issue 联系，将立即删除。
