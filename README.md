# Friday.StatisticsSystem
 双相机读码统计



- 该软件中用于连接相机的是TCP客户端，网络地址与网络端口均可配置
- 读码相机发送的数据格式为<STX>Index_code1_code2 ....<TEX>; <STX>Index_NoRead<ETX>
- 当在5S的时间内同时接收到来自相机一和相机二相同Index的数据
- 将相同索引的条码数据进行整合，当且仅当两个数据都为NoRead时，才输出NoRead
- 将整合后的数据显示在主界面上
- 将未整合的数据写入CSV文件，以便于对两个相机分别进行统计