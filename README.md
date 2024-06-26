[Nuget](https://www.nuget.org/packages/SurfaceWater)

主要方法
1. EnvironmentalQualityStandards
   《地表水环境质量标准 GB 3838》
   - 获取各个指标的名称 GetFactorName(), Get____Name()
   - 获取各个指标的编码 GetPhCode()
   - 获取指标的5个类别的标准限值 GetFactorStandardV2002(), Get____StandardV2002()
   - 获取指标某个类别的标准限值 GetFactorStandardV2002(), Get____StandardV2002()
   - 计算指标的类别 GetFactorGradeV2002(), Get____GradeV2002()
   - 计算整条数据的水质类别 GetOverallWaterGradeV2002()
2. StatisticalTechnicalRegulations
   《地表水环境质量监测数据统计技术规定》《地表水自动监测数据处理方法及修约规则》
   - 四舍六入五留双的修约方法 Round()
   - PH的均值计算 GetPhAverage()
   - 各个指标的小时数据修约位数 GetFactorHourDataDecimalPlaces(), Get____HourDataDecimalPlaces()
   - 各个指标的评价数据修约位数 GetFactorAssessmentDataDecimalPlaces(), Get____AssessmentDataDecimalPlaces()
   - 各个指标的小时数据修约 RoundFactorHourData(), Round____HourData()
   - 各个指标的评价数据修约 RoundFactorAssessmentData(), Round____AssessmentData()
3. CWQI
   《城市地表水环境质量排名技术规定》《地表水环境质量标准 GB 3838》
   - 计算各个指标的水质指数 GetFactorCwqiV2017v2002(), Get____CwqiV2017V2002()
   - 计算一条数据的水质指数 GetOverallCwqiV2017V2002()


|单词/简写|说明|编码|单词/简写|说明|编码|
|:-------------:|:--------------:|:-----------------------:|:-------------:|:--------------:|:-----------------------:|
|EC|电导率|w01014|TRICHLOROMETHANE|三氯甲烷|W24004|
|NTU|浊度|w01003|TETRACHLOROMETHANE|四氯化碳_四氯甲烷|W24005|
|WT|水温|w01010|TRIBROMOMETHANE|三溴甲烷|W24009|
|PH|pH|w01001|DCM|二氯甲烷|W24003|
|DO|溶解氧|w01009|DICHLOROETHANE|1,2-二氯乙烷|W24017|
|CODMN|高锰酸盐指数|w01019|ECH|环氧氯丙烷|W24024|
|COD|化学需氧量|w01018|VCM|氯乙烯|W24046|
|BOD5|五日生化需氧量|w01017|11DCE|1,1-二氯乙烯|W24047|
|NH3N|氨氮|w21003|12DCE|1,2-二氯乙烯|W24048|
|TP|总磷|w21011|TCE|三氯乙烯|W24049|
|TN|总氮|w21001|PCE|四氯乙烯|W24050|
|CU|铜|w20122|CHLOROPRENE|氯丁二烯|W24062|
|ZN|锌|w20123|HCBD|六氯丁二烯|W24064|
|F|氟化物|w21017|STYRENE|苯乙烯|W25038|
|SE|硒|w20128|FORMALDEHYDE|甲醛|W31001|
|AS|砷|w20141|ACETALDEHYDE|乙醛|W31002|
|HG|汞|w20111|ACROLEIN|丙烯醛|W31004|
|CD|镉|w20115|CHLORAL|三氯乙醛|W31003|
|CR6|六价铬|w20117|PHH|苯|W25002|
|PB|铅|w20120|TOLUENE|甲苯|W25003|
|CN|氰化物|w21016|XYLENE|二甲苯|W25005|
|VP|挥发酚|w23002|IBP|异丙苯|W25034|
|TPH|石油类|w22001|PHCL|氯苯|W25010|
|LAS|阴离子表面活性剂|w19002|12DCB|1,2-二氯苯|W25011|
|S2|硫化物|w21019|14DCB|1,4二氯苯|W25013|
|FC|粪大肠菌群|w02003|TRICHLOROBENZENE|三氯苯|W25014|
|SO42|硫酸盐|w21038|CCL4C6H4|四氯苯|W25016|
|CL|氯化物|w21022|HEXACHLOROBENZENE|六氯苯|W25019|
|NO3|硝酸盐|w21007|NITROBENZENE|硝基苯|W25023|
|FE|铁|w20125|C6H4O2N2|二硝基苯|W25027|
|MN|锰|w20124|DINITROTOLUENE|2,4-二硝基甲苯|W25030|
|MO|钼|w20061|TNT|2,4,6-三硝基甲苯|W25032|
|CO|钴|w20038|CHLORONITROBENZENE|硝基氯苯|W25020|
|BE|铍|w20127|CLC6H3NO22|2,4-二硝基氯苯|W25022|
|B|硼|w20023|CL2C6H4OH|2,4-二氯苯酚|W23020|
|SB|锑|w20004|CL3C6H3OH|2,4,6-三氯苯酚|W23022|
|NI|镍|w20121|CL5C6H3OH|五氯酚|W23025|
|BA|钡|w20012|ANILINE|苯胺|W26001|
|AL|钒|w20101|C6H5NH2|联苯胺|W26002|
|TI|钛|w20095|AM|丙烯酰胺|W26048|
|TL|铊|w20089|ACRYLONITRILE|丙烯腈|W99010|
|TC|透明度|w01004|DIBUTYL_PHTHALATE|邻苯二甲酸二丁酯|W29002|
|CHLA|叶绿素a|w01016|DEHP|邻苯二甲酸二(2-乙基己基)酯|W29004|
|C|藻密度|w19011|HH|水合肼|w21009|
|ET4PB|四乙基铅|w20047|PYRIDINE|吡啶|w25052|
|TURPENTINE|松节油|w22007|BITTERACID|苦味酸|w23036|
|NBUACGN|丁基黄原酸|w32003|CL2O|活性氯|w21023|
|DDT|滴滴涕|w33007|LINDANE|林丹|w33005|
|HEPTACHLOREPOXIDE|环氧七氯|w99003|PARATHION|对硫磷|w33030|
|PHRATHIONMETHYL|甲基对硫磷|w33021|MALATHION|马拉硫磷|w33022|
|DIMETHOATE|乐果|w33019|DDVP|敌敌畏|w33010|
|DIPTEREX|敌百虫|w33011|SYSTOX|内吸磷|w33025|
|CHLOROTHALONIL|百菌清|w33012|CARBARYL|甲萘威|w33047|
|DELTAMETHRIN|溴氰菊酯|w33052|ATRAZINE|阿特拉津|w33029|
|BENZOPYRENE|苯并(a)芘|w25043|METHYLMERCURY|甲基汞|w20136|
|POLYCHLORINATEDBIPHENYLS|多氯联苯|w27001|MICROCYSTINLR|微囊藻毒素-LR|w99004|
|PHOSPHORUS|黄磷|w21013|
