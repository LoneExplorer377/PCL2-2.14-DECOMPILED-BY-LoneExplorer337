# PCL2 2.14.0.0 反编译原始输出（未修改）

> 本仓库是 **Plain Craft Launcher 2（PCL2）2.14.0.0 的 ILSpy 反编译原始产物**，即逆向导出后**未做任何手工修改**的源码，仅用于技术研究与学习参考。

> **制作**：反编译、整理与本文档由 **DSH**（DeepSeek Harness 编码智能体，模型 **DeepSeek-V4.1-Flash-1017**）完成；项目维护者与需求方为 **LoneExplorer337**。

## 这是什么

| 项目 | 值 |
| --- | --- |
| 来源程序 | `plain craft launcher 2.exe`（Plain Craft Launcher 2.14.0.0，官方发布版，5,993,984 字节，sha256 `77fbc26a13abf725dbd26038cba023224c2ce5518f3ee9c4608acb2274d753f0`） |
| 反编译工具 | ilspycmd 11.2.0.10050（ICSharpCode.Decompiler 11.2），命令 `ilspycmd -p --nested-directories` |
| 产物规模 | 136 个 `.cs`（88,657 行）+ 61 个 `.xaml`（6,065 行），共 197 个文件 / 约 3.8 MB |
| 语言还原 | 原程序为 VB.NET，ILSpy 只能输出 C#，因此还原结果是「C# 语法的 VB 语义」 |
| 修改状态 | **零修改**：无手工修补、无格式化、无重命名（含 VB 专有语法的原样退化） |

## 为什么不能直接编译

这不是一份可编译工程，缺工程文件，且 VB.NET 专有语义在 C# 中不成立。实测把本目录直接扔进 SDK 风格 net48 WPF 工程会得到上千条错误，主要分四类：

1. **VB 的 `WithEvents` → C# 属性 / XAML 生成字段冲突**：ILSpy 把 `Friend WithEvents X As T` 还原成 `internal virtual T X { get; set; }`，而 WPF 标记编译器会为 `x:Name="X"` 生成同名字段，产生 CS0102（重复成员）/ CS0111。
2. **VB 匿名委托类型被整类丢弃**：`VB$AnonymousDelegate_0..26` 是 `[CompilerGenerated]` 委托，ILSpy 既不输出定义也不报错，只留下引用，产生 CS0246。需用 `ilspycmd -il -t "VB$AnonymousDelegate_N"` 回退到 IL 取签名后再补声明。
3. **`((BaseType)this).Method()` 的虚派发误译**：IL 里是非虚调用 `call`，ILSpy 写作 `((BaseLogger)this).Format(...)`，C# 按虚派发 → 调用自身重写 → 运行时无限递归栈溢出。正确写法是 `base.Format(...)`。
4. **VB 宽松转换与未赋值局部变量**：`(Func<object>)(object)InputDelegate`（值类型泛型实例化必然抛 InvalidCastException）、`if ((int)JArray == 0)`（VB 的 `??` 链被误译成整数比较）、VB 允许读取未赋值局部变量的默认值（CS0165）等。

完整的问题清单与修法（17 类、含错误码与数量）见修改版仓库的 `REPORT.md` §12。

## 相关仓库

- **PCL-SERVER-BY-LoneExplorer337**：在本产物基础上修复、可编译、并新增服务端模式等功能的改造版 —— <https://github.com/LoneExplorer377/PCL-SERVER-BY-LoneExplorer337>

## 免责声明

1. 本仓库内容来自对公开分发程序的**反编译**，用于互操作研究、技术学习与安全分析。
2. Plain Craft Launcher 2 的著作权归原作者 **Meloong-Git** 与 **成都瓜皮龙科技有限公司** 所有（计算机软件著作权登记号 2020SR0875133）。本仓库**不主张**对上述代码的任何著作权。
3. 本仓库**不含**原始 exe、图标、图片、字体等二进制资源，也不含可运行构建产物。
4. 反编译产物按「现状」提供，不含任何担保；因使用本仓库内容产生的后果由使用者自行承担。
5. 若权利人认为本仓库内容不妥，请通过仓库 Issue 联系，将立即删除。

## 已知的第三方信息说明

源码内出现的少量邮箱地址属于以下性质，未做删改（除第三方个人邮箱已打码外）：

- `admin@meloong.com`：上游作者在软件「法律信息」界面公开展示的联系邮箱；
- `mark.heath@gmail.com`、`huanghongxun2008@126.com`：第三方组件许可协议（Ms-PL、GPLv3）要求保留的版权声明。

赞助者列表中出现的一个第三方个人邮箱（`3425789779@qq.com`）按「100% 未修改」的要求**原样保留**，它来自上游程序自带的赞助者名单，与本仓库维护者无关；如权利人要求，可通过 Issue 联系删除。