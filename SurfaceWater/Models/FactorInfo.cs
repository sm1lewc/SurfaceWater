namespace SurfaceWater.Models
{
    /// <summary>
    /// 监测指标信息
    /// </summary>
    public class FactorInfo 
    {
        /// <summary>
        /// 电导率编码
        /// </summary>
        public static string EcCode { get; } = "w01014";
        /// <summary>
        /// 电导率名称
        /// </summary>
        public static string EcName { get; } = "电导率";

        /// <summary>
        /// 浊度编码
        /// </summary>
        public static string NtuCode { get; } = "w01003";
        /// <summary>
        /// 浊度名称
        /// </summary>
        public static string NtuName { get; } = "浊度";

        /// <summary>
        /// 水温编码
        /// </summary>
        public static string WtCode { get; } = "w01010";
        /// <summary>
        /// 水温名称
        /// </summary>
        public static string WtName { get; } = "水温";

        /// <summary>
        /// pH编码
        /// </summary>
        public static string PhCode { get; } = "w01001";
        /// <summary>
        /// pH名称
        /// </summary>
        public static string PhName { get; } = "pH";

        /// <summary>
        /// 溶解氧编码
        /// </summary>
        public static string DoCode { get; } = "w01009";
        /// <summary>
        /// 溶解氧名称
        /// </summary>
        public static string DoName { get; } = "溶解氧";

        /// <summary>
        /// 高锰酸盐指数编码
        /// </summary>
        public static string CodmnCode { get; } = "w01019";
        /// <summary>
        /// 高锰酸盐指数名称
        /// </summary>
        public static string CodmnName { get; } = "高锰酸盐指数";

        /// <summary>
        /// 化学需氧量编码
        /// </summary>
        public static string CodCode { get; } = "w01018";
        /// <summary>
        /// 化学需氧量名称
        /// </summary>
        public static string CodName { get; } = "化学需氧量";

        /// <summary>
        /// 五日生化需氧量编码
        /// </summary>
        public static string Bod5Code { get; } = "w01017";
        /// <summary>
        /// 五日生化需氧量名称
        /// </summary>
        public static string Bod5Name { get; } = "五日生化需氧量";

        /// <summary>
        /// 氨氮编码
        /// </summary>
        public static string Nh3nCode { get; } = "w21003";
        /// <summary>
        /// 氨氮名称
        /// </summary>
        public static string Nh3nName { get; } = "氨氮";

        /// <summary>
        /// 总磷编码
        /// </summary>
        public static string TpCode { get; } = "w21011";
        /// <summary>
        /// 总磷名称
        /// </summary>
        public static string TpName { get; } = "总磷";

        /// <summary>
        /// 总氮编码
        /// </summary>
        public static string TnCode { get; } = "w21001";
        /// <summary>
        /// 总氮名称
        /// </summary>
        public static string TnName { get; } = "总氮";

        /// <summary>
        /// 铜编码
        /// </summary>
        public static string CuCode { get; } = "w20122";
        /// <summary>
        /// 铜名称
        /// </summary>
        public static string CuName { get; } = "铜";

        /// <summary>
        /// 锌编码
        /// </summary>
        public static string ZnCode { get; } = "w20123";
        /// <summary>
        /// 锌名称
        /// </summary>
        public static string ZnName { get; } = "锌";

        /// <summary>
        /// 氟化物编码
        /// </summary>
        public static string FCode { get; } = "w21017";
        /// <summary>
        /// 氟化物名称
        /// </summary>
        public static string FName { get; } = "氟化物";

        /// <summary>
        /// 硒编码
        /// </summary>
        public static string SeCode { get; } = "w20128";
        /// <summary>
        /// 硒名称
        /// </summary>
        public static string SeName { get; } = "硒";

        /// <summary>
        /// 砷编码
        /// </summary>
        public static string AsCode { get; } = "w20141";
        /// <summary>
        /// 砷名称
        /// </summary>
        public static string AsName { get; } = "砷";

        /// <summary>
        /// 汞编码
        /// </summary>
        public static string HgCode { get; } = "w20111";
        /// <summary>
        /// 汞名称
        /// </summary>
        public static string HgName { get; } = "汞";

        /// <summary>
        /// 镉编码
        /// </summary>
        public static string CdCode { get; } = "w20115";
        /// <summary>
        /// 镉名称
        /// </summary>
        public static string CdName { get; } = "镉";

        /// <summary>
        /// 六价铬编码
        /// </summary>
        public static string Cr6Code { get; } = "w20117";
        /// <summary>
        /// 六价铬名称
        /// </summary>
        public static string Cr6Name { get; } = "铬（六价）";

        /// <summary>
        /// 铅编码
        /// </summary>
        public static string PbCode { get; } = "w20120";
        /// <summary>
        /// 铅名称
        /// </summary>
        public static string PbName { get; } = "铅";

        /// <summary>
        /// 氰化物编码
        /// </summary>
        public static string CnCode { get; } = "w21016";
        /// <summary>
        /// 氰化物名称
        /// </summary>
        public static string CnName { get; } = "氰化物";

        /// <summary>
        /// 挥发酚编码
        /// </summary>
        public static string VpCode { get; } = "w23002";
        /// <summary>
        /// 挥发酚名称
        /// </summary>
        public static string VpName { get; } = "挥发酚";

        /// <summary>
        /// 石油类编码
        /// </summary>
        public static string TphCode { get; } = "w22001";
        /// <summary>
        /// 石油类名称
        /// </summary>
        public static string TphName { get; } = "石油类";

        /// <summary>
        /// 阴离子表面活性剂编码
        /// </summary>
        public static string LasCode { get; } = "w19002";
        /// <summary>
        /// 阴离子表面活性剂名称
        /// </summary>
        public static string LasName { get; } = "阴离子表面活性剂";

        /// <summary>
        /// 硫化物编码
        /// </summary>
        public static string S2Code { get; } = "w21019";
        /// <summary>
        /// 硫化物名称
        /// </summary>
        public static string S2Name { get; } = "硫化物";

        /// <summary>
        /// 粪大肠菌群编码
        /// </summary>
        public static string FcCode { get; } = "w02003";
        /// <summary>
        /// 粪大肠菌群名称
        /// </summary>
        public static string FcName { get; } = "粪大肠菌群";

        /// <summary>
        /// 硫酸盐编码
        /// </summary>
        public static string So42Code { get; } = "w21038";
        /// <summary>
        /// 硫酸盐名称
        /// </summary>
        public static string So42Name { get; } = "硫酸盐";

        /// <summary>
        /// 氯化物编码
        /// </summary>
        public static string ClCode { get; } = "w21022";
        /// <summary>
        /// 氯化物名称
        /// </summary>
        public static string ClName { get; } = "氯化物";

        /// <summary>
        /// 硝酸盐编码
        /// </summary>
        public static string No3Code { get; } = "w21007";
        /// <summary>
        /// 硝酸盐名称
        /// </summary>
        public static string No3Name { get; } = "硝酸盐";

        /// <summary>
        /// 铁编码
        /// </summary>
        public static string FeCode { get; } = "w20125";
        /// <summary>
        /// 铁名称
        /// </summary>
        public static string FeName { get; } = "铁";

        /// <summary>
        /// 锰编码
        /// </summary>
        public static string MnCode { get; } = "w20124";
        /// <summary>
        /// 锰名称
        /// </summary>
        public static string MnName { get; } = "锰";

        /// <summary>
        /// 钼编码
        /// </summary>
        public static string MoCode { get; } = "w20061";
        /// <summary>
        /// 钼名称
        /// </summary>
        public static string MoName { get; } = "钼";

        /// <summary>
        /// 钴编码
        /// </summary>
        public static string CoCode { get; } = "w20038";
        /// <summary>
        /// 钴名称
        /// </summary>
        public static string CoName { get; } = "钴";

        /// <summary>
        /// 铍编码
        /// </summary>
        public static string BeCode { get; } = "w20127";
        /// <summary>
        /// 铍名称
        /// </summary>
        public static string BeName { get; } = "铍";

        /// <summary>
        /// 硼编码
        /// </summary>
        public static string BCode { get; } = "w20023";
        /// <summary>
        /// 硼名称
        /// </summary>
        public static string BName { get; } = "硼";

        /// <summary>
        /// 锑编码
        /// </summary>
        public static string SbCode { get; } = "w20004";
        /// <summary>
        /// 锑名称
        /// </summary>
        public static string SbName { get; } = "锑";

        /// <summary>
        /// 镍编码
        /// </summary>
        public static string NiCode { get; } = "w20121";
        /// <summary>
        /// 镍名称
        /// </summary>
        public static string NiName { get; } = "镍";

        /// <summary>
        /// 钡编码
        /// </summary>
        public static string BaCode { get; } = "w20012";
        /// <summary>
        /// 钡名称
        /// </summary>
        public static string BaName { get; } = "钡";

        /// <summary>
        /// 矾编码
        /// </summary>
        public static string AlCode { get; } = "w20101";
        /// <summary>
        /// 矾名称
        /// </summary>
        public static string AlName { get; } = "矾";

        /// <summary>
        /// 钛编码
        /// </summary>
        public static string TiCode { get; } = "w20095";
        /// <summary>
        /// 钛名称
        /// </summary>
        public static string TiName { get; } = "钛";

        /// <summary>
        /// 铊编码
        /// </summary>
        public static string TlCode { get; } = "w20089";
        /// <summary>
        /// 铊名称
        /// </summary>
        public static string TlName { get; } = "铊";

        /// <summary>
        /// 透明度编码
        /// </summary>
        public static string TcCode { get; } = "w01004";
        /// <summary>
        /// 透明度名称
        /// </summary>
        public static string TcName { get; } = "透明度";

        /// <summary>
        /// 叶绿素a编码
        /// </summary>
        public static string ChlaCode { get; } = "w01016";
        /// <summary>
        /// 叶绿素a名称
        /// </summary>
        public static string ChlaName { get; } = "叶绿素a";

        /// <summary>
        /// 藻密度编码
        /// </summary>
        public static string CCode { get; } = "w19011";
        /// <summary>
        /// 藻密度名称
        /// </summary>
        public static string CName { get; } = "藻密度";

        /// <summary>
        /// 三氯甲烷编码
        /// </summary>
        public static string TrichloromethaneCode { get; } = "w24004";

        /// <summary>
        /// 三氯甲烷名称
        /// </summary>
        public static string TrichloromethaneName { get; } = "三氯甲烷";

        /// <summary>
        /// 四氯化碳编码
        /// </summary>
        public static string TetrachloromethaneCode { get; } = "w24005";

        /// <summary>
        /// 四氯化碳名称
        /// </summary>
        public static string TetrachloromethaneName { get; } = "四氯化碳";

        /// <summary>
        /// 三溴甲烷编码
        /// </summary>
        public static string TribromomethaneCode { get; } = "w24009";

        /// <summary>
        /// 三溴甲烷名称
        /// </summary>
        public static string TribromomethaneName { get; } = "三溴甲烷";

        /// <summary>
        /// 二氯甲烷编码
        /// </summary>
        public static string DcmCode { get; } = "w24003";

        /// <summary>
        /// 二氯甲烷名称
        /// </summary>
        public static string DcmName { get; } = "二氯甲烷";

        /// <summary>
        /// 1,2-二氯乙烷编码
        /// </summary>
        public static string DichloroethaneCode { get; } = "w24017";

        /// <summary>
        /// 1,2-二氯乙烷名称
        /// </summary>
        public static string DichloroethaneName { get; } = "1,2-二氯乙烷";

        /// <summary>
        /// 环氧氯丙烷编码
        /// </summary>
        public static string EchCode { get; } = "w24024";

        /// <summary>
        /// 环氧氯丙烷名称
        /// </summary>
        public static string EchName { get; } = "环氧氯丙烷";

        /// <summary>
        /// 氯乙烯编码
        /// </summary>
        public static string VcmCode { get; } = "w24046";

        /// <summary>
        /// 氯乙烯名称
        /// </summary>
        public static string VcmName { get; } = "氯乙烯";

        /// <summary>
        /// 1,1-二氯乙烯编码
        /// </summary>
        public static string Dce11Code { get; } = "w24047";

        /// <summary>
        /// 1,1-二氯乙烯名称
        /// </summary>
        public static string Dce11Name { get; } = "1,1-二氯乙烯";

        /// <summary>
        /// 1,2-二氯乙烯编码
        /// </summary>
        public static string Dce12Code { get; } = "w24048";

        /// <summary>
        /// 1,2-二氯乙烯名称
        /// </summary>
        public static string Dce12Name { get; } = "1,2-二氯乙烯";

        /// <summary>
        /// 三氯乙烯编码
        /// </summary>
        public static string TceCode { get; } = "w24049";

        /// <summary>
        /// 三氯乙烯名称
        /// </summary>
        public static string TceName { get; } = "三氯乙烯";

        /// <summary>
        /// 四氯乙烯编码
        /// </summary>
        public static string PceCode { get; } = "w24050";

        /// <summary>
        /// 四氯乙烯名称
        /// </summary>
        public static string PceName { get; } = "四氯乙烯";

        /// <summary>
        /// 氯丁二烯编码
        /// </summary>
        public static string ChloropreneCode { get; } = "w24062";

        /// <summary>
        /// 氯丁二烯名称
        /// </summary>
        public static string ChloropreneName { get; } = "氯丁二烯";

        /// <summary>
        /// 六氯丁二烯编码
        /// </summary>
        public static string HcbdCode { get; } = "w24064";

        /// <summary>
        /// 六氯丁二烯名称
        /// </summary>
        public static string HcbdName { get; } = "六氯丁二烯";

        /// <summary>
        /// 苯乙烯编码
        /// </summary>
        public static string StyreneCode { get; } = "w25038";

        /// <summary>
        /// 苯乙烯名称
        /// </summary>
        public static string StyreneName { get; } = "苯乙烯";

        /// <summary>
        /// 甲醛编码
        /// </summary>
        public static string FormaldehydeCode { get; } = "w31001";

        /// <summary>
        /// 甲醛名称
        /// </summary>
        public static string FormaldehydeName { get; } = "甲醛";

        /// <summary>
        /// 乙醛编码
        /// </summary>
        public static string AcetaldehydeCode { get; } = "w31002";

        /// <summary>
        /// 乙醛名称
        /// </summary>
        public static string AcetaldehydeName { get; } = "乙醛";

        /// <summary>
        /// 丙烯醛编码
        /// </summary>
        public static string AcroleinCode { get; } = "w31004";

        /// <summary>
        /// 丙烯醛名称
        /// </summary>
        public static string AcroleinName { get; } = "丙烯醛";

        /// <summary>
        /// 三氯乙醛编码
        /// </summary>
        public static string ChloralCode { get; } = "w31003";

        /// <summary>
        /// 三氯乙醛名称
        /// </summary>
        public static string ChloralName { get; } = "三氯乙醛";

        /// <summary>
        /// 苯编码
        /// </summary>
        public static string PhhCode { get; } = "w25002";

        /// <summary>
        /// 苯名称
        /// </summary>
        public static string PhhName { get; } = "苯";

        /// <summary>
        /// 甲苯编码
        /// </summary>
        public static string TolueneCode { get; } = "w25003";

        /// <summary>
        /// 甲苯名称
        /// </summary>
        public static string TolueneName { get; } = "甲苯";

        /// <summary>
        /// 二甲苯编码
        /// </summary>
        public static string XyleneCode { get; } = "w25005";

        /// <summary>
        /// 二甲苯名称
        /// </summary>
        public static string XyleneName { get; } = "二甲苯";

        /// <summary>
        /// 异丙苯编码
        /// </summary>
        public static string IbpCode { get; } = "w25034";

        /// <summary>
        /// 异丙苯名称
        /// </summary>
        public static string IbpName { get; } = "异丙苯";

        /// <summary>
        /// 氯苯编码
        /// </summary>
        public static string PhclCode { get; } = "w25010";

        /// <summary>
        /// 氯苯名称
        /// </summary>
        public static string PhclName { get; } = "氯苯";

        /// <summary>
        /// 1,2-二氯苯编码
        /// </summary>
        public static string Dcb12Code { get; } = "w25011";

        /// <summary>
        /// 1,2-二氯苯名称
        /// </summary>
        public static string Dcb12Name { get; } = "1,2-二氯苯";

        /// <summary>
        /// 1,4-二氯苯编码
        /// </summary>
        public static string Dcb14Code { get; } = "w25013";

        /// <summary>
        /// 1,4-二氯苯名称
        /// </summary>
        public static string Dcb14Name { get; } = "1,4-二氯苯";

        /// <summary>
        /// 三氯苯编码
        /// </summary>
        public static string TrichlorobenzeneCode { get; } = "w25014";

        /// <summary>
        /// 三氯苯名称
        /// </summary>
        public static string TrichlorobenzeneName { get; } = "三氯苯";

        /// <summary>
        /// 四氯苯编码
        /// </summary>
        public static string Ccl4C6H4Code { get; } = "w25016";

        /// <summary>
        /// 四氯苯名称
        /// </summary>
        public static string Ccl4C6H4Name { get; } = "四氯苯";

        /// <summary>
        /// 六氯苯编码
        /// </summary>
        public static string HexachlorobenzeneCode { get; } = "w25019";

        /// <summary>
        /// 六氯苯名称
        /// </summary>
        public static string HexachlorobenzeneName { get; } = "六氯苯";

        /// <summary>
        /// 硝基苯编码
        /// </summary>
        public static string NitrobenzeneCode { get; } = "w25023";

        /// <summary>
        /// 硝基苯名称
        /// </summary>
        public static string NitrobenzeneName { get; } = "硝基苯";

        /// <summary>
        /// 二硝基苯编码
        /// </summary>
        public static string C6H4O2N2Code { get; } = "w25027";

        /// <summary>
        /// 二硝基苯名称
        /// </summary>
        public static string C6H4O2N2Name { get; } = "二硝基苯";

        /// <summary>
        /// 2,4-二硝基甲苯编码
        /// </summary>
        public static string DinitrotolueneCode { get; } = "w25030";

        /// <summary>
        /// 2,4-二硝基甲苯名称
        /// </summary>
        public static string DinitrotolueneName { get; } = "2,4-二硝基甲苯";

        /// <summary>
        /// 2,4,6-三硝基甲苯编码
        /// </summary>
        public static string TntCode { get; } = "w25032";

        /// <summary>
        /// 2,4,6-三硝基甲苯名称
        /// </summary>
        public static string TntName { get; } = "2,4,6-三硝基甲苯";

        /// <summary>
        /// 硝基氯苯编码
        /// </summary>
        public static string ChloronitrobenzeneCode { get; } = "w25020";

        /// <summary>
        /// 硝基氯苯名称
        /// </summary>
        public static string ChloronitrobenzeneName { get; } = "硝基氯苯";

        /// <summary>
        /// 2,4-二硝基氯苯编码
        /// </summary>
        public static string Clc6H3No22Code { get; } = "w25022";

        /// <summary>
        /// 2,4-二硝基氯苯名称
        /// </summary>
        public static string Clc6H3No22Name { get; } = "2,4-二硝基氯苯";

        /// <summary>
        /// 2,4-二氯苯酚编码
        /// </summary>
        public static string Cl2C6H4OhCode { get; } = "w23020";

        /// <summary>
        /// 2,4-二氯苯酚名称
        /// </summary>
        public static string Cl2C6H4OhName { get; } = "2,4-二氯苯酚";

        /// <summary>
        /// 2,4,6-三氯苯酚编码
        /// </summary>
        public static string Cl3C6H3OhCode { get; } = "w23022";

        /// <summary>
        /// 2,4,6-三氯苯酚名称
        /// </summary>
        public static string Cl3C6H3OhName { get; } = "2,4,6-三氯苯酚";

        /// <summary>
        /// 五氯酚编码
        /// </summary>
        public static string Cl5C6H3OhCode { get; } = "w23025";

        /// <summary>
        /// 五氯酚名称
        /// </summary>
        public static string Cl5C6H3OhName { get; } = "五氯酚";

        /// <summary>
        /// 苯胺编码
        /// </summary>
        public static string AnilineCode { get; } = "w26001";

        /// <summary>
        /// 苯胺名称
        /// </summary>
        public static string AnilineName { get; } = "苯胺";

        /// <summary>
        /// 联苯胺编码
        /// </summary>
        public static string C6H5NH2Code { get; } = "w26002";

        /// <summary>
        /// 联苯胺名称
        /// </summary>
        public static string C6H5NH2Name { get; } = "联苯胺";

        /// <summary>
        /// 丙烯酰胺编码
        /// </summary>
        public static string AmCode { get; } = "w26048";

        /// <summary>
        /// 丙烯酰胺名称
        /// </summary>
        public static string AmName { get; } = "丙烯酰胺";

        /// <summary>
        /// 丙烯腈编码
        /// </summary>
        public static string AcrylonitrileCode { get; } = "w99010";

        /// <summary>
        /// 丙烯腈名称
        /// </summary>
        public static string AcrylonitrileName { get; } = "丙烯腈";

        /// <summary>
        /// 邻苯二甲酸二丁酯编码
        /// </summary>
        public static string DibutylPhthalateCode { get; } = "w29002";

        /// <summary>
        /// 邻苯二甲酸二丁酯名称
        /// </summary>
        public static string DibutylPhthalateName { get; } = "邻苯二甲酸二丁酯";

        /// <summary>
        /// 邻苯二甲酸二(2-乙基己基)酯编码
        /// </summary>
        public static string DehpCode { get; } = "w29004";

        /// <summary>
        /// 邻苯二甲酸二(2-乙基己基)酯名称
        /// </summary>
        public static string DehpName { get; } = "邻苯二甲酸二(2-乙基己基)酯";


        /// <summary>
        /// 水合肼编码
        /// </summary>
        public static string HhCode { get; } = "w21009";

        /// <summary>
        /// 水合肼名称
        /// </summary>
        public static string HhName { get; } = "水合肼";

        /// <summary>
        /// 四乙基铅编码
        /// </summary>
        public static string Et4PbCode { get; } = "w20047";

        /// <summary>
        /// 四乙基铅名称
        /// </summary>
        public static string Et4PbName { get; } = "四乙基铅";

        /// <summary>
        /// 吡啶编码
        /// </summary>
        public static string PyridineCode { get; } = "w25052";

        /// <summary>
        /// 吡啶名称
        /// </summary>
        public static string PyridineName { get; } = "吡啶";

        /// <summary>
        /// 松节油编码
        /// </summary>
        public static string TurpentineCode { get; } = "w22007";

        /// <summary>
        /// 松节油名称
        /// </summary>
        public static string TurpentineName { get; } = "松节油";

        /// <summary>
        /// 苦味酸编码
        /// </summary>
        public static string BitteracidCode { get; } = "w23036";

        /// <summary>
        /// 苦味酸名称
        /// </summary>
        public static string BitteracidName { get; } = "苦味酸";

        /// <summary>
        /// 丁基黄原酸编码
        /// </summary>
        public static string NbuacgnCode { get; } = "w32003";

        /// <summary>
        /// 丁基黄原酸名称
        /// </summary>
        public static string NbuacgnName { get; } = "丁基黄原酸";

        /// <summary>
        /// 活性氯编码
        /// </summary>
        public static string Cl2oCode { get; } = "w21023";

        /// <summary>
        /// 活性氯名称
        /// </summary>
        public static string Cl2oName { get; } = "活性氯";

        /// <summary>
        /// 滴滴涕编码
        /// </summary>
        public static string DdtCode { get; } = "w33007";

        /// <summary>
        /// 滴滴涕名称
        /// </summary>
        public static string DdtName { get; } = "滴滴涕";

        /// <summary>
        /// 林丹编码
        /// </summary>
        public static string LindaneCode { get; } = "w33005";

        /// <summary>
        /// 林丹名称
        /// </summary>
        public static string LindaneName { get; } = "林丹";

        /// <summary>
        /// 环氧七氯编码
        /// </summary>
        public static string HeptachlorEpoxideCode { get; } = "w99003";

        /// <summary>
        /// 环氧七氯名称
        /// </summary>
        public static string HeptachlorEpoxideName { get; } = "环氧七氯";

        /// <summary>
        /// 对硫磷编码
        /// </summary>
        public static string ParathionCode { get; } = "w33030";

        /// <summary>
        /// 对硫磷名称
        /// </summary>
        public static string ParathionName { get; } = "对硫磷";

        /// <summary>
        /// 甲基对硫磷编码
        /// </summary>
        public static string PhrathionMethylCode { get; } = "w33021";

        /// <summary>
        /// 甲基对硫磷名称
        /// </summary>
        public static string PhrathionMethylName { get; } = "甲基对硫磷";

        /// <summary>
        /// 马拉硫磷编码
        /// </summary>
        public static string MalathionCode { get; } = "w33022";

        /// <summary>
        /// 马拉硫磷名称
        /// </summary>
        public static string MalathionName { get; } = "马拉硫磷";

        /// <summary>
        /// 乐果编码
        /// </summary>
        public static string DimethoateCode { get; } = "w33019";

        /// <summary>
        /// 乐果名称
        /// </summary>
        public static string DimethoateName { get; } = "乐果";

        /// <summary>
        /// 敌敌畏编码
        /// </summary>
        public static string DdvpCode { get; } = "w33010";

        /// <summary>
        /// 敌敌畏名称
        /// </summary>
        public static string DdvpName { get; } = "敌敌畏";

        /// <summary>
        /// 敌百虫编码
        /// </summary>
        public static string DipterexCode { get; } = "w33011";

        /// <summary>
        /// 敌百虫名称
        /// </summary>
        public static string DipterexName { get; } = "敌百虫";

        /// <summary>
        /// 内吸磷编码
        /// </summary>
        public static string SystoxCode { get; } = "w33025";

        /// <summary>
        /// 内吸磷名称
        /// </summary>
        public static string SystoxName { get; } = "内吸磷";

        /// <summary>
        /// 百菌清编码
        /// </summary>
        public static string ChlorothalonilCode { get; } = "w33012";

        /// <summary>
        /// 百菌清名称
        /// </summary>
        public static string ChlorothalonilName { get; } = "百菌清";

        /// <summary>
        /// 甲萘威编码
        /// </summary>
        public static string CarbarylCode { get; } = "w33047";

        /// <summary>
        /// 甲萘威名称
        /// </summary>
        public static string CarbarylName { get; } = "甲萘威";

        /// <summary>
        /// 溴氰菊酯编码
        /// </summary>
        public static string DeltamethrinCode { get; } = "w33052";

        /// <summary>
        /// 溴氰菊酯名称
        /// </summary>
        public static string DeltamethrinName { get; } = "溴氰菊酯";

        /// <summary>
        /// 阿特拉津编码
        /// </summary>
        public static string AtrazineCode { get; } = "w33029";

        /// <summary>
        /// 阿特拉津名称
        /// </summary>
        public static string AtrazineName { get; } = "阿特拉津";

        /// <summary>
        /// 苯并a芘编码
        /// </summary>
        public static string BenzopyreneCode { get; } = "w25043";

        /// <summary>
        /// 苯并(a)芘名称
        /// </summary>
        public static string BenzopyreneName { get; } = "苯并(a)芘";

        /// <summary>
        /// 甲基汞编码
        /// </summary>
        public static string MethylmercuryCode { get; } = "w20136";

        /// <summary>
        /// 甲基汞名称
        /// </summary>
        public static string MethylmercuryName { get; } = "甲基汞";

        /// <summary>
        /// 多氯联苯编码
        /// </summary>
        public static string PolychlorinatedBiphenylsCode { get; } = "w27001";

        /// <summary>
        /// 多氯联苯名称
        /// </summary>
        public static string PolychlorinatedBiphenylsName { get; } = "多氯联苯";

        /// <summary>
        /// 微囊藻毒素-LR编码
        /// </summary>
        public static string MicrocystinLrCode { get; } = "w99004";

        /// <summary>
        /// 微囊藻毒素-LR名称
        /// </summary>
        public static string MicrocystinLrName { get; } = "微囊藻毒素-LR";

        /// <summary>
        /// 黄磷编码
        /// </summary>
        public static string PhosphorusCode { get; } = "w21013";

        /// <summary>
        /// 黄磷名称
        /// </summary>
        public static string PhosphorusName { get; } = "黄磷";
    }
}
