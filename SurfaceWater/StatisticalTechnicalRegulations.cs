using SurfaceWater.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SurfaceWater
{

    /// <summary>
    /// 统计技术规定
    /// </summary>
    /// <remarks>1.《地表水环境质量监测数据统计技术规定（试行）》环办监测函〔2020〕82号;2.《地表水自动监测数据处理方法及修约规则（试行）》总站水字〔2020〕90号</remarks>
    public class StatisticalTechnicalRegulations
    {
        /// <summary>
        /// 数据修约（四舍六入五成双），当修约后结果为0时，保留一位有效数字
        /// </summary>
        /// <remarks>《国家地表水环境质量监测数据修约处理规则（试行）》的通知 总站水字〔2018〕87号</remarks>
        /// <param name="value"></param>
        /// <param name="decimalPlaces">保留的小数位数</param>
        /// <returns></returns>
        public static decimal Round(decimal value, int decimalPlaces)
        {
            if (value == 0) return 0;
            // 第一位非零数字的位置
            int firstNonZeroDigitPosition = 0;
            var tmp = value;
            while (Math.Abs(tmp) < 1m)
            {
                tmp *= 10;
                firstNonZeroDigitPosition++;
            }
            decimalPlaces = Math.Max(decimalPlaces, firstNonZeroDigitPosition);
            return Math.Round(value, decimalPlaces, MidpointRounding.ToEven);
        }


        /// <summary>
        /// 计算PH的均值（结果不修约）
        /// </summary>
        /// <remarks>pH的均值等于全部pH值对应氢离子浓度算术平均值的负对数</remarks>
        /// <param name="values"></param>
        /// <returns>无大于0的pH值时返回null</returns>
        public static decimal? GetPhAverage(IEnumerable<decimal> values)
        {
            if (!values.Any()) return null;
            // 有效数据
            var ValidData = values.Where(x => x > 0).ToList();
            if (ValidData.Count == 0) return null;
            //氢离子浓度值的集合
            List<double> hValues = new List<double>();
            ValidData.ForEach(x => hValues.Add(Math.Pow(10, -Convert.ToDouble(x))));
            //氢离子浓度的均值
            var hAverage = hValues.Average();
            //PH的均值
            return Convert.ToDecimal(-Math.Log10(hAverage));
        }

        /// <summary>
        /// 获取浊度小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetNtuHourDataDecimalPlaces() => 1;
        /// <summary>
        /// 获取浊度评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetNtuAssessmentDataDecimalPlaces() => 1;

        /// <summary>
        /// 获取电导率小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetEcHourDataDecimalPlaces() => 1;
        /// <summary>
        /// 获取电导率评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetEcAssessmentDataDecimalPlaces() => 1;

        /// <summary>
        /// 获取水温小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetWtHourDataDecimalPlaces() => 1;
        /// <summary>
        /// 获取水温评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetWtAssessmentDataDecimalPlaces() => 1;

        /// <summary>
        /// 获取pH小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetPhHourDataDecimalPlaces() => 2;
        /// <summary>
        /// 获取pH评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetPhAssessmentDataDecimalPlaces() => 0;

        /// <summary>
        /// 获取溶解氧小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetDoHourDataDecimalPlaces() => 2;
        /// <summary>
        /// 获取溶解氧评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetDoAssessmentDataDecimalPlaces() => 1;

        /// <summary>
        /// 获取高锰酸盐指数小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetCodmnHourDataDecimalPlaces() => 2;
        /// <summary>
        /// 获取高锰酸盐指数评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetCodmnAssessmentDataDecimalPlaces() => 1;

        /// <summary>
        /// 获取化学需氧量小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetCodHourDataDecimalPlaces() => 2;
        /// <summary>
        /// 获取化学需氧量评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetCodAssessmentDataDecimalPlaces() => 1;

        /// <summary>
        /// 获取五日生化需氧量评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetBod5AssessmentDecimalPlaces() => 1;

        /// <summary>
        /// 获取氨氮小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetNh3nHourDataDecimalPlaces() => 3;
        /// <summary>
        /// 获取氨氮评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetNh3nAssessmentDataDecimalPlaces() => 2;

        /// <summary>
        /// 获取总磷小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetTpHourDataDecimalPlaces() => 3;
        /// <summary>
        /// 获取总磷评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetTpAssessmentDataDecimalPlaces() => 3;

        /// <summary>
        /// 获取总氮小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetTnHourDataDecimalPlaces() => 2;
        /// <summary>
        /// 获取总氮评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetTnAssessmentDataDecimalPlaces() => 2;

        /// <summary>
        /// 获取铜小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetCuHourDataDecimalPlaces() => 4;
        /// <summary>
        /// 获取铜评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetCuAssessmentDataDecimalPlaces() => 3;

        /// <summary>
        /// 获取锌小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetZnHourDataDecimalPlaces() => 4;
        /// <summary>
        /// 获取锌评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetZnAssessmentDataDecimalPlaces() => 3;

        /// <summary>
        /// 获取氟化物小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetFHourDataDecimalPlaces() => 4;
        /// <summary>
        /// 获取氟化物评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetFAssessmentDataDecimalPlaces() => 3;

        /// <summary>
        /// 获取硒小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetSeHourDataDecimalPlaces() => 5;
        /// <summary>
        /// 获取硒评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetSeAssessmentDataDecimalPlaces() => 4;

        /// <summary>
        /// 获取砷小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetAsHourDataDecimalPlaces() => 5;
        /// <summary>
        /// 获取砷评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetAsAssessmentDataDecimalPlaces() => 4;

        /// <summary>
        /// 获取汞小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetHgHourDataDecimalPlaces() => 6;
        /// <summary>
        /// 获取汞评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetHgAssessmentDataDecimalPlaces() => 5;

        /// <summary>
        /// 获取镉小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetCdHourDataDecimalPlaces() => 5;
        /// <summary>
        /// 获取镉评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetCdAssessmentDataDecimalPlaces() => 5;

        /// <summary>
        /// 获取六价铬小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetCr6HourDataDecimalPlaces() => 4;
        /// <summary>
        /// 获取六价铬评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetCr6AssessmentDataDecimalPlaces() => 3;

        /// <summary>
        /// 获取铅小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetPbHourDataDecimalPlaces() => 4;
        /// <summary>
        /// 获取铅评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetPbAssessmentDataDecimalPlaces() => 3;

        /// <summary>
        /// 获取氰化物小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetCnHourDataDecimalPlaces() => 4;
        /// <summary>
        /// 获取氰化物评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetCnAssessmentDataDecimalPlaces() => 3;

        /// <summary>
        /// 获取挥发酚小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetVpHourDataDecimalPlaces() => 5;
        /// <summary>
        /// 获取挥发酚评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetVpAssessmentDataDecimalPlaces() => 4;

        /// <summary>
        /// 获取石油类小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetTphHourDataDecimalPlaces() => 3;
        /// <summary>
        /// 获取石油类评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetTphAssessmentDataDecimalPlaces() => 2;

        /// <summary>
        /// 获取阴离子表面活性剂小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetLasHourDataDecimalPlaces() => 3;
        /// <summary>
        /// 获取阴离子表面活性剂评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetLasAssessmentDataDecimalPlaces() => 2;

        /// <summary>
        /// 获取硫化物小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetS2HourDataDecimalPlaces() => 4;
        /// <summary>
        /// 获取硫化物评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetS2AssessmentDataDecimalPlaces() => 3;

        /// <summary>
        /// 获取粪大肠菌群小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetFcHourDataDecimalPlaces() => 0;

        /// <summary>
        /// 获取硫酸盐小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetSo42HourDataDecimalPlaces() => 1;

        /// <summary>
        /// 获取氯化物小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetClHourDataDecimalPlaces() => 1;

        /// <summary>
        /// 获取硝酸盐小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetNo3HourDataDecimalPlaces() => 1;

        /// <summary>
        /// 获取铁小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetFeHourDataDecimalPlaces() => 5;

        /// <summary>
        /// 获取锰小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetMnHourDataDecimalPlaces() => 5;

        /// <summary>
        /// 获取钼小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetMoHourDataDecimalPlaces() => 5;

        /// <summary>
        /// 获取钡小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetBaHourDataDecimalPlaces() => 5;

        /// <summary>
        /// 获取钴小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetCoHourDataDecimalPlaces() => 5;

        /// <summary>
        /// 获取铍小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetBeHourDataDecimalPlaces() => 5;

        /// <summary>
        /// 获取硼小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetBHourDataDecimalPlaces() => 5;

        /// <summary>
        /// 获取锑小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetSbHourDataDecimalPlaces() => 5;

        /// <summary>
        /// 获取钒小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetAlumHourDataDecimalPlaces() => 5;

        /// <summary>
        /// 获取镍小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetNiHourDataDecimalPlaces() => 5;

        /// <summary>
        /// 获取钛小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetTiHourDataDecimalPlaces() => 5;

        /// <summary>
        /// 获取铊小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetTlHourDataDecimalPlaces() => 5;

        /// <summary>
        /// 获取透明度小时数据的小数位数 m
        /// </summary>
        /// <returns></returns>
        public static int GetTcHourDataDecimalPlaces() => 2;
        /// <summary>
        /// 获取透明度评价数据的小数位数 m
        /// </summary>
        /// <returns></returns>
        public static int GetTcAssessmentDataDecimalPlaces() => 2;

        /// <summary>
        /// 获取叶绿素a小时数据的小数位数 mg/m³
        /// </summary>
        /// <returns></returns>
        public static int GetChlaHourDataDecimalPlaces() => 0;
        /// <summary>
        /// 获取叶绿素a评价数据的小数位数 mg/m³
        /// </summary>
        /// <returns></returns>
        public static int GetChlaAssessmentDataDecimalPlaces() => 0;

        /// <summary>
        /// 获取藻密度小时数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetCHourDataDecimalPlaces() => 0;
        /// <summary>
        /// 获取藻密度评价数据的小数位数
        /// </summary>
        /// <returns></returns>
        public static int GetCAssessmentDataDecimalPlaces() => 0;

        /// <summary>
        /// 获取指标小时数据的小数位数
        /// </summary>
        /// <param name="factorCode"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">指标不在定义的范围内则抛出异常</exception>
        /// <exception cref="ArgumentNullException"></exception>
        public static int GetFactorHourDataDecimalPlaces(string factorCode)
        {
            if (string.IsNullOrWhiteSpace(factorCode)) throw new ArgumentNullException(nameof(factorCode));
            if (factorCode == FactorInfo.EcCode) return GetEcHourDataDecimalPlaces();
            if (factorCode == FactorInfo.NtuCode) return GetNtuHourDataDecimalPlaces();
            if (factorCode == FactorInfo.WtCode) return GetWtHourDataDecimalPlaces();
            if (factorCode == FactorInfo.PhCode) return GetPhHourDataDecimalPlaces();
            if (factorCode == FactorInfo.DoCode) return GetDoHourDataDecimalPlaces();
            if (factorCode == FactorInfo.CodmnCode) return GetCodmnHourDataDecimalPlaces();
            if (factorCode == FactorInfo.CodCode) return GetCodHourDataDecimalPlaces();
            if (factorCode == FactorInfo.Nh3nCode) return GetNh3nHourDataDecimalPlaces();
            if (factorCode == FactorInfo.TpCode) return GetTpHourDataDecimalPlaces();
            if (factorCode == FactorInfo.TnCode) return GetTnHourDataDecimalPlaces();
            if (factorCode == FactorInfo.CuCode) return GetCuHourDataDecimalPlaces();
            if (factorCode == FactorInfo.ZnCode) return GetZnHourDataDecimalPlaces();
            if (factorCode == FactorInfo.FCode) return GetFHourDataDecimalPlaces();
            if (factorCode == FactorInfo.SeCode) return GetSeHourDataDecimalPlaces();
            if (factorCode == FactorInfo.AsCode) return GetAsHourDataDecimalPlaces();
            if (factorCode == FactorInfo.HgCode) return GetHgHourDataDecimalPlaces();
            if (factorCode == FactorInfo.CdCode) return GetCdHourDataDecimalPlaces();
            if (factorCode == FactorInfo.Cr6Code) return GetCr6HourDataDecimalPlaces();
            if (factorCode == FactorInfo.PbCode) return GetPbHourDataDecimalPlaces();
            if (factorCode == FactorInfo.CnCode) return GetCnHourDataDecimalPlaces();
            if (factorCode == FactorInfo.VpCode) return GetVpHourDataDecimalPlaces();
            if (factorCode == FactorInfo.TphCode) return GetTphHourDataDecimalPlaces();
            if (factorCode == FactorInfo.LasCode) return GetLasHourDataDecimalPlaces();
            if (factorCode == FactorInfo.S2Code) return GetS2HourDataDecimalPlaces();
            if (factorCode == FactorInfo.FcCode) return GetFcHourDataDecimalPlaces();
            if (factorCode == FactorInfo.So42Code) return GetSo42HourDataDecimalPlaces();
            if (factorCode == FactorInfo.ClCode) return GetClHourDataDecimalPlaces();
            if (factorCode == FactorInfo.No3Code) return GetNo3HourDataDecimalPlaces();
            if (factorCode == FactorInfo.FeCode) return GetFeHourDataDecimalPlaces();
            if (factorCode == FactorInfo.MnCode) return GetMnHourDataDecimalPlaces();
            if (factorCode == FactorInfo.MoCode) return GetMoHourDataDecimalPlaces();
            if (factorCode == FactorInfo.CoCode) return GetCoHourDataDecimalPlaces();
            if (factorCode == FactorInfo.BeCode) return GetBeHourDataDecimalPlaces();
            if (factorCode == FactorInfo.BCode) return GetBHourDataDecimalPlaces();
            if (factorCode == FactorInfo.SbCode) return GetSbHourDataDecimalPlaces();
            if (factorCode == FactorInfo.NiCode) return GetNiHourDataDecimalPlaces();
            if (factorCode == FactorInfo.BaCode) return GetBaHourDataDecimalPlaces();
            if (factorCode == FactorInfo.AlumCode) return GetAlumHourDataDecimalPlaces();
            if (factorCode == FactorInfo.TiCode) return GetTiHourDataDecimalPlaces();
            if (factorCode == FactorInfo.TlCode) return GetTlHourDataDecimalPlaces();
            if (factorCode == FactorInfo.TcCode) return GetTcHourDataDecimalPlaces();
            if (factorCode == FactorInfo.ChlaCode) return GetChlaHourDataDecimalPlaces();
            if (factorCode == FactorInfo.CCode) return GetCHourDataDecimalPlaces();
            throw new ArgumentOutOfRangeException(nameof(factorCode), "指标编码不在已定义的小时数据指标范围");
            //return factorCode.ToLower() switch
            //{
            //    "w01014" => GetEcHourDataDecimalPlaces(),
            //    "w01003" => GetNtuHourDataDecimalPlaces(),
            //    "w01010" => GetWtHourDataDecimalPlaces(),
            //    "w01001" => GetPhHourDataDecimalPlaces(),
            //    "w01009" => GetDoHourDataDecimalPlaces(),
            //    "w01019" => GetCodmnHourDataDecimalPlaces(),
            //    "w01018" => GetCodHourDataDecimalPlaces(),
            //    "w21003" => GetNh3nHourDataDecimalPlaces(),
            //    "w21011" => GetTpHourDataDecimalPlaces(),
            //    "w21001" => GetTnHourDataDecimalPlaces(),
            //    "w20122" => GetCuHourDataDecimalPlaces(),
            //    "w20123" => GetZnHourDataDecimalPlaces(),
            //    "w21017" => GetFHourDataDecimalPlaces(),
            //    "w20128" => GetSeHourDataDecimalPlaces(),
            //    "w20141" => GetAsHourDataDecimalPlaces(),
            //    "w20111" => GetHgHourDataDecimalPlaces(),
            //    "w20115" => GetCdHourDataDecimalPlaces(),
            //    "w20117" => GetCr6HourDataDecimalPlaces(),
            //    "w20120" => GetPbHourDataDecimalPlaces(),
            //    "w21016" => GetCnHourDataDecimalPlaces(),
            //    "w23002" => GetVpHourDataDecimalPlaces(),
            //    "w22001" => GetTphHourDataDecimalPlaces(),
            //    "w19002" => GetLasHourDataDecimalPlaces(),
            //    "w21019" => GetS2HourDataDecimalPlaces(),
            //    "w02003" => GetFcHourDataDecimalPlaces(),
            //    "w21038" => GetSo42HourDataDecimalPlaces(),
            //    "w21022" => GetClHourDataDecimalPlaces(),
            //    "w21007" => GetNo3HourDataDecimalPlaces(),
            //    "w20125" => GetFeHourDataDecimalPlaces(),
            //    "w20124" => GetMnHourDataDecimalPlaces(),
            //    "w20061" => GetMoHourDataDecimalPlaces(),
            //    "w20038" => GetCoHourDataDecimalPlaces(),
            //    "w20127" => GetBeHourDataDecimalPlaces(),
            //    "w20023" => GetBHourDataDecimalPlaces(),
            //    "w20004" => GetSbHourDataDecimalPlaces(),
            //    "w20121" => GetNiHourDataDecimalPlaces(),
            //    "w20012" => GetBaHourDataDecimalPlaces(),
            //    "w20101" => GetAlHourDataDecimalPlaces(),
            //    "w20095" => GetTiHourDataDecimalPlaces(),
            //    "w20089" => GetTlHourDataDecimalPlaces(),
            //    "w01004" => GetTcHourDataDecimalPlaces(),
            //    "w01016" => GetChlaHourDataDecimalPlaces(),
            //    "w19011" => GetCHourDataDecimalPlaces(),
            //    _=> throw new ArgumentOutOfRangeException(nameof(factorCode), "指标编码不在已定义的小时数据指标范围")
            //};
        }

        /// <summary>
        /// 获取指标评价数据的小数位数
        /// </summary>
        /// <param name="factorCode"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">指标不在定义的范围内则抛出异常</exception>
        /// <exception cref="ArgumentNullException"></exception>
        public static int GetFactorAssessmentDataDecimalPlaces(string factorCode)
        {
            if (string.IsNullOrWhiteSpace(factorCode)) throw new ArgumentNullException(nameof(factorCode));
            if (factorCode == FactorInfo.WtCode) return GetWtAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.PhCode) return GetPhAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.DoCode) return GetDoAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.CodmnCode) return GetCodmnAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.CodCode) return GetCodAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.Bod5Code) return GetBod5AssessmentDecimalPlaces();
            if (factorCode == FactorInfo.Nh3nCode) return GetNh3nAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.TpCode) return GetTpAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.TnCode) return GetTnAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.CuCode) return GetCuAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.ZnCode) return GetZnAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.FCode) return GetFAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.SeCode) return GetSeAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.AsCode) return GetAsAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.HgCode) return GetHgAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.CdCode) return GetCdAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.Cr6Code) return GetCr6AssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.PbCode) return GetPbAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.CnCode) return GetCnAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.VpCode) return GetVpAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.TphCode) return GetTphAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.LasCode) return GetLasAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.S2Code) return GetS2AssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.EcCode) return GetEcAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.NtuCode) return GetNtuAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.TcCode) return GetTcAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.ChlaCode) return GetChlaAssessmentDataDecimalPlaces();
            if (factorCode == FactorInfo.CCode) return GetCAssessmentDataDecimalPlaces();
            throw new ArgumentOutOfRangeException(nameof(factorCode), "指标编码不在已定义的评价数据指标范围");

            //return factorCode.ToLower() switch
            //{
            //    "w01010" => GetWtAssessmentDataDecimalPlaces(),
            //    "w01001" => GetPhAssessmentDataDecimalPlaces(),
            //    "w01009" => GetDoAssessmentDataDecimalPlaces(),
            //    "w01019" => GetCodmnAssessmentDataDecimalPlaces(),
            //    "w01018" => GetCodAssessmentDataDecimalPlaces(),
            //    "w01017" => GetBod5AssessmentDecimalPlaces(),
            //    "w21003" => GetNh3nAssessmentDataDecimalPlaces(),
            //    "w21011" => GetTpAssessmentDataDecimalPlaces(),
            //    "w21001" => GetTnAssessmentDataDecimalPlaces(),
            //    "w20122" => GetCuAssessmentDataDecimalPlaces(),
            //    "w20123" => GetZnAssessmentDataDecimalPlaces(),
            //    "w21017" => GetFAssessmentDataDecimalPlaces(),
            //    "w20128" => GetSeAssessmentDataDecimalPlaces(),
            //    "w20141" => GetAsAssessmentDataDecimalPlaces(),
            //    "w20111" => GetHgAssessmentDataDecimalPlaces(),
            //    "w20115" => GetCdAssessmentDataDecimalPlaces(),
            //    "w20117" => GetCr6AssessmentDataDecimalPlaces(),
            //    "w20120" => GetPbAssessmentDataDecimalPlaces(),
            //    "w21016" => GetCnAssessmentDataDecimalPlaces(),
            //    "w23002" => GetVpAssessmentDataDecimalPlaces(),
            //    "w22001" => GetTphAssessmentDataDecimalPlaces(),
            //    "w19002" => GetLasAssessmentDataDecimalPlaces(),
            //    "w21019" => GetS2AssessmentDataDecimalPlaces(),
            //    "w01014" => GetEcAssessmentDataDecimalPlaces(),
            //    "w01003" => GetNtuAssessmentDataDecimalPlaces(),
            //    "w01004" => GetTcAssessmentDataDecimalPlaces(),
            //    "w01016" => GetChlaAssessmentDataDecimalPlaces(),
            //    "w19011" => GetCAssessmentDataDecimalPlaces(),
            //    _ => throw new ArgumentOutOfRangeException(nameof(factorCode), "指标编码不在已定义的评价数据指标范围")
            //};
        }


        /// <summary>
        /// 水温小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundWtHourData(decimal value) => Round(value, GetWtHourDataDecimalPlaces());

        /// <summary>
        /// 水温评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundWtAssessmentData(decimal value) => Round(value, GetWtAssessmentDataDecimalPlaces());

        /// <summary>
        /// PH小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundPhHourData(decimal value) => Round(value, GetPhHourDataDecimalPlaces());

        /// <summary>
        /// PH评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundPhAssessmentData(decimal value) => Round(value, GetPhAssessmentDataDecimalPlaces());

        /// <summary>
        /// 溶解氧小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundDoHourData(decimal value) => Round(value, GetDoHourDataDecimalPlaces());

        /// <summary>
        /// 溶解氧评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundDoAssessmentData(decimal value) => Round(value, GetDoAssessmentDataDecimalPlaces());

        /// <summary>
        /// 高锰酸盐指数小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundCodmnHourData(decimal value) => Round(value, GetCodmnHourDataDecimalPlaces());

        /// <summary>
        /// 高锰酸盐指数评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundCodmnAssessmentData(decimal value) => Round(value, GetCodmnAssessmentDataDecimalPlaces());

        /// <summary>
        /// 化学需氧量小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundCodHourData(decimal value) => Round(value, GetCodHourDataDecimalPlaces());

        /// <summary>
        /// 化学需氧量评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundCodAssessmentData(decimal value) => Round(value, GetCodAssessmentDataDecimalPlaces());

        /// <summary>
        /// 五日生化需氧量评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundBod5AssessmentData(decimal value) => Round(value, GetBod5AssessmentDecimalPlaces());

        /// <summary>
        /// 氨氮小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundNh3nHourData(decimal value) => Round(value, GetNh3nHourDataDecimalPlaces());

        /// <summary>
        /// 氨氮评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundNh3nAssessmentData(decimal value) => Round(value, GetNh3nAssessmentDataDecimalPlaces());

        /// <summary>
        /// 总磷小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundTpHourData(decimal value) => Round(value, GetTpHourDataDecimalPlaces());

        /// <summary>
        /// 总磷评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundTpAssessmentData(decimal value) => Round(value, GetTpAssessmentDataDecimalPlaces());

        /// <summary>
        /// 总氮小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundTnHourData(decimal value) => Round(value, GetTnHourDataDecimalPlaces());

        /// <summary>
        /// 总氮评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundTnAssessmentData(decimal value) => Round(value, GetTnAssessmentDataDecimalPlaces());

        /// <summary>
        /// 铜小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundCuHourData(decimal value) => Round(value, GetCuHourDataDecimalPlaces());
        /// <summary>
        /// 铜评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundCuAssessmentData(decimal value) => Round(value, GetCuAssessmentDataDecimalPlaces());

        /// <summary>
        /// 锌小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundZnHourData(decimal value) => Round(value, GetZnHourDataDecimalPlaces());
        /// <summary>
        /// 锌评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundZnAssessmentData(decimal value) => Round(value, GetZnAssessmentDataDecimalPlaces());

        /// <summary>
        /// 氟化物小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundFHourData(decimal value) => Round(value, GetFHourDataDecimalPlaces());
        /// <summary>
        /// 氟化物评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundFAssessmentData(decimal value) => Round(value, GetFAssessmentDataDecimalPlaces());

        /// <summary>
        /// 硒小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundSeHourData(decimal value) => Round(value, GetSeHourDataDecimalPlaces());
        /// <summary>
        /// 硒评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundSeAssessmentData(decimal value) => Round(value, GetSeAssessmentDataDecimalPlaces());

        /// <summary>
        /// 砷小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundAsHourData(decimal value) => Round(value, GetAsHourDataDecimalPlaces());
        /// <summary>
        /// 砷评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundAsAssessmentData(decimal value) => Round(value, GetAsAssessmentDataDecimalPlaces());

        /// <summary>
        /// 汞小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundHgHourData(decimal value) => Round(value, GetHgHourDataDecimalPlaces());
        /// <summary>
        /// 汞评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundHgAssessmentData(decimal value) => Round(value, GetHgAssessmentDataDecimalPlaces());

        /// <summary>
        /// 镉小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundCdHourData(decimal value) => Round(value, GetCdHourDataDecimalPlaces());
        /// <summary>
        /// 镉评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundCdAssessmentData(decimal value) => Round(value, GetCdAssessmentDataDecimalPlaces());

        /// <summary>
        /// 六价铬小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundCr6HourData(decimal value) => Round(value, GetCr6HourDataDecimalPlaces());
        /// <summary>
        /// 六价铬评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundCr6AssessmentData(decimal value) => Round(value, GetCr6AssessmentDataDecimalPlaces());

        /// <summary>
        /// 铅小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundPbHourData(decimal value) => Round(value, GetPbHourDataDecimalPlaces());
        /// <summary>
        /// 铅评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundPbAssessmentData(decimal value) => Round(value, GetPbAssessmentDataDecimalPlaces());

        /// <summary>
        /// 氰化物小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundCnHourData(decimal value) => Round(value, GetCnHourDataDecimalPlaces());
        /// <summary>
        /// 氰化物评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundCnAssessmentData(decimal value) => Round(value, GetCnAssessmentDataDecimalPlaces());

        /// <summary>
        /// 挥发酚小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundVpHourData(decimal value) => Round(value, GetVpHourDataDecimalPlaces());
        /// <summary>
        /// 挥发酚评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundVpAssessmentData(decimal value) => Round(value, GetVpAssessmentDataDecimalPlaces());

        /// <summary>
        /// 石油类小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundTphHourData(decimal value) => Round(value, GetTphHourDataDecimalPlaces());
        /// <summary>
        /// 石油类评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundTphAssessmentData(decimal value) => Round(value, GetTphAssessmentDataDecimalPlaces());

        /// <summary>
        /// 阴离子表面活性剂小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundLasHourData(decimal value) => Round(value, GetLasHourDataDecimalPlaces());
        /// <summary>
        /// 阴离子表面活性剂评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundLasAssessmentData(decimal value) => Round(value, GetLasAssessmentDataDecimalPlaces());

        /// <summary>
        /// 硫化物小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundS2HourData(decimal value) => Round(value, GetS2HourDataDecimalPlaces());
        /// <summary>
        /// 硫化物评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundS2AssessmentData(decimal value) => Round(value, GetS2AssessmentDataDecimalPlaces());

        /// <summary>
        /// 粪大肠菌群小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundFcHourData(decimal value) => Round(value, GetFcHourDataDecimalPlaces());

        /// <summary>
        /// 硫酸盐小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundS042HourData(decimal value) => Round(value, GetSo42HourDataDecimalPlaces());

        /// <summary>
        /// 氯化物小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundClHourData(decimal value) => Round(value, GetClHourDataDecimalPlaces());

        /// <summary>
        /// 硝酸盐小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundNo3HourData(decimal value) => Round(value, GetNo3HourDataDecimalPlaces());

        /// <summary>
        /// 铁小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundFeHourData(decimal value) => Round(value, GetFeHourDataDecimalPlaces());

        /// <summary>
        /// 锰小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundMnHourData(decimal value) => Round(value, GetMnHourDataDecimalPlaces());

        /// <summary>
        /// 钼小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundMoHourData(decimal value) => Round(value, GetMoHourDataDecimalPlaces());

        /// <summary>
        /// 钡小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundBaHourData(decimal value) => Round(value, GetBaHourDataDecimalPlaces());

        /// <summary>
        /// 钴小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundCoHourData(decimal value) => Round(value, GetCoHourDataDecimalPlaces());

        /// <summary>
        /// 铍小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundBeHourData(decimal value) => Round(value, GetBeHourDataDecimalPlaces());

        /// <summary>
        /// 硼小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundBHourData(decimal value) => Round(value, GetBHourDataDecimalPlaces());

        /// <summary>
        /// 锑小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundSbHourData(decimal value) => Round(value, GetSbHourDataDecimalPlaces());

        /// <summary>
        /// 镍小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundNiHourData(decimal value) => Round(value, GetNiHourDataDecimalPlaces());

        /// <summary>
        /// 矾小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundAlumHourData(decimal value) => Round(value, GetAlumHourDataDecimalPlaces());

        /// <summary>
        /// 钛小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundTiHourData(decimal value) => Round(value, GetTiHourDataDecimalPlaces());

        /// <summary>
        /// 铊小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundTlHourData(decimal value) => Round(value, GetTlHourDataDecimalPlaces());

        /// <summary>
        /// 电导率小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundEcHourData(decimal value) => Round(value, GetEcHourDataDecimalPlaces());

        /// <summary>
        /// 电导率评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundEcAssessmentData(decimal value) => Round(value, GetEcAssessmentDataDecimalPlaces());

        /// <summary>
        /// 浊度小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundNtuHourData(decimal value) => Round(value, GetNtuHourDataDecimalPlaces());

        /// <summary>
        /// 浊度评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundNtuAssessmentData(decimal value) => Round(value, GetNtuAssessmentDataDecimalPlaces());

        /// <summary>
        /// 透明度小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundTcHourData(decimal value) => Round(value, GetTcHourDataDecimalPlaces());
        /// <summary>
        /// 透明度评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundTcAssessmentData(decimal value) => Round(value, GetTcAssessmentDataDecimalPlaces());

        /// <summary>
        /// 叶绿素a小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundChlaHourData(decimal value) => Round(value, GetChlaHourDataDecimalPlaces());
        /// <summary>
        /// 叶绿素a评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundChlaAssessmentData(decimal value) => Round(value, GetChlaAssessmentDataDecimalPlaces());

        /// <summary>
        /// 藻密度小时数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundCHourData(decimal value) => Round(value, GetCHourDataDecimalPlaces());
        /// <summary>
        /// 藻密度评价数据修约
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal RoundCAssessmentData(decimal value) => Round(value, GetCAssessmentDataDecimalPlaces());


        /// <summary>
        /// 指标小时数据修约
        /// </summary>
        /// <param name="factorCode"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">指标不在定义的范围内则抛出异常</exception>
        /// <exception cref="ArgumentNullException"></exception>
        public static decimal RoundFactorHourData(string factorCode, decimal value)
        {
            if (string.IsNullOrWhiteSpace(factorCode)) throw new ArgumentNullException(nameof(factorCode));
            if (factorCode == FactorInfo.EcCode) return RoundEcHourData(value);
            if (factorCode == FactorInfo.NtuCode) return RoundNtuHourData(value);
            if (factorCode == FactorInfo.WtCode) return RoundWtHourData(value);
            if (factorCode == FactorInfo.PhCode) return RoundPhHourData(value);
            if (factorCode == FactorInfo.DoCode) return RoundDoHourData(value);
            if (factorCode == FactorInfo.CodmnCode) return RoundCodmnHourData(value);
            if (factorCode == FactorInfo.CodCode) return RoundCodHourData(value);
            if (factorCode == FactorInfo.Nh3nCode) return RoundNh3nHourData(value);
            if (factorCode == FactorInfo.TpCode) return RoundTpHourData(value);
            if (factorCode == FactorInfo.TnCode) return RoundTnHourData(value);
            if (factorCode == FactorInfo.CuCode) return RoundCuHourData(value);
            if (factorCode == FactorInfo.ZnCode) return RoundZnHourData(value);
            if (factorCode == FactorInfo.FCode) return RoundFHourData(value);
            if (factorCode == FactorInfo.SeCode) return RoundSeHourData(value);
            if (factorCode == FactorInfo.AsCode) return RoundAsHourData(value);
            if (factorCode == FactorInfo.HgCode) return RoundHgHourData(value);
            if (factorCode == FactorInfo.CdCode) return RoundCdHourData(value);
            if (factorCode == FactorInfo.Cr6Code) return RoundCr6HourData(value);
            if (factorCode == FactorInfo.PbCode) return RoundPbHourData(value);
            if (factorCode == FactorInfo.CnCode) return RoundCnHourData(value);
            if (factorCode == FactorInfo.VpCode) return RoundVpHourData(value);
            if (factorCode == FactorInfo.TphCode) return RoundTphHourData(value);
            if (factorCode == FactorInfo.LasCode) return RoundLasHourData(value);
            if (factorCode == FactorInfo.S2Code) return RoundS2HourData(value);
            if (factorCode == FactorInfo.FcCode) return RoundFcHourData(value);
            if (factorCode == FactorInfo.So42Code) return RoundS042HourData(value);
            if (factorCode == FactorInfo.ClCode) return RoundClHourData(value);
            if (factorCode == FactorInfo.No3Code) return RoundNo3HourData(value);
            if (factorCode == FactorInfo.FeCode) return RoundFeHourData(value);
            if (factorCode == FactorInfo.MnCode) return RoundMnHourData(value);
            if (factorCode == FactorInfo.MoCode) return RoundMoHourData(value);
            if (factorCode == FactorInfo.CoCode) return RoundCoHourData(value);
            if (factorCode == FactorInfo.BeCode) return RoundBeHourData(value);
            if (factorCode == FactorInfo.BCode) return RoundBHourData(value);
            if (factorCode == FactorInfo.SbCode) return RoundSbHourData(value);
            if (factorCode == FactorInfo.NiCode) return RoundNiHourData(value);
            if (factorCode == FactorInfo.BaCode) return RoundBaHourData(value);
            if (factorCode == FactorInfo.AlumCode) return RoundAlumHourData(value);
            if (factorCode == FactorInfo.TiCode) return RoundTiHourData(value);
            if (factorCode == FactorInfo.TlCode) return RoundTlHourData(value);
            if (factorCode == FactorInfo.TcCode) return RoundTcHourData(value);
            if (factorCode == FactorInfo.ChlaCode) return RoundChlaHourData(value);
            if (factorCode == FactorInfo.CCode) return RoundCHourData(value);
            throw new ArgumentOutOfRangeException(nameof(factorCode), "指标编码不在已定义的小时数据指标范围");

            //return factorCode.ToLower() switch
            //{
            //    "w01014" => RoundEcHourData(value),
            //    "w01003" => RoundNtuHourData(value),
            //    "w01010" => RoundWtHourData(value),
            //    "w01001" => RoundPhHourData(value),
            //    "w01009" => RoundDoHourData(value),
            //    "w01019" => RoundCodmnHourData(value),
            //    "w01018" => RoundCodHourData(value),
            //    "w21003" => RoundNh3nHourData(value),
            //    "w21011" => RoundTpHourData(value),
            //    "w21001" => RoundTnHourData(value),
            //    "w20122" => RoundCuHourData(value),
            //    "w20123" => RoundZnHourData(value),
            //    "w21017" => RoundFHourData(value),
            //    "w20128" => RoundSeHourData(value),
            //    "w20141" => RoundAsHourData(value),
            //    "w20111" => RoundHgHourData(value),
            //    "w20115" => RoundCdHourData(value),
            //    "w20117" => RoundCr6HourData(value),
            //    "w20120" => RoundPbHourData(value),
            //    "w21016" => RoundCnHourData(value),
            //    "w23002" => RoundVpHourData(value),
            //    "w22001" => RoundTphHourData(value),
            //    "w19002" => RoundLasHourData(value),
            //    "w21019" => RoundS2HourData(value),
            //    "w02003" => RoundFcHourData(value),
            //    "w21038" => RoundS042HourData(value),
            //    "w21022" => RoundClHourData(value),
            //    "w21007" => RoundNo3HourData(value),
            //    "w20125" => RoundFeHourData(value),
            //    "w20124" => RoundMnHourData(value),
            //    "w20061" => RoundMoHourData(value),
            //    "w20038" => RoundCoHourData(value),
            //    "w20127" => RoundBeHourData(value),
            //    "w20023" => RoundBHourData(value),
            //    "w20004" => RoundSbHourData(value),
            //    "w20121" => RoundNiHourData(value),
            //    "w20012" => RoundBaHourData(value),
            //    "w20101" => RoundAlHourData(value),
            //    "w20095" => RoundTiHourData(value),
            //    "w20089" => RoundTlHourData(value),
            //    "w01004" => RoundTcHourData(value),
            //    "w01016" => RoundChlaHourData(value),
            //    "w19011" => RoundCHourData(value),
            //    _ => throw new ArgumentOutOfRangeException(nameof(factorCode), "指标编码不在已定义的小时数据指标范围")
            //};
        }

        /// <summary>
        /// 指标评价数据修约
        /// </summary>
        /// <param name="factorCode"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException">指标不在定义的范围内则抛出异常</exception>
        public static decimal RoundFactorAssessmentData(string factorCode, decimal value)
        {
            if (string.IsNullOrWhiteSpace(factorCode)) throw new ArgumentNullException(nameof(factorCode));
            if (factorCode == FactorInfo.WtCode) return RoundWtAssessmentData(value);
            if (factorCode == FactorInfo.PhCode) return RoundPhAssessmentData(value);
            if (factorCode == FactorInfo.DoCode) return RoundDoAssessmentData(value);
            if (factorCode == FactorInfo.CodmnCode) return RoundCodmnAssessmentData(value);
            if (factorCode == FactorInfo.CodCode) return RoundCodAssessmentData(value);
            if (factorCode == FactorInfo.Bod5Code) return RoundBod5AssessmentData(value);
            if (factorCode == FactorInfo.Nh3nCode) return RoundNh3nAssessmentData(value);
            if (factorCode == FactorInfo.TpCode) return RoundTpAssessmentData(value);
            if (factorCode == FactorInfo.TnCode) return RoundTnAssessmentData(value);
            if (factorCode == FactorInfo.CuCode) return RoundCuAssessmentData(value);
            if (factorCode == FactorInfo.ZnCode) return RoundZnAssessmentData(value);
            if (factorCode == FactorInfo.FCode) return RoundFAssessmentData(value);
            if (factorCode == FactorInfo.SeCode) return RoundSeAssessmentData(value);
            if (factorCode == FactorInfo.AsCode) return RoundAsAssessmentData(value);
            if (factorCode == FactorInfo.HgCode) return RoundHgAssessmentData(value);
            if (factorCode == FactorInfo.CdCode) return RoundCdAssessmentData(value);
            if (factorCode == FactorInfo.Cr6Code) return RoundCr6AssessmentData(value);
            if (factorCode == FactorInfo.PbCode) return RoundPbAssessmentData(value);
            if (factorCode == FactorInfo.CnCode) return RoundCnAssessmentData(value);
            if (factorCode == FactorInfo.VpCode) return RoundVpAssessmentData(value);
            if (factorCode == FactorInfo.TphCode) return RoundTphAssessmentData(value);
            if (factorCode == FactorInfo.LasCode) return RoundLasAssessmentData(value);
            if (factorCode == FactorInfo.S2Code) return RoundS2AssessmentData(value);
            if (factorCode == FactorInfo.EcCode) return RoundEcAssessmentData(value);
            if (factorCode == FactorInfo.NtuCode) return RoundNtuAssessmentData(value);
            if (factorCode == FactorInfo.TcCode) return RoundTcAssessmentData(value);
            if (factorCode == FactorInfo.ChlaCode) return RoundChlaAssessmentData(value);
            if (factorCode == FactorInfo.CCode) return RoundCAssessmentData(value);
            throw new ArgumentOutOfRangeException(nameof(factorCode), "指标编码不在已定义的评价数据指标范围");

            //return factorCode.ToLower() switch
            //{
            //    "w01010" => RoundWtAssessmentData(value),
            //    "w01001" => RoundPhAssessmentData(value),
            //    "w01009" => RoundDoAssessmentData(value),
            //    "w01019" => RoundCodmnAssessmentData(value),
            //    "w01018" => RoundCodAssessmentData(value),
            //    "w01017" => RoundBod5AssessmentData(value),
            //    "w21003" => RoundNh3nAssessmentData(value),
            //    "w21011" => RoundTpAssessmentData(value),
            //    "w21001" => RoundTnAssessmentData(value),
            //    "w20122" => RoundCuAssessmentData(value),
            //    "w20123" => RoundZnAssessmentData(value),
            //    "w21017" => RoundFAssessmentData(value),
            //    "w20128" => RoundSeAssessmentData(value),
            //    "w20141" => RoundAsAssessmentData(value),
            //    "w20111" => RoundHgAssessmentData(value),
            //    "w20115" => RoundCdAssessmentData(value),
            //    "w20117" => RoundCr6AssessmentData(value),
            //    "w20120" => RoundPbAssessmentData(value),
            //    "w21016" => RoundCnAssessmentData(value),
            //    "w23002" => RoundVpAssessmentData(value),
            //    "w22001" => RoundTphAssessmentData(value),
            //    "w19002" => RoundLasAssessmentData(value),
            //    "w21019" => RoundS2AssessmentData(value),
            //    "w01014" => RoundEcAssessmentData(value),
            //    "w01003" => RoundNtuAssessmentData(value),
            //    "w01004" => RoundTcAssessmentData(value),
            //    "w01016" => RoundChlaAssessmentData(value),
            //    "w19011" => RoundCAssessmentData(value),
            //    _ => throw new ArgumentOutOfRangeException(nameof(factorCode), "指标编码不在已定义的评价数据指标范围")
            //};
        }
    }
}