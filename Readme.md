## B站直播主播数据收集器  
---
### 基本信息
项目名称：Bilibili直播主播数据采集器  
开发语言：C#  
项目类型：WinFrom客户端程序/后台程序  

---
### 项目概述
《Bilibili直播主播信息采集器》软件是一款后台监控客户端程序，其主要功能是对Bilibili网站直播区的主播进行信息爬取和采集。  

---
### 项目实现

#### 界面设计
![主界面](https://raw.githubusercontent.com/GhostYii/BilibiliUPInfoCollector/master/ReadmeImgs/1.png)  
主界面主要由工具栏区、状态信息区、采集信息区和主要功能区组成。其中工具栏区主要是对软件的设置与一些其他功能的实现（目前仅实现了设置界面），状态信息区用于显示当前软件运行状态，采集信息区用于记录当前采集到的信息状态（详细信息还未实现）。主要功能区为软件主要功能的实现按钮，采集器的自动采集与手动采集均在此区域。  
![设置界面](https://raw.githubusercontent.com/GhostYii/BilibiliUPInfoCollector/master/ReadmeImgs/2.png)  
设置界面主要设置两个参数：采集分区参数和自动采集间隔参数。  
![手动采集数据界面1](https://raw.githubusercontent.com/GhostYii/BilibiliUPInfoCollector/master/ReadmeImgs/3.png)  
![手动采集数据界面2](https://raw.githubusercontent.com/GhostYii/BilibiliUPInfoCollector/master/ReadmeImgs/4.png)  
手动采集界面主要是显示手动采集的进度。采集前会先抓取需要采集的数据，抓取到数据后会对数据进行采集。  

---
### 功能实现

#### 手动采集
用户点击软件主界面的手动采集按钮来实现手动采集，此时无论自动采集是否开启都会开始进行手动采集，手动采集界面将会显示并开始采集设置界面中选定的采集分区的数据。
采集完成后主界面将进行更新，如下图所示：  
![采集完成](https://raw.githubusercontent.com/GhostYii/BilibiliUPInfoCollector/master/ReadmeImgs/5.png)  

#### 自动采集
点击主界面的【开始自动采集】按钮进行自动采集。自动采集将于设置界面设置的采集间隔时间后进行第一次采集，主界面将会根据具体情况进行更新  
![设置自动采集](https://raw.githubusercontent.com/GhostYii/BilibiliUPInfoCollector/master/ReadmeImgs/6.png)  
自动采集将会在指定时间自动开启，采集区域与设置中的采集区域一致，当自动采集开始时，主界面将会进行更新。其中，下一次自动采集任务将于上一次自动采集完成后开始计时。  
![自动采集进行中](https://raw.githubusercontent.com/GhostYii/BilibiliUPInfoCollector/master/ReadmeImgs/7.png)  
![自动采集完成](https://raw.githubusercontent.com/GhostYii/BilibiliUPInfoCollector/master/ReadmeImgs/8.png)  
![自动采集与手动采集](https://raw.githubusercontent.com/GhostYii/BilibiliUPInfoCollector/master/ReadmeImgs/9.png)  
自动采集和手动采集并不会相互影响，用户可以手动停止自动采集，只需点击主界面上的停止自动采集按钮即可。  
![停止自动采集](https://raw.githubusercontent.com/GhostYii/BilibiliUPInfoCollector/master/ReadmeImgs/10.png)  

#### 数据保存
采集到的数据将保存在软件根目录下的各个文件夹中，其中Cache文件夹保存所有直播间的采集时刻截图，Infos/Faces文件夹下保存所有采集到的主播的账户头像图片，Infos/Covers保存所有直播间主播自行设定的直播间封面。  
Infos下的info.manifest文件保存上一次采集的所有主播数据，Logs文件夹下的txt文件保存某次采集到的主播数据。  
![采集到的数据图片](https://raw.githubusercontent.com/GhostYii/BilibiliUPInfoCollector/master/ReadmeImgs/11.png)

---
### 尾巴
软件由于开发时间非常短，并且暂时没有时间进行后续更新，故放在github上供各位下载，如果有相同需求的同学可以下载作为参考。软件的功能暂时只能用于演示，并不完善（要我找Bug估计一下午能找出50+）。而且代码比较粗糙，某些分区的数据抓取无法使用。  
本工程我只写了一天，后面为了上传github做了一点点修改，这个坑先埋在这里，等我有时间又心血来潮的时候再进行后续更新。  

---
