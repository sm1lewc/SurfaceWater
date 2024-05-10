using SurfaceWater.Models;
using System;

namespace SurfaceWater
{

    /// <summary>
    /// 水质指数相关计算
    /// </summary>
    public class CWQI
    {
        /// <summary>
        /// 获取PH的水质指数(未修约)
        /// </summary>
        /// <remarks>
        /// 2017年《城市地表水环境质量排名技术规定》
        /// GB 3838-2002《地表水环境质量标准》
        /// </remarks>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal? GetPhCwqiV2017V2002(decimal value)
        {
            if (value <= 0) return null;
            if (value <= 7) return 7 - value;
            else return (value - 7) / 2;
        }

        /// <summary>
        /// 获取溶解氧的水质指数(未修约)
        /// </summary>
        /// <remarks>
        /// 2017年《城市地表水环境质量排名技术规定》
        /// GB 3838-2002《地表水环境质量标准》
        /// </remarks>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal? GetDoCwqiV2017V2002(decimal value)
        {
            if (value > 0)
                return EnvironmentalQualityStandards.GetDoStandardV2002(3) / value;
            else return null;
        }

        /// <summary>
        /// 获取高锰酸盐指数的水质指数(未修约)
        /// </summary>
        /// <remarks>
        /// 2017年《城市地表水环境质量排名技术规定》
        /// GB 3838-2002《地表水环境质量标准》
        /// </remarks>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal? GetCodmnCwqiV2017V2002(decimal value)
        {
            return GetFactorCwqiV2017V2002(FactorInfo.CodmnCode, value);
        }

        /// <summary>
        /// 获取化学需氧量的水质指数(未修约)
        /// </summary>
        /// <remarks>
        /// 2017年《城市地表水环境质量排名技术规定》
        /// GB 3838-2002《地表水环境质量标准》
        /// </remarks>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal? GetCodCwqiV2017V2002(decimal value)
        {
            return GetFactorCwqiV2017V2002(FactorInfo.CodCode, value);
        }

        /// <summary>
        /// 获取五日生化需氧量的水质指数(未修约)
        /// </summary>
        /// <remarks>
        /// 2017年《城市地表水环境质量排名技术规定》
        /// GB 3838-2002《地表水环境质量标准》
        /// </remarks>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal? GetBod5CwqiV2017V2002(decimal value)
        {
            return GetFactorCwqiV2017V2002(FactorInfo.Bod5Code, value);
        }

        /// <summary>
        /// 获取氨氮的水质指数(未修约)
        /// </summary>
        /// <remarks>
        /// 2017年《城市地表水环境质量排名技术规定》
        /// GB 3838-2002《地表水环境质量标准》
        /// </remarks>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal? GetNh3nCwqiV2017V2002(decimal value)
        {
            return GetFactorCwqiV2017V2002(FactorInfo.Nh3nCode, value);
        }

        /// <summary>
        /// 获取总磷的水质指数(未修约)
        /// </summary>
        /// <remarks>
        /// 2017年《城市地表水环境质量排名技术规定》
        /// GB 3838-2002《地表水环境质量标准》
        /// </remarks>
        /// <param name="value"></param>
        /// <param name="waterType">河流/湖库</param>
        /// <returns></returns>
        public static decimal? GetTpCwqiV2017V2002(decimal value, string waterType)
        {
            if (value <= 0) return null;
            return value / EnvironmentalQualityStandards.GetFactorStandardV2002(FactorInfo.TpCode, 3, waterType);
        }

        /// <summary>
        /// 获取铜的水质指数(未修约)
        /// </summary>
        /// <remarks>
        /// 2017年《城市地表水环境质量排名技术规定》
        /// GB 3838-2002《地表水环境质量标准》
        /// </remarks>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal? GetCuCwqiV2017V2002(decimal value)
        {
            return GetFactorCwqiV2017V2002(FactorInfo.CuCode, value);
        }

        /// <summary>
        /// 获取锌的水质指数(未修约)
        /// </summary>
        /// <remarks>
        /// 2017年《城市地表水环境质量排名技术规定》
        /// GB 3838-2002《地表水环境质量标准》
        /// </remarks>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal? GetZnCwqiV2017V2002(decimal value)
        {
            return GetFactorCwqiV2017V2002(FactorInfo.ZnCode, value);
        }

        /// <summary>
        /// 获取氟化物的水质指数(未修约)
        /// </summary>
        /// <remarks>
        /// 2017年《城市地表水环境质量排名技术规定》
        /// GB 3838-2002《地表水环境质量标准》
        /// </remarks>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal? GetFCwqiV2017V2002(decimal value)
        {
            return GetFactorCwqiV2017V2002(FactorInfo.FCode, value);
        }

        /// <summary>
        /// 获取硒的水质指数(未修约)
        /// </summary>
        /// <remarks>
        /// 2017年《城市地表水环境质量排名技术规定》
        /// GB 3838-2002《地表水环境质量标准》
        /// </remarks>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal? GetSeCwqiV2017V2002(decimal value)
        {
            return GetFactorCwqiV2017V2002(FactorInfo.SeCode, value);
        }

        /// <summary>
        /// 获取砷的水质指数(未修约)
        /// </summary>
        /// <remarks>
        /// 2017年《城市地表水环境质量排名技术规定》
        /// GB 3838-2002《地表水环境质量标准》
        /// </remarks>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal? GetAsCwqiV2017V2002(decimal value)
        {
            return GetFactorCwqiV2017V2002(FactorInfo.AsCode, value);
        }

        /// <summary>
        /// 获取汞的水质指数(未修约)
        /// </summary>
        /// <remarks>
        /// 2017年《城市地表水环境质量排名技术规定》
        /// GB 3838-2002《地表水环境质量标准》
        /// </remarks>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal? GetHgCwqiV2017V2002(decimal value)
        {
            return GetFactorCwqiV2017V2002(FactorInfo.HgCode, value);
        }

        /// <summary>
        /// 获取镉的水质指数(未修约)
        /// </summary>
        /// <remarks>
        /// 2017年《城市地表水环境质量排名技术规定》
        /// GB 3838-2002《地表水环境质量标准》
        /// </remarks>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal? GetCdCwqiV2017V2002(decimal value)
        {
            return GetFactorCwqiV2017V2002(FactorInfo.CdCode, value);
        }

        /// <summary>
        /// 获取六价铬的水质指数(未修约)
        /// </summary>
        /// <remarks>
        /// 2017年《城市地表水环境质量排名技术规定》
        /// GB 3838-2002《地表水环境质量标准》
        /// </remarks>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal? GetCr6CwqiV2017V2002(decimal value)
        {
            return GetFactorCwqiV2017V2002(FactorInfo.Cr6Code, value);
        }

        /// <summary>
        /// 获取铅的水质指数(未修约)
        /// </summary>
        /// <remarks>
        /// 2017年《城市地表水环境质量排名技术规定》
        /// GB 3838-2002《地表水环境质量标准》
        /// </remarks>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal? GetPbCwqiV2017V2002(decimal value)
        {
            return GetFactorCwqiV2017V2002(FactorInfo.PbCode, value);
        }

        /// <summary>
        /// 获取氰化物的水质指数(未修约)
        /// </summary>
        /// <remarks>
        /// 2017年《城市地表水环境质量排名技术规定》
        /// GB 3838-2002《地表水环境质量标准》
        /// </remarks>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal? GetCnCwqiV2017V2002(decimal value)
        {
            return GetFactorCwqiV2017V2002(FactorInfo.CnCode, value);
        }

        /// <summary>
        /// 获取挥发酚的水质指数(未修约)
        /// </summary>
        /// <remarks>
        /// 2017年《城市地表水环境质量排名技术规定》
        /// GB 3838-2002《地表水环境质量标准》
        /// </remarks>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal? GetVpCwqiV2017V2002(decimal value)
        {
            return GetFactorCwqiV2017V2002(FactorInfo.VpCode, value);
        }

        /// <summary>
        /// 获取石油类的水质指数(未修约)
        /// </summary>
        /// <remarks>
        /// 2017年《城市地表水环境质量排名技术规定》
        /// GB 3838-2002《地表水环境质量标准》
        /// </remarks>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal? GetTphCwqiV2017V2002(decimal value)
        {
            return GetFactorCwqiV2017V2002(FactorInfo.TphCode, value);
        }

        /// <summary>
        /// 获取阴离子表面活性剂的水质指数(未修约)
        /// </summary>
        /// <remarks>
        /// 2017年《城市地表水环境质量排名技术规定》
        /// GB 3838-2002《地表水环境质量标准》
        /// </remarks>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal? GetLasCwqiV2017V2002(decimal value)
        {
            return GetFactorCwqiV2017V2002(FactorInfo.LasCode, value);
        }

        /// <summary>
        /// 获取硫化物的水质指数(未修约)
        /// </summary>
        /// <remarks>
        /// 2017年《城市地表水环境质量排名技术规定》
        /// GB 3838-2002《地表水环境质量标准》
        /// </remarks>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal? GetS2CwqiV2017V2002(decimal value)
        {
            return GetFactorCwqiV2017V2002(FactorInfo.S2Code, value);
        }


        /// <summary>
        /// 获取指标的水质指数(未修约)
        /// </summary>
        /// <remarks>
        /// 2017年《城市地表水环境质量排名技术规定》
        /// GB 3838-2002《地表水环境质量标准》
        /// </remarks>
        /// <param name="factorCode"></param>
        /// <param name="value"></param>
        /// <param name="waterType">河流/湖库</param>
        /// <returns></returns>
        public static decimal? GetFactorCwqiV2017V2002(string factorCode, decimal value, string waterType = "河流")
        {
            if (value <= 0) return null;
            if (factorCode.Equals(FactorInfo.PhCode, StringComparison.CurrentCultureIgnoreCase))
            {
                return GetPhCwqiV2017V2002(value);
            }
            else if (factorCode.Equals(FactorInfo.DoCode, StringComparison.CurrentCultureIgnoreCase))
            {
                return GetDoCwqiV2017V2002(value);
            }
            else if (factorCode.Equals(FactorInfo.TpCode, StringComparison.CurrentCultureIgnoreCase))
            {
                return GetTpCwqiV2017V2002(value, waterType);
            }
            else if (factorCode.Equals(FactorInfo.CodmnCode, StringComparison.CurrentCultureIgnoreCase)
                     || factorCode.Equals(FactorInfo.CodCode, StringComparison.CurrentCultureIgnoreCase)
                     || factorCode.Equals(FactorInfo.Bod5Code, StringComparison.CurrentCultureIgnoreCase)
                     || factorCode.Equals(FactorInfo.Nh3nCode, StringComparison.CurrentCultureIgnoreCase)
                     || factorCode.Equals(FactorInfo.CuCode, StringComparison.CurrentCultureIgnoreCase)
                     || factorCode.Equals(FactorInfo.ZnCode, StringComparison.CurrentCultureIgnoreCase)
                     || factorCode.Equals(FactorInfo.FCode, StringComparison.CurrentCultureIgnoreCase)
                     || factorCode.Equals(FactorInfo.SeCode, StringComparison.CurrentCultureIgnoreCase)
                     || factorCode.Equals(FactorInfo.AsCode, StringComparison.CurrentCultureIgnoreCase)
                     || factorCode.Equals(FactorInfo.HgCode, StringComparison.CurrentCultureIgnoreCase)
                     || factorCode.Equals(FactorInfo.CdCode, StringComparison.CurrentCultureIgnoreCase)
                     || factorCode.Equals(FactorInfo.Cr6Code, StringComparison.CurrentCultureIgnoreCase)
                     || factorCode.Equals(FactorInfo.PbCode, StringComparison.CurrentCultureIgnoreCase)
                     || factorCode.Equals(FactorInfo.CnCode, StringComparison.CurrentCultureIgnoreCase)
                     || factorCode.Equals(FactorInfo.VpCode, StringComparison.CurrentCultureIgnoreCase)
                     || factorCode.Equals(FactorInfo.TphCode, StringComparison.CurrentCultureIgnoreCase)
                     || factorCode.Equals(FactorInfo.LasCode, StringComparison.CurrentCultureIgnoreCase)
                     || factorCode.Equals(FactorInfo.S2Code, StringComparison.CurrentCultureIgnoreCase))
            {

                return value / EnvironmentalQualityStandards.GetFactorStandardV2002(factorCode, 3);
            }
            else throw new ArgumentOutOfRangeException(nameof(factorCode), "指标编码不在21项指标范围");
        }

        /// <summary>
        /// 计算整体水质指数
        /// </summary>
        /// <param name="ph"></param>
        /// <param name="doValue"></param>
        /// <param name="codmn"></param>
        /// <param name="cod"></param>
        /// <param name="bod5"></param>
        /// <param name="nh3n"></param>
        /// <param name="tp"></param>
        /// <param name="cu"></param>
        /// <param name="zn"></param>
        /// <param name="f"></param>
        /// <param name="se"></param>
        /// <param name="asValue"></param>
        /// <param name="hg"></param>
        /// <param name="cd"></param>
        /// <param name="cr6"></param>
        /// <param name="pb"></param>
        /// <param name="cn"></param>
        /// <param name="vp"></param>
        /// <param name="tph"></param>
        /// <param name="las"></param>
        /// <param name="s2"></param>
        /// <param name="waterBody">河流/湖库</param>
        /// <returns></returns>
        public static OverallCWQI GetOverallCwqiV2017V2002(decimal ph,
                                                       decimal doValue,
                                                       decimal codmn,
                                                       decimal cod,
                                                       decimal bod5,
                                                       decimal nh3n,
                                                       decimal tp,
                                                       decimal cu,
                                                       decimal zn,
                                                       decimal f,
                                                       decimal se,
                                                       decimal asValue,
                                                       decimal hg,
                                                       decimal cd,
                                                       decimal cr6,
                                                       decimal pb,
                                                       decimal cn,
                                                       decimal vp,
                                                       decimal tph,
                                                       decimal las,
                                                       decimal s2,
                                                       string waterBody = "河流")
        {
            //计算所有参数的cwqi
            var phCwqi = GetPhCwqiV2017V2002(ph);
            var doCwqi = GetDoCwqiV2017V2002(doValue);
            var codmnCwqi = GetCodmnCwqiV2017V2002(codmn);
            var codCwqi = GetCodCwqiV2017V2002(cod);
            var bod5Cwqi = GetBod5CwqiV2017V2002(bod5);
            var nh3nCwqi = GetNh3nCwqiV2017V2002(nh3n);
            var tpCwqi = GetTpCwqiV2017V2002(tp, waterBody);
            var cuCwqi = GetCuCwqiV2017V2002(cu);
            var znCwqi = GetZnCwqiV2017V2002(zn);
            var fCwqi = GetFCwqiV2017V2002(f);
            var seCwqi = GetSeCwqiV2017V2002(se);
            var asCwqi = GetAsCwqiV2017V2002(asValue);
            var hgCwqi = GetHgCwqiV2017V2002(hg);
            var cdCwqi = GetCdCwqiV2017V2002(cd);
            var cr6Cwqi = GetCr6CwqiV2017V2002(cr6);
            var pbCwqi = GetPbCwqiV2017V2002(pb);
            var cnCwqi = GetCnCwqiV2017V2002(cn);
            var vpCwqi = GetVpCwqiV2017V2002(vp);
            var tphCwqi = GetTphCwqiV2017V2002(tph);
            var lasCwqi = GetLasCwqiV2017V2002(las);
            var s2Cwqi = GetS2CwqiV2017V2002(s2);
            return new OverallCWQI(phCwqi, doCwqi, codmnCwqi, codCwqi, bod5Cwqi, nh3nCwqi, tpCwqi, cuCwqi, znCwqi, fCwqi, seCwqi, asCwqi, hgCwqi, cdCwqi, cr6Cwqi, pbCwqi, cnCwqi, vpCwqi, tphCwqi, lasCwqi, s2Cwqi);
        }
    }
}