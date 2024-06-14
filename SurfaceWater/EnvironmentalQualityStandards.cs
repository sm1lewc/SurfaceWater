using SurfaceWater.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;

namespace SurfaceWater
{

    /// <summary>
    /// 地表水环境质量标准
    /// GB 3838
    /// </summary>
    public class EnvironmentalQualityStandards
    {
        #region pH

        /// <summary>
        /// 计算pH的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeroType">true:0算劣Ⅴ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetPhGradeV2002(decimal value, bool zeroType = false)
        {
            if (value < 0) return null;
            else if (value == 0)
            {
                if (zeroType) return new WaterGrade(6);
                else return null;
            }
            else if (value >= 6 && value <= 9) return new WaterGrade(1);
            else return new WaterGrade(6);
        }

        /// <summary>
        /// 获取pH的标准值
        /// </summary>
        public static (decimal, decimal) GetPhStandardV2002() => (6, 9);

        /// <summary>
        /// 获取ph的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetPhName() => FactorInfo.PhName;

        /// <summary>
        /// 获取ph的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetPhCode() => FactorInfo.PhCode;
        #endregion

        #region 溶解氧 DO
        /// <summary>
        /// 计算溶解氧的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeroType">true:0算劣Ⅴ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetDoGradeV2002(decimal value, bool zeroType = false)
        {
            if (value < 0) return null;
            if (value == 0)
            {
                if (zeroType) return new WaterGrade(6);
                else return null;
            }
            if (value >= 7.5m) return new WaterGrade(1);
            if (value >= 6) return new WaterGrade(2);
            if (value >= 5) return new WaterGrade(3);
            if (value >= 3) return new WaterGrade(4);
            if (value >= 2) return new WaterGrade(5);
            return new WaterGrade(6);
        }

        /// <summary>
        /// 获取溶解氧的标准限值
        /// </summary>
        /// <returns></returns>
        public static List<WaterStandard> GetDoStandardV2002() => new List<WaterStandard>()
        {
            new WaterStandard(){ Grade = 1, Standard = 7.5m},
            new WaterStandard(){ Grade = 2, Standard = 6},
            new WaterStandard(){ Grade = 3, Standard = 5},
            new WaterStandard(){ Grade = 4, Standard = 3},
            new WaterStandard(){ Grade = 5, Standard = 2}
        };


        /// <summary>
        /// 获取溶解氧某个类别的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetDoStandardV2002(int grade)
        {
            return grade switch
            {
                1 => 7.5m,
                2 => 6,
                3 => 5,
                4 => 3,
                5 => 2,
                _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
            };
        }

        /// <summary>
        /// 获取溶解氧的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetDoName() => FactorInfo.DoName;

        /// <summary>
        /// 获取溶解氧的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetDoCode() => FactorInfo.DoCode;
        #endregion

        #region 高锰酸盐指数 CODMN
        /// <summary>
        /// 计算高锰酸盐指数的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeroType">true:0算Ⅰ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetCodmnGradeV2002(decimal value, bool zeroType = false)
        {
            if (value < 0) return null;
            if (value == 0)
            {
                if (zeroType) return new WaterGrade(1);
                else return null;
            }
            if (value <= 2) return new WaterGrade(1);
            if (value <= 4) return new WaterGrade(2);
            if (value <= 6) return new WaterGrade(3);
            if (value <= 10) return new WaterGrade(4);
            if (value <= 15) return new WaterGrade(5);
            return new WaterGrade(6);
        }

        /// <summary>
        /// 获取高锰酸盐指数的标准限值
        /// </summary>
        public static List<WaterStandard> GetCodmnStandardV2002() => new List<WaterStandard>()
        {
            new WaterStandard(){ Grade = 1, Standard = 2},
            new WaterStandard(){ Grade = 2, Standard = 4},
            new WaterStandard(){ Grade = 3, Standard = 6},
            new WaterStandard(){ Grade = 4, Standard = 10},
            new WaterStandard(){ Grade = 5, Standard = 15}
        };

        /// <summary>
        /// 获取高锰酸盐指数某个类别的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetCodmnStandardV2002(int grade) => grade switch
        {
            1 => 2,
            2 => 4,
            3 => 6,
            4 => 10,
            5 => 15,
            _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
        };

        /// <summary>
        /// 获取高锰酸盐指数的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetCodmnName() => FactorInfo.CodmnName;

        /// <summary>
        /// 获取高锰酸盐指数的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetCodmnCode() => FactorInfo.CodmnCode;
        #endregion

        #region 化学需氧量 COD

        /// <summary>
        /// 计算化学需氧量的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeroType">true:0算Ⅰ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetCodGradeV2002(decimal value, bool zeroType = false)
        {
            if (value < 0) return null;
            if (value == 0)
            {
                if (zeroType) return new WaterGrade(1);
                else return null;
            }
            if (value <= 15) return new WaterGrade(1);
            if (value <= 20) return new WaterGrade(3);
            if (value <= 30) return new WaterGrade(4);
            if (value <= 40) return new WaterGrade(5);
            return new WaterGrade(6);
        }

        /// <summary>
        /// 获取化学需氧量的标准限值
        /// </summary>
        /// <returns></returns>
        public static List<WaterStandard> GetCodStandardV2002() => new List<WaterStandard>()
        {
            new WaterStandard() { Grade = 1, Standard = 15},
            new WaterStandard() { Grade = 2, Standard = 15},
            new WaterStandard() { Grade = 3, Standard = 20},
            new WaterStandard() { Grade = 4, Standard = 30},
            new WaterStandard() { Grade = 5, Standard = 40}
        };

        /// <summary>
        /// 获取化学需氧量某个类别的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetCodStandardV2002(int grade) => grade switch
        {
            1 => 15,
            2 => 15,
            3 => 20,
            4 => 30,
            5 => 40,
            _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
        };

        /// <summary>
        /// 获取化学需氧量的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetCodName() => FactorInfo.CodName;

        /// <summary>
        /// 获取化学需氧量的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetCodCode() => FactorInfo.CodCode;

        #endregion

        #region 五日生化需氧量 BOD5

        /// <summary>
        /// 计算五日生化需氧量的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeroType">true:0算Ⅰ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetBod5GradeV2002(decimal value, bool zeroType = false)
        {
            if (value < 0) return null;
            if (value == 0)
            {
                if (zeroType) return new WaterGrade(1);
                else return null;
            }
            if (value <= 3) return new WaterGrade(1);
            if (value <= 4) return new WaterGrade(3);
            if (value <= 6) return new WaterGrade(4);
            if (value <= 10) return new WaterGrade(5);
            return new WaterGrade(6);
        }

        /// <summary>
        /// 获取五日生化需氧量的标准限值
        /// </summary>
        /// <returns></returns>
        public static List<WaterStandard> GetBod5StandardV2002() => new List<WaterStandard>()
        {
            new WaterStandard() { Grade = 1, Standard = 3 },
            new WaterStandard() { Grade = 2, Standard = 3 },
            new WaterStandard() { Grade = 3, Standard = 4 },
            new WaterStandard() { Grade = 4, Standard = 6 },
            new WaterStandard() { Grade = 5, Standard = 10 }
        };

        /// <summary>
        /// 获取五日生化需氧量某个类别的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetBod5StandardV2002(int grade) => grade switch
        {
            1 => 3,
            2 => 3,
            3 => 4,
            4 => 6,
            5 => 10,
            _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
        };

        /// <summary>
        /// 获取五日生化需氧量的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetBod5Name() => FactorInfo.Bod5Name;

        /// <summary>
        /// 获取五日生化需氧量的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetBod5Code() => FactorInfo.Bod5Code;

        #endregion

        #region 氨氮 NH3N

        /// <summary>
        /// 计算氨氮的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeroType">true:0算Ⅰ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetNh3nGradeV2002(decimal value, bool zeroType = false)
        {
            if (value < 0) return null;
            if (value == 0)
            {
                if (zeroType) return new WaterGrade(1);
                else return null;
            }
            if (value <= 0.15m) return new WaterGrade(1);
            if (value <= 0.5m) return new WaterGrade(2);
            if (value <= 1) return new WaterGrade(3);
            if (value <= 1.5m) return new WaterGrade(4);
            if (value <= 2) return new WaterGrade(5);
            return new WaterGrade(6);
        }

        /// <summary>
        /// 获取氨氮的标准限值
        /// </summary>
        /// <returns></returns>
        public static List<WaterStandard> GetNh3nStandardV2002() => new List<WaterStandard>()
        {
            new WaterStandard() { Grade = 1, Standard = 0.15m },
            new WaterStandard() { Grade = 2, Standard = 0.5m },
            new WaterStandard() { Grade = 3, Standard = 1 },
            new WaterStandard() { Grade = 4, Standard = 1.5m },
            new WaterStandard() { Grade = 5, Standard = 2 }
        };

        /// <summary>
        /// 获取氨氮某个类别的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetNh3nStandardV2002(int grade) => grade switch
        {
            1 => 0.15m,
            2 => 0.5m,
            3 => 1,
            4 => 1.5m,
            5 => 2,
            _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
        };

        /// <summary>
        /// 获取氨氮的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetNh3nName() => FactorInfo.Nh3nName;

        /// <summary>
        /// 获取氨氮的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetNh3nCode() => FactorInfo.Nh3nCode;

        #endregion

        #region 总磷 TP

        /// <summary>
        /// 计算总磷的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="waterType">河流/湖库</param>
        /// <param name="zeroType">true:0算Ⅰ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetTpGradeV2002(decimal value, string waterType = "河流", bool zeroType = false)
        {
            if (value < 0) return null;
            if (value == 0)
            {
                if (zeroType) return new WaterGrade(1);
                else return null;
            }
            if (waterType == "河流")
            {
                if (value <= 0.02m) return new WaterGrade(1);
                if (value <= 0.1m) return new WaterGrade(2);
                if (value <= 0.2m) return new WaterGrade(3);
                if (value <= 0.3m) return new WaterGrade(4);
                if (value <= 0.4m) return new WaterGrade(5);
                return new WaterGrade(6);
            }
            else
            {
                if (value <= 0.01m) return new WaterGrade(1);
                if (value <= 0.025m) return new WaterGrade(2);
                if (value <= 0.05m) return new WaterGrade(3);
                if (value <= 0.1m) return new WaterGrade(4);
                if (value <= 0.2m) return new WaterGrade(5);
                return new WaterGrade(6);

            }
        }

        /// <summary>
        /// 获取总磷的标准限值
        /// </summary>
        /// <param name="waterType"></param>
        /// <returns></returns>
        public static List<WaterStandard> GetTpStandardV2002(string waterType = "河流")
        {
            return waterType switch
            {
                "河流" => new List<WaterStandard>()
                {
                    new WaterStandard() { Grade = 1, Standard = 0.02m },
                    new WaterStandard() { Grade = 2, Standard = 0.1m },
                    new WaterStandard() { Grade = 3, Standard = 0.2m },
                    new WaterStandard() { Grade = 4, Standard = 0.3m },
                    new WaterStandard() { Grade = 5, Standard = 0.4m }
                },
                _ => new List<WaterStandard>()
                {
                    new WaterStandard() { Grade = 1, Standard = 0.01m },
                    new WaterStandard() { Grade = 2, Standard = 0.025m },
                    new WaterStandard() { Grade = 3, Standard = 0.05m },
                    new WaterStandard() { Grade = 4, Standard = 0.1m },
                    new WaterStandard() { Grade = 5, Standard = 0.2m }
                }
            };
        }

        /// <summary>
        /// 获取总磷某个类别的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <param name="waterType"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetTpStandardV2002(int grade, string waterType = "河流") => waterType switch
        {
            "河流" => grade switch
            {
                1 => 0.02m,
                2 => 0.1m,
                3 => 0.2m,
                4 => 0.3m,
                5 => 0.4m,
                _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
            },
            _ => grade switch
            {
                1 => 0.01m,
                2 => 0.025m,
                3 => 0.05m,
                4 => 0.1m,
                5 => 0.2m,
                _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
            }
        };

        /// <summary>
        /// 获取总磷的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetTpName() => FactorInfo.TpName;

        /// <summary>
        /// 获取总磷的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetTpCode() => FactorInfo.TpCode;

        #endregion

        #region 总氮 TN

        /// <summary>
        /// 计算总氮的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeroType">true:0算Ⅰ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetTnGradeV2002(decimal value, bool zeroType = false)
        {
            if (value < 0) return null;
            if (value == 0)
            {
                if (zeroType) return new WaterGrade(1);
                else return null;
            }
            if (value <= 0.2m) return new WaterGrade(1);
            if (value <= 0.5m) return new WaterGrade(2);
            if (value <= 1) return new WaterGrade(3);
            if (value <= 1.5m) return new WaterGrade(4);
            if (value <= 2) return new WaterGrade(5);
            return new WaterGrade(6);
        }

        /// <summary>
        /// 获取总氮的标准限值
        /// </summary>
        /// <returns></returns>
        public static List<WaterStandard> GetTnStandardV2002() => new List<WaterStandard>()
        {
            new WaterStandard() { Grade = 1, Standard = 0.2m },
            new WaterStandard() { Grade = 2, Standard = 0.5m },
            new WaterStandard() { Grade = 3, Standard = 1 },
            new WaterStandard() { Grade = 4, Standard = 1.5m },
            new WaterStandard() { Grade = 5, Standard = 2 }
        };

        /// <summary>
        /// 获取总氮某个类别的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetTnStandardV2002(int grade) => grade switch
        {
            1 => 0.2m,
            2 => 0.5m,
            3 => 1,
            4 => 1.5m,
            5 => 2,
            _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
        };

        /// <summary>
        /// 获取总氮的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetTnName() => FactorInfo.TnName;

        /// <summary>
        /// 获取总氮的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetTnCode() => FactorInfo.TnCode;

        #endregion

        #region 铜 CU

        /// <summary>
        /// 计算铜的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeroType">true:0算Ⅰ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetCuGradeV2002(decimal value, bool zeroType = false)
        {
            if (value < 0) return null;
            if (value == 0)
            {
                if (zeroType) return new WaterGrade(1);
                else return null;
            }
            if (value <= 0.01m) return new WaterGrade(1);
            if (value <= 1) return new WaterGrade(2);
            return new WaterGrade(6);
        }

        /// <summary>
        /// 获取铜的标准限值
        /// </summary>
        /// <returns></returns>
        public static List<WaterStandard> GetCuStandardV2002() => new List<WaterStandard>()
        {
            new WaterStandard() { Grade = 1, Standard = 0.01m },
            new WaterStandard() { Grade = 2, Standard = 1 },
            new WaterStandard() { Grade = 3, Standard = 1 },
            new WaterStandard() { Grade = 4, Standard = 1 },
            new WaterStandard() { Grade = 5, Standard = 1 }
        };

        /// <summary>
        /// 获取铜某个类别的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetCuStandardV2002(int grade) => grade switch
        {
            1 => 0.01m,
            2 => 1,
            3 => 1,
            4 => 1,
            5 => 1,
            _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
        };

        /// <summary>
        /// 获取铜的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetCuName() => FactorInfo.CuName;

        /// <summary>
        /// 获取铜的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetCuCode() => FactorInfo.CuCode;

        #endregion

        #region 锌 ZN

        /// <summary>
        /// 计算锌的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeroType">true:0算Ⅰ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetZnGradeV2002(decimal value, bool zeroType = false)
        {
            if (value < 0) return null;
            if (value == 0)
            {
                if (zeroType) return new WaterGrade(1);
                else return null;
            }
            if (value <= 0.05m) return new WaterGrade(1);
            if (value <= 1) return new WaterGrade(2);
            if (value <= 2) return new WaterGrade(4);
            return new WaterGrade(6);
        }

        /// <summary>
        /// 获取锌的标准限值
        /// </summary>
        /// <returns></returns>
        public static List<WaterStandard> GetZnStandardV2002() => new List<WaterStandard>()
        {
            new WaterStandard() { Grade = 1, Standard = 0.05m },
            new WaterStandard() { Grade = 2, Standard = 1 },
            new WaterStandard() { Grade = 3, Standard = 1 },
            new WaterStandard() { Grade = 4, Standard = 2 },
            new WaterStandard() { Grade = 5, Standard = 2 }
        };

        /// <summary>
        /// 获取锌某个类别的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetZnStandardV2002(int grade) => grade switch
        {
            1 => 0.05m,
            2 => 1,
            3 => 1,
            4 => 2,
            5 => 2,
            _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
        };

        /// <summary>
        /// 获取锌的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetZnName() => FactorInfo.ZnName;

        /// <summary>
        /// 获取锌的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetZnCode() => FactorInfo.ZnCode;

        #endregion

        #region 氟化物 F

        /// <summary>
        /// 计算氟化物的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeroType">true:0算Ⅰ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetFGradeV2002(decimal value, bool zeroType = false)
        {
            if (value < 0) return null;
            if (value == 0)
            {
                if (zeroType) return new WaterGrade(1);
                else return null;
            }
            if (value <= 1) return new WaterGrade(1);
            if (value <= 1.5m) return new WaterGrade(4);
            return new WaterGrade(6);
        }

        /// <summary>
        /// 获取氟化物的标准限值
        /// </summary>
        /// <returns></returns>
        public static List<WaterStandard> GetFStandardV2002() => new List<WaterStandard>()
        {
            new WaterStandard() { Grade = 1, Standard = 1 },
            new WaterStandard() { Grade = 2, Standard = 1 },
            new WaterStandard() { Grade = 3, Standard = 1 },
            new WaterStandard() { Grade = 4, Standard = 1.5m },
            new WaterStandard() { Grade = 5, Standard = 1.5m }
        };

        /// <summary>
        /// 获取氟化物某个类别的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetFStandardV2002(int grade) => grade switch
        {
            1 => 1,
            2 => 1,
            3 => 1,
            4 => 1.5m,
            5 => 1.5m,
            _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
        };

        /// <summary>
        /// 获取氟化物的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetFName() => FactorInfo.FName;

        /// <summary>
        /// 获取氟化物的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetFCode() => FactorInfo.FCode;

        #endregion

        #region 硒 SE

        /// <summary>
        /// 计算硒的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeroType">true:0算Ⅰ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetSeGradeV2002(decimal value, bool zeroType = false)
        {
            if (value < 0) return null;
            if (value == 0)
            {
                if (zeroType) return new WaterGrade(1);
                else return null;
            }
            if (value <= 0.01m) return new WaterGrade(1);
            if (value <= 0.02m) return new WaterGrade(4);
            return new WaterGrade(6);
        }

        /// <summary>
        /// 获取硒的标准限值
        /// </summary>
        /// <returns></returns>
        public static List<WaterStandard> GetSeStandardV2002() => new List<WaterStandard>()
        {
            new WaterStandard() { Grade = 1, Standard = 0.01m },
            new WaterStandard() { Grade = 2, Standard = 0.01m },
            new WaterStandard() { Grade = 3, Standard = 0.01m },
            new WaterStandard() { Grade = 4, Standard = 0.02m },
            new WaterStandard() { Grade = 5, Standard = 0.02m }
        };

        /// <summary>
        /// 获取硒某个类别的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetSeStandardV2002(int grade) => grade switch
        {
            1 => 0.01m,
            2 => 0.01m,
            3 => 0.01m,
            4 => 0.02m,
            5 => 0.02m,
            _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
        };

        /// <summary>
        /// 获取硒的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetSeName() => FactorInfo.SeName;

        /// <summary>
        /// 获取硒的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetSeCode() => FactorInfo.SeCode;

        #endregion

        #region 砷 AS

        /// <summary>
        /// 计算砷的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeroType">true:0算Ⅰ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetAsGradeV2002(decimal value, bool zeroType = false)
        {
            if (value < 0) return null;
            if (value == 0)
            {
                if (zeroType) return new WaterGrade(1);
                else return null;
            }
            if (value <= 0.05m) return new WaterGrade(1);
            if (value <= 0.1m) return new WaterGrade(4);
            return new WaterGrade(6);
        }

        /// <summary>
        /// 获取砷的标准限值
        /// </summary>
        /// <returns></returns>
        public static List<WaterStandard> GetAsStandardV2002() => new List<WaterStandard>()
        {
            new WaterStandard() { Grade = 1, Standard = 0.05m },
            new WaterStandard() { Grade = 2, Standard = 0.05m },
            new WaterStandard() { Grade = 3, Standard = 0.05m },
            new WaterStandard() { Grade = 4, Standard = 0.1m },
            new WaterStandard() { Grade = 5, Standard = 0.1m }
        };

        /// <summary>
        /// 获取砷某个类别的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetAsStandardV2002(int grade) => grade switch
        {
            1 => 0.05m,
            2 => 0.05m,
            3 => 0.05m,
            4 => 0.1m,
            5 => 0.1m,
            _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
        };

        /// <summary>
        /// 获取砷的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetAsName() => FactorInfo.AsName;

        /// <summary>
        /// 获取砷的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetAsCode() => FactorInfo.AsCode;

        #endregion

        #region 汞 HG

        /// <summary>
        /// 计算汞的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeroType">true:0算Ⅰ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetHgGradeV2002(decimal value, bool zeroType = false)
        {
            if (value < 0) return null;
            if (value == 0)
            {
                if (zeroType) return new WaterGrade(1);
                else return null;
            }
            if (value <= 0.00005m) return new WaterGrade(1);
            if (value <= 0.0001m) return new WaterGrade(3);
            if (value <= 0.001m) return new WaterGrade(4);
            return new WaterGrade(6);
        }

        /// <summary>
        /// 获取汞的标准限值
        /// </summary>
        /// <returns></returns>
        public static List<WaterStandard> GetHgStandardV2002() => new List<WaterStandard>()
        {
            new WaterStandard() { Grade = 1, Standard = 0.00005m },
            new WaterStandard() { Grade = 2, Standard = 0.00005m },
            new WaterStandard() { Grade = 3, Standard = 0.0001m },
            new WaterStandard() { Grade = 4, Standard = 0.001m },
            new WaterStandard() { Grade = 5, Standard = 0.001m }
        };

        /// <summary>
        /// 获取汞某个类别的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetHgStandardV2002(int grade) => grade switch
        {
            1 => 0.00005m,
            2 => 0.00005m,
            3 => 0.0001m,
            4 => 0.001m,
            5 => 0.001m,
            _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
        };

        /// <summary>
        /// 获取汞的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetHgName() => FactorInfo.HgName;

        /// <summary>
        /// 获取汞的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetHgCode() => FactorInfo.HgCode;

        #endregion

        #region 镉 CD

        /// <summary>
        /// 计算镉的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeroType">true:0算Ⅰ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetCdGradeV2002(decimal value, bool zeroType = false)
        {
            if (value < 0) return null;
            if (value == 0)
            {
                if (zeroType) return new WaterGrade(1);
                else return null;
            }
            if (value <= 0.001m) return new WaterGrade(1);
            if (value <= 0.005m) return new WaterGrade(2);
            if (value <= 0.01m) return new WaterGrade(5);
            return new WaterGrade(6);
        }

        /// <summary>
        /// 获取镉的标准限值
        /// </summary>
        /// <returns></returns>
        public static List<WaterStandard> GetCdStandardV2002() => new List<WaterStandard>()
        {
            new WaterStandard() { Grade = 1, Standard = 0.001m },
            new WaterStandard() { Grade = 2, Standard = 0.005m },
            new WaterStandard() { Grade = 3, Standard = 0.005m },
            new WaterStandard() { Grade = 4, Standard = 0.005m },
            new WaterStandard() { Grade = 5, Standard = 0.01m }
        };

        /// <summary>
        /// 获取镉某个类别的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetCdStandardV2002(int grade) => grade switch
        {
            1 => 0.001m,
            2 => 0.005m,
            3 => 0.005m,
            4 => 0.005m,
            5 => 0.01m,
            _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
        };

        /// <summary>
        /// 获取镉的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetCdName() => FactorInfo.CdName;

        /// <summary>
        /// 获取镉的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetCdCode() => FactorInfo.CdCode;

        #endregion

        #region 六价铬 CR6

        /// <summary>
        /// 计算六价铬的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeroType">true:0算Ⅰ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetCr6GradeV2002(decimal value, bool zeroType = false)
        {
            if (value < 0) return null;
            if (value == 0)
            {
                if (zeroType) return new WaterGrade(1);
                else return null;
            }
            if (value <= 0.01m) return new WaterGrade(1);
            if (value <= 0.05m) return new WaterGrade(2);
            if (value <= 0.1m) return new WaterGrade(5);
            return new WaterGrade(6);
        }

        /// <summary>
        /// 获取六价铬的标准限值
        /// </summary>
        /// <returns></returns>
        public static List<WaterStandard> GetCr6StandardV2002() => new List<WaterStandard>()
        {
            new WaterStandard() { Grade = 1, Standard = 0.01m },
            new WaterStandard() { Grade = 2, Standard = 0.05m },
            new WaterStandard() { Grade = 3, Standard = 0.05m },
            new WaterStandard() { Grade = 4, Standard = 0.05m },
            new WaterStandard() { Grade = 5, Standard = 0.1m }
        };

        /// <summary>
        /// 获取六价铬某个类别的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetCr6StandardV2002(int grade) => grade switch
        {
            1 => 0.01m,
            2 => 0.05m,
            3 => 0.05m,
            4 => 0.05m,
            5 => 0.1m,
            _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
        };

        /// <summary>
        /// 获取六价铬的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetCr6Name() => FactorInfo.Cr6Name;

        /// <summary>
        /// 获取六价铬的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetCr6Code() => FactorInfo.Cr6Code;

        #endregion

        #region 铅 PB

        /// <summary>
        /// 计算铅的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeroType">true:0算Ⅰ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetPbGradeV2002(decimal value, bool zeroType = false)
        {
            if (value < 0) return null;
            if (value == 0)
            {
                if (zeroType) return new WaterGrade(1);
                else return null;
            }
            if (value <= 0.01m) return new WaterGrade(1);
            if (value <= 0.05m) return new WaterGrade(3);
            if (value <= 0.1m) return new WaterGrade(5);
            return new WaterGrade(6);
        }
        /// <summary>
        /// 获取铅的标准限值
        /// </summary>
        /// <returns></returns>
        public static List<WaterStandard> GetPbStandardV2002() => new List<WaterStandard>()
        {
            new WaterStandard() { Grade = 1, Standard = 0.01m },
            new WaterStandard() { Grade = 2, Standard = 0.01m },
            new WaterStandard() { Grade = 3, Standard = 0.05m },
            new WaterStandard() { Grade = 4, Standard = 0.05m },
            new WaterStandard() { Grade = 5, Standard = 0.1m }
        };

        /// <summary>
        /// 获取铅某个类别的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetPbStandardV2002(int grade) => grade switch
        {
            1 => 0.01m,
            2 => 0.01m,
            3 => 0.05m,
            4 => 0.05m,
            5 => 0.1m,
            _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
        };

        /// <summary>
        /// 获取铅的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetPbName() => FactorInfo.PbName;

        /// <summary>
        /// 获取铅的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetPbCode() => FactorInfo.PbCode;

        #endregion

        #region 氰化物 CN

        /// <summary>
        /// 计算氰化物的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeroType">true:0算Ⅰ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetCnGradeV2002(decimal value, bool zeroType = false)
        {
            if (value < 0) return null;
            if (value == 0)
            {
                if (zeroType) return new WaterGrade(1);
                else return null;
            }
            if (value <= 0.005m) return new WaterGrade(1);
            if (value <= 0.05m) return new WaterGrade(2);
            if (value <= 0.2m) return new WaterGrade(3);
            return new WaterGrade(6);
        }

        /// <summary>
        /// 获取氰化物的标准限值
        /// </summary>
        /// <returns></returns>
        public static List<WaterStandard> GetCnStandardV2002() => new List<WaterStandard>()
        {
            new WaterStandard() { Grade = 1, Standard = 0.005m },
            new WaterStandard() { Grade = 2, Standard = 0.05m },
            new WaterStandard() { Grade = 3, Standard = 0.2m },
            new WaterStandard() { Grade = 4, Standard = 0.2m },
            new WaterStandard() { Grade = 5, Standard = 0.2m }
        };

        /// <summary>
        /// 获取氰化物某个类别的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetCnStandardV2002(int grade) => grade switch
        {
            1 => 0.005m,
            2 => 0.05m,
            3 => 0.2m,
            4 => 0.2m,
            5 => 0.2m,
            _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
        };

        /// <summary>
        /// 获取氰化物的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetCnName() => FactorInfo.CnName;

        /// <summary>
        /// 获取氰化物的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetCnCode() => FactorInfo.CnCode;

        #endregion

        #region 挥发酚 VP

        /// <summary>
        /// 计算挥发酚的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeroType">true:0算Ⅰ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetVpGradeV2002(decimal value, bool zeroType = false)
        {
            if (value < 0) return null;
            if (value == 0)
            {
                if (zeroType) return new WaterGrade(1);
                else return null;
            }
            if (value <= 0.002m) return new WaterGrade(1);
            if (value <= 0.005m) return new WaterGrade(3);
            if (value <= 0.01m) return new WaterGrade(4);
            if (value <= 0.1m) return new WaterGrade(5);
            return new WaterGrade(6);
        }

        /// <summary>
        /// 获取挥发酚的标准限值
        /// </summary>
        /// <returns></returns>
        public static List<WaterStandard> GetVpStandardV2002() => new List<WaterStandard>()
        {
            new WaterStandard() { Grade = 1, Standard = 0.002m },
            new WaterStandard() { Grade = 2, Standard = 0.002m },
            new WaterStandard() { Grade = 3, Standard = 0.005m },
            new WaterStandard() { Grade = 4, Standard = 0.01m },
            new WaterStandard() { Grade = 5, Standard = 0.1m }
        };

        /// <summary>
        /// 获取挥发酚某个类别的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetVpStandardV2002(int grade) => grade switch
        {
            1 => 0.002m,
            2 => 0.002m,
            3 => 0.005m,
            4 => 0.01m,
            5 => 0.1m,
            _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
        };

        /// <summary>
        /// 获取挥发酚的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetVpName() => FactorInfo.VpName;

        /// <summary>
        /// 获取挥发酚的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetVpCode() => FactorInfo.VpCode;

        #endregion

        #region 石油类 TPH

        /// <summary>
        /// 计算石油类的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeroType">true:0算Ⅰ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetTphGradeV2002(decimal value, bool zeroType = false)
        {
            if (value < 0) return null;
            if (value == 0)
            {
                if (zeroType) return new WaterGrade(1);
                else return null;
            }
            if (value <= 0.05m) return new WaterGrade(1);
            if (value <= 0.5m) return new WaterGrade(4);
            if (value <= 1) return new WaterGrade(5);
            return new WaterGrade(6);
        }

        /// <summary>
        /// 获取石油类的标准限值
        /// </summary>
        /// <returns></returns>
        public static List<WaterStandard> GetTphStandardV2002() => new List<WaterStandard>()
        {
            new WaterStandard() { Grade = 1, Standard = 0.05m },
            new WaterStandard() { Grade = 2, Standard = 0.05m },
            new WaterStandard() { Grade = 3, Standard = 0.05m },
            new WaterStandard() { Grade = 4, Standard = 0.5m },
            new WaterStandard() { Grade = 5, Standard = 1 }
        };

        /// <summary>
        /// 获取石油类某个类别的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetTphStandardV2002(int grade) => grade switch
        {
            1 => 0.05m,
            2 => 0.05m,
            3 => 0.05m,
            4 => 0.5m,
            5 => 1,
            _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
        };

        /// <summary>
        /// 获取石油类的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetTphName() => FactorInfo.TphName;

        /// <summary>
        /// 获取石油类的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetTphCode() => FactorInfo.TphCode;
        #endregion

        #region 阴离子表面活性剂 LAS

        /// <summary>
        /// 计算阴离子表面活性剂的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeroType">true:0算Ⅰ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetLasGradeV2002(decimal value, bool zeroType = false)
        {
            if (value < 0) return null;
            if (value == 0)
            {
                if (zeroType) return new WaterGrade(1);
                else return null;
            }
            if (value <= 0.2m) return new WaterGrade(1);
            if (value <= 0.3m) return new WaterGrade(4);
            return new WaterGrade(6);
        }

        /// <summary>
        /// 获取阴离子表面活性剂的标准限值
        /// </summary>
        /// <returns></returns>
        public static List<WaterStandard> GetLasStandardV2002() => new List<WaterStandard>()
        {
            new WaterStandard() { Grade = 1, Standard = 0.2m },
            new WaterStandard() { Grade = 2, Standard = 0.2m },
            new WaterStandard() { Grade = 3, Standard = 0.2m },
            new WaterStandard() { Grade = 4, Standard = 0.3m },
            new WaterStandard() { Grade = 5, Standard = 0.3m }
        };

        /// <summary>
        /// 获取阴离子表面活性剂某个类别的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetLasStandardV2002(int grade) => grade switch
        {
            1 => 0.2m,
            2 => 0.2m,
            3 => 0.2m,
            4 => 0.3m,
            5 => 0.3m,
            _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
        };

        /// <summary>
        /// 获取阴离子表面活性剂的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetLasName() => FactorInfo.LasName;

        /// <summary>
        /// 获取阴离子表面活性剂的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetLasCode() => FactorInfo.LasCode;

        #endregion

        #region 硫化物 S2

        /// <summary>
        /// 计算硫化物的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeroType">true:0算Ⅰ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetS2GradeV2002(decimal value, bool zeroType = false)
        {
            if (value < 0) return null;
            if (value == 0)
            {
                if (zeroType) return new WaterGrade(1);
                else return null;
            }
            if (value <= 0.05m) return new WaterGrade(1);
            if (value <= 0.1m) return new WaterGrade(2);
            if (value <= 0.2m) return new WaterGrade(3);
            if (value <= 0.5m) return new WaterGrade(4);
            if (value <= 1) return new WaterGrade(5);
            return new WaterGrade(6);
        }

        /// <summary>
        /// 获取硫化物的标准限值
        /// </summary>
        /// <returns></returns>
        public static List<WaterStandard> GetS2StandardV2002() => new List<WaterStandard>()
        {
            new WaterStandard() { Grade = 1, Standard = 0.05m },
            new WaterStandard() { Grade = 2, Standard = 0.1m },
            new WaterStandard() { Grade = 3, Standard = 0.2m },
            new WaterStandard() { Grade = 4, Standard = 0.5m },
            new WaterStandard() { Grade = 5, Standard = 1 }
        };

        /// <summary>
        /// 获取硫化物某个类别的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetS2StandardV2002(int grade) => grade switch
        {
            1 => 0.05m,
            2 => 0.1m,
            3 => 0.2m,
            4 => 0.5m,
            5 => 1,
            _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
        };

        /// <summary>
        /// 获取硫化物的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetS2Name() => FactorInfo.S2Name;

        /// <summary>
        /// 获取硫化物的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetS2Code() => FactorInfo.S2Code;

        #endregion

        #region 粪大肠菌群 FC

        /// <summary>
        /// 计算粪大肠菌群的类别
        /// </summary>
        /// <param name="value"></param>
        /// <param name="zeroType">true:0算Ⅰ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static WaterGrade? GetFcGradeV2002(decimal value, bool zeroType = false)
        {
            if (value < 0) return null;
            if (value == 0)
            {
                if (zeroType) return new WaterGrade(1);
                else return null;
            }
            if (value <= 200) return new WaterGrade(1);
            if (value <= 2000) return new WaterGrade(2);
            if (value <= 10000) return new WaterGrade(3);
            if (value <= 20000) return new WaterGrade(4);
            if (value <= 40000) return new WaterGrade(5);
            return new WaterGrade(6);
        }

        /// <summary>
        /// 获取粪大肠菌群的标准限值
        /// </summary>
        /// <returns></returns>
        public static List<WaterStandard> GetFcStandardV2002() => new List<WaterStandard>()
        {
            new WaterStandard() { Grade = 1, Standard = 200 },
            new WaterStandard() { Grade = 2, Standard = 2000 },
            new WaterStandard() { Grade = 3, Standard = 10000 },
            new WaterStandard() { Grade = 4, Standard = 20000 },
            new WaterStandard() { Grade = 5, Standard = 40000 }
        };

        /// <summary>
        /// 获取粪大肠菌群某个类别的标准限值
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static decimal GetFcStandardV2002(int grade) => grade switch
        {
            1 => 200,
            2 => 2000,
            3 => 10000,
            4 => 20000,
            5 => 40000,
            _ => throw new ArgumentOutOfRangeException(nameof(grade), "类别参数无效")
        };

        /// <summary>
        /// 获取粪大肠菌群的名称
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetFcName() => FactorInfo.FcName;

        /// <summary>
        /// 获取粪大肠菌群的代码
        /// </summary>
        /// <returns></returns>
        [Obsolete("已过时,请直接使用Models.FactorInfo获取")]
        public static string GetFcCode() => FactorInfo.FcCode;

        #endregion

        //TODO：表2、表3指标的名称和编码

        #region 3838-2002 表2

        /// <summary>
        /// 硫酸盐的标准限值
        /// </summary>
        /// <returns></returns>
        public static decimal GetSo42StandardV2002() => 250;

        /// <summary>
        /// 氯化物的标准限值
        /// </summary>
        /// <returns></returns>
        public static decimal GetClStandardV2002() => 250;

        /// <summary>
        /// 硝酸盐的标准限值
        /// </summary>
        /// <returns></returns>
        public static decimal GetNo3StandardV2002() => 10;

        /// <summary>
        /// 铁的标准限值
        /// </summary>
        /// <returns></returns>
        public static decimal GetFeStandardV2002() => 0.3m;

        /// <summary>
        /// 锰的标准限值
        /// </summary>
        /// <returns></returns>
        public static decimal GetMnStandardV2002() => 0.1m;

        #endregion

        #region 3838-2002 表3 

        /// <summary>
        /// 钼的标准限值
        /// </summary>
        /// <returns></returns>
        public static decimal GetMoStandardV2002() => 0.07m;

        /// <summary>
        /// 钴的标准限值
        /// </summary>
        /// <returns></returns>
        public static decimal GetCoStandardV2002() => 1;

        /// <summary>
        /// 铍的标准限值
        /// </summary>
        /// <returns></returns>
        public static decimal GetBeStandardV2002() => 0.002m;

        /// <summary>
        /// 硼的标准限值
        /// </summary>
        /// <returns></returns>
        public static decimal GetBStandardV2002() => 0.5m;

        /// <summary>
        /// 锑的标准限值
        /// </summary>
        /// <returns></returns>
        public static decimal GetSbStandardV2002() => 0.005m;

        /// <summary>
        /// 镍的标准限值
        /// </summary>
        /// <returns></returns>
        public static decimal GetNiStandardV2002() => 0.02m;

        /// <summary>
        /// 钡的标准限值
        /// </summary>
        /// <returns></returns>
        public static decimal GetBaStandardV2002() => 0.7m;

        /// <summary>
        /// 矾的标准限值
        /// </summary>
        /// <returns></returns>
        public static decimal GetAlStandardV2002() => 0.05m;

        /// <summary>
        /// 钛的标准限值
        /// </summary>
        /// <returns></returns>
        public static decimal GetTiSTandardV2002() => 0.1m;

        /// <summary>
        /// 铊的标准限值
        /// </summary>
        /// <returns></returns>
        public static decimal GetTlStandardV2002() => 0.0001m;

        /// <summary>
        /// 三氯甲烷TRICHLOROMETHANE的标准限值
        /// </summary>
        /// <returns></returns>
        public static decimal GetTrichloromethaneStandardV2002() => 0.06m;

        /// <summary>
        /// 四氯化碳tetrachloromethane的标准限值
        /// 四氯甲烷
        /// </summary>
        /// <returns></returns>
        public static decimal GetTetrachloromethaneStandardV2002() => 0.002m;

        /// <summary>
        /// 三溴甲烷Tribromomethane的标准限值
        /// </summary>
        /// <returns></returns>
        public static decimal GetTribromomethaneStandardV2002() => 0.1m;

        /// <summary>
        /// 二氯甲烷DCM的标准限值
        /// </summary>
        /// <returns></returns>
        public static decimal GetDCMStandardV2002() => 0.02m;

        #endregion

        /// <summary>
        /// 计算整体水质类别
        /// </summary>
        /// <param name="ph">pH</param>
        /// <param name="doValue">溶解氧</param>
        /// <param name="codmn">高锰酸盐指数</param>
        /// <param name="cod">化学需氧量</param>
        /// <param name="bod5">五日生化需氧量</param>
        /// <param name="nh3n">氨氮</param>
        /// <param name="tp">总磷</param>
        /// <param name="cu">铜</param>
        /// <param name="zn">锌</param>
        /// <param name="f">氟化物</param>
        /// <param name="se">硒</param>
        /// <param name="asValue">砷</param>
        /// <param name="hg">汞</param>
        /// <param name="cd">镉</param>
        /// <param name="cr6">六价铬</param>
        /// <param name="pb">铅</param>
        /// <param name="cn">氰化物</param>
        /// <param name="vp">挥发酚</param>
        /// <param name="tph">石油类</param>
        /// <param name="las">阴离子表面活性剂</param>
        /// <param name="s2">硫化物</param>
        /// <param name="tn">总氮</param>
        /// <param name="fc">粪大肠菌群</param>
        /// <param name="waterType">河流/湖库</param>
        /// <param name="isAnalysisTN">总氮是否参与计算,默认false不参与</param>
        /// <param name="isAnalysisFC">粪大肠菌群是否参与计算,默认false不参与</param>
        /// <param name="zeroType">true:0算Ⅰ类; false:0算无数据返回null</param>
        /// <returns></returns>
        public static OverallWaterGrade GetOverallWaterGradeV2002(decimal ph,
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
                                                      decimal? tn = null,
                                                      decimal? fc = null,
                                                      string waterType = "河流",
                                                      bool isAnalysisTN = false,
                                                      bool isAnalysisFC = false,
                                                      bool zeroType = false)

        {
            var phGrade = GetPhGradeV2002(ph, zeroType);
            var doGrade = GetDoGradeV2002(doValue, zeroType);
            var codmnGrade = GetCodmnGradeV2002(codmn, zeroType);
            var codGrade = GetCodGradeV2002(cod, zeroType);
            var bod5Grade = GetBod5GradeV2002(bod5, zeroType);
            var nh3nGrade = GetNh3nGradeV2002(nh3n, zeroType);
            var tpGrade = GetTpGradeV2002(tp, waterType, zeroType);
            var cuGrade = GetCuGradeV2002(cu, zeroType);
            var znGrade = GetZnGradeV2002(zn, zeroType);
            var fGrade = GetFGradeV2002(f, zeroType);
            var seGrade = GetSeGradeV2002(se, zeroType);
            var asGrade = GetAsGradeV2002(asValue, zeroType);
            var hgGrade = GetHgGradeV2002(hg, zeroType);
            var cdGrade = GetCdGradeV2002(cd, zeroType);
            var cr6Grade = GetCr6GradeV2002(cr6, zeroType);
            var pbGrade = GetPbGradeV2002(pb, zeroType);
            var cnGrade = GetCnGradeV2002(cn, zeroType);
            var vpGrade = GetVpGradeV2002(vp, zeroType);
            var tphGrade = GetTphGradeV2002(tph, zeroType);
            var lasGrade = GetLasGradeV2002(las, zeroType);
            var s2Grade = GetS2GradeV2002(s2, zeroType);
            var tnGrade = tn != null ? GetTnGradeV2002((decimal)tn, zeroType) : null;
            var fcGrade = fc != null ? GetFcGradeV2002((decimal)fc, zeroType) : null;

            List<int?> grades = new List<int?>
            {
                phGrade?.Grade,
                doGrade?.Grade,
                codmnGrade?.Grade,
                codGrade?.Grade,
                bod5Grade?.Grade,
                nh3nGrade?.Grade,
                tpGrade?.Grade,
                cuGrade?.Grade,
                znGrade?.Grade,
                fGrade?.Grade,
                seGrade?.Grade,
                asGrade?.Grade,
                hgGrade?.Grade,
                cdGrade?.Grade,
                cr6Grade?.Grade,
                pbGrade?.Grade,
                cnGrade?.Grade,
                vpGrade?.Grade,
                tphGrade?.Grade,
                lasGrade?.Grade,
                s2Grade?.Grade
            };
            if (isAnalysisTN) grades.Add(tnGrade?.Grade);
            if (isAnalysisFC) grades.Add(fcGrade?.Grade);
            //取最大值
            var maxGrade = grades.Where(x => x != null)?.Max();
            var result = new OverallWaterGrade()
            {
                PH = phGrade,
                DO = doGrade,
                CODMN = codmnGrade,
                COD = codGrade,
                BOD5 = bod5Grade,
                NH3N = nh3nGrade,
                TP = tpGrade,
                CU = cuGrade,
                ZN = znGrade,
                F = fGrade,
                SE = seGrade,
                AS = asGrade,
                HG = hgGrade,
                CD = cdGrade,
                CR6 = cr6Grade,
                PB = pbGrade,
                CN = cnGrade,
                VP = vpGrade,
                TPH = tphGrade,
                LAS = lasGrade,
                S2 = s2Grade,
                TN = tnGrade,
                FC = fcGrade,
                WaterGrade = maxGrade == null ? null : new WaterGrade((int)maxGrade)
            };
            return result;
        }


        /// <summary>
        /// 计算指标的类别
        /// </summary>
        /// <param name="factorCode">指标编码</param>
        /// <param name="value">浓度值</param>
        /// <param name="waterType">河流/湖库</param>
        /// <returns>小于等于0时返回null</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException">不匹配的指标编码</exception>
        public static WaterGrade? GetFactorGradeV2002(string factorCode, decimal value, string waterType = "河流")
        {
            if (string.IsNullOrWhiteSpace(factorCode)) throw new ArgumentNullException(nameof(factorCode));
            if (factorCode == FactorInfo.PhCode) return GetPhGradeV2002(value);
            if (factorCode == FactorInfo.DoCode) return GetDoGradeV2002(value);
            if (factorCode == FactorInfo.CodmnCode) return GetCodmnGradeV2002(value);
            if (factorCode == FactorInfo.CodCode) return GetCodGradeV2002(value);
            if (factorCode == FactorInfo.Bod5Code) return GetBod5GradeV2002(value);
            if (factorCode == FactorInfo.Nh3nCode) return GetNh3nGradeV2002(value);
            if (factorCode == FactorInfo.TpCode) return GetTpGradeV2002(value, waterType);
            if (factorCode == FactorInfo.TnCode) return GetTnGradeV2002(value);
            if (factorCode == FactorInfo.CuCode) return GetCuGradeV2002(value);
            if (factorCode == FactorInfo.ZnCode) return GetZnGradeV2002(value);
            if (factorCode == FactorInfo.FCode) return GetFGradeV2002(value);
            if (factorCode == FactorInfo.SeCode) return GetSeGradeV2002(value);
            if (factorCode == FactorInfo.AsCode) return GetAsGradeV2002(value);
            if (factorCode == FactorInfo.HgCode) return GetHgGradeV2002(value);
            if (factorCode == FactorInfo.CdCode) return GetCdGradeV2002(value);
            if (factorCode == FactorInfo.Cr6Code) return GetCr6GradeV2002(value);
            if (factorCode == FactorInfo.PbCode) return GetPbGradeV2002(value);
            if (factorCode == FactorInfo.CnCode) return GetCnGradeV2002(value);
            if (factorCode == FactorInfo.VpCode) return GetVpGradeV2002(value);
            if (factorCode == FactorInfo.TphCode) return GetTphGradeV2002(value);
            if (factorCode == FactorInfo.LasCode) return GetLasGradeV2002(value);
            if (factorCode == FactorInfo.S2Code) return GetS2GradeV2002(value);
            if (factorCode == FactorInfo.FcCode) return GetFcGradeV2002(value);
            throw new ArgumentException("非GB 3838 表1指标");
            //return factorCode.ToLower() switch
            //{
            //    "w01001" => GetPhGradeV2002(value),
            //    "w01009" => GetDoGradeV2002(value),
            //    "w01019" => GetCodmnGradeV2002(value),
            //    "w01018" => GetCodGradeV2002(value),
            //    "w01017" => GetBod5GradeV2002(value),
            //    "w21003" => GetNh3nGradeV2002(value),
            //    "w21011" => GetTpGradeV2002(value, waterType),
            //    "w21001" => GetTnGradeV2002(value),
            //    "w20122" => GetCuGradeV2002(value),
            //    "w20123" => GetZnGradeV2002(value),
            //    "w21017" => GetFGradeV2002(value),
            //    "w20128" => GetSeGradeV2002(value),
            //    "w20141" => GetAsGradeV2002(value),
            //    "w20111" => GetHgGradeV2002(value),
            //    "w20115" => GetCdGradeV2002(value),
            //    "w20117" => GetCr6GradeV2002(value),
            //    "w20120" => GetPbGradeV2002(value),
            //    "w21016" => GetCnGradeV2002(value),
            //    "w23002" => GetVpGradeV2002(value),
            //    "w22001" => GetTphGradeV2002(value),
            //    "w19002" => GetLasGradeV2002(value),
            //    "w21019" => GetS2GradeV2002(value),
            //    "w02003" => GetFcGradeV2002(value),
            //    _ => throw new ArgumentException("未知的指标编码")
            //};
        }


        /// <summary>
        /// 获取指标的标准限值（忽略大小写）
        /// 无pH
        /// </summary>
        /// <param name="factorCode"></param>
        /// <param name="waterType"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">不匹配的指标编码</exception>
        /// <exception cref="ArgumentNullException"></exception>
        public static List<WaterStandard> GetFactorStandardV2002(string factorCode, string waterType = "河流")
        {
            if (string.IsNullOrWhiteSpace(factorCode)) throw new ArgumentNullException(nameof(factorCode));
            if (factorCode == FactorInfo.PhCode) throw new ArgumentException("pH不在此功能");
            if (factorCode == FactorInfo.DoCode) return GetDoStandardV2002();
            if (factorCode == FactorInfo.CodmnCode) return GetCodmnStandardV2002();
            if (factorCode == FactorInfo.CodCode) return GetCodStandardV2002();
            if (factorCode == FactorInfo.Bod5Code) return GetBod5StandardV2002();
            if (factorCode == FactorInfo.Nh3nCode) return GetNh3nStandardV2002();
            if (factorCode == FactorInfo.TpCode) return GetTpStandardV2002(waterType);
            if (factorCode == FactorInfo.TnCode) return GetTnStandardV2002();
            if (factorCode == FactorInfo.CuCode) return GetCuStandardV2002();
            if (factorCode == FactorInfo.ZnCode) return GetZnStandardV2002();
            if (factorCode == FactorInfo.FCode) return GetFStandardV2002();
            if (factorCode == FactorInfo.SeCode) return GetSeStandardV2002();
            if (factorCode == FactorInfo.AsCode) return GetAsStandardV2002();
            if (factorCode == FactorInfo.HgCode) return GetHgStandardV2002();
            if (factorCode == FactorInfo.CdCode) return GetCdStandardV2002();
            if (factorCode == FactorInfo.Cr6Code) return GetCr6StandardV2002();
            if (factorCode == FactorInfo.PbCode) return GetPbStandardV2002();
            if (factorCode == FactorInfo.CnCode) return GetCnStandardV2002();
            if (factorCode == FactorInfo.VpCode) return GetVpStandardV2002();
            if (factorCode == FactorInfo.TphCode) return GetTphStandardV2002();
            if (factorCode == FactorInfo.LasCode) return GetLasStandardV2002();
            if (factorCode == FactorInfo.S2Code) return GetS2StandardV2002();
            if (factorCode == FactorInfo.FcCode) return GetFcStandardV2002();
            throw new ArgumentException("非GB 3838 表1指标");

            //return factorCode.ToLower() switch
            //{
            //    "w01009" => GetDoStandardV2002(),
            //    "w01019" => GetCodmnStandardV2002(),
            //    "w01018" => GetCodStandardV2002(),
            //    "w01017" => GetBod5StandardV2002(),
            //    "w21003" => GetNh3nStandardV2002(),
            //    "w21011" => GetTpStandardV2002(waterType),
            //    "w21001" => GetTnStandardV2002(),
            //    "w20122" => GetCuStandardV2002(),
            //    "w20123" => GetZnStandardV2002(),
            //    "w21017" => GetFStandardV2002(),
            //    "w20128" => GetSeStandardV2002(),
            //    "w20141" => GetAsStandardV2002(),
            //    "w20111" => GetHgStandardV2002(),
            //    "w20115" => GetCdStandardV2002(),
            //    "w20117" => GetCr6StandardV2002(),
            //    "w20120" => GetPbStandardV2002(),
            //    "w21016" => GetCnStandardV2002(),
            //    "w23002" => GetVpStandardV2002(),
            //    "w22001" => GetTphStandardV2002(),
            //    "w19002" => GetLasStandardV2002(),
            //    "w21019" => GetS2StandardV2002(),
            //    "w02003" => GetFcStandardV2002(),
            //    _ => throw new ArgumentException("未知的指标编码")
            //};
        }



        /// <summary>
        /// 获取指标某个类别的标准限值（忽略大小写）
        /// 无pH
        /// </summary>
        /// <param name="factorCode"></param>
        /// <param name="grade"></param>
        /// <param name="waterType"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public static decimal GetFactorStandardV2002(string factorCode, int grade, string waterType = "河流")
        {
            if (string.IsNullOrWhiteSpace(factorCode)) throw new ArgumentNullException(nameof(factorCode));
            factorCode = factorCode.ToLower();
            if (factorCode == FactorInfo.PhCode) throw new ArgumentException("pH不在此功能");
            if (factorCode == FactorInfo.DoCode) return GetDoStandardV2002(grade);
            if (factorCode == FactorInfo.CodmnCode) return GetCodmnStandardV2002(grade);
            if (factorCode == FactorInfo.CodCode) return GetCodStandardV2002(grade);
            if (factorCode == FactorInfo.Bod5Code) return GetBod5StandardV2002(grade);
            if (factorCode == FactorInfo.Nh3nCode) return GetNh3nStandardV2002(grade);
            if (factorCode == FactorInfo.TpCode) return GetTpStandardV2002(grade, waterType);
            if (factorCode == FactorInfo.TnCode) return GetTnStandardV2002(grade);
            if (factorCode == FactorInfo.CuCode) return GetCuStandardV2002(grade);
            if (factorCode == FactorInfo.ZnCode) return GetZnStandardV2002(grade);
            if (factorCode == FactorInfo.FCode) return GetFStandardV2002(grade);
            if (factorCode == FactorInfo.SeCode) return GetSeStandardV2002(grade);
            if (factorCode == FactorInfo.AsCode) return GetAsStandardV2002(grade);
            if (factorCode == FactorInfo.HgCode) return GetHgStandardV2002(grade);
            if (factorCode == FactorInfo.CdCode) return GetCdStandardV2002(grade);
            if (factorCode == FactorInfo.Cr6Code) return GetCr6StandardV2002(grade);
            if (factorCode == FactorInfo.PbCode) return GetPbStandardV2002(grade);
            if (factorCode == FactorInfo.CnCode) return GetCnStandardV2002(grade);
            if (factorCode == FactorInfo.VpCode) return GetVpStandardV2002(grade);
            if (factorCode == FactorInfo.TphCode) return GetTphStandardV2002(grade);
            if (factorCode == FactorInfo.LasCode) return GetLasStandardV2002(grade);
            if (factorCode == FactorInfo.S2Code) return GetS2StandardV2002(grade);
            if (factorCode == FactorInfo.FcCode) return GetFcStandardV2002(grade);
            throw new ArgumentException("非GB 3838 表1指标");
            //return factorCode.ToLower() switch
            //{
            //    "w01009" => GetDoStandardV2002(grade),
            //    "w01019" => GetCodmnStandardV2002(grade),
            //    "w01018" => GetCodStandardV2002(grade),
            //    "w01017" => GetBod5StandardV2002(grade),
            //    "w21003" => GetNh3nStandardV2002(grade),
            //    "w21011" => GetTpStandardV2002(grade, waterType),
            //    "w21001" => GetTnStandardV2002(grade),
            //    "w20122" => GetCuStandardV2002(grade),
            //    "w20123" => GetZnStandardV2002(grade),
            //    "w21017" => GetFStandardV2002(grade),
            //    "w20128" => GetSeStandardV2002(grade),
            //    "w20141" => GetAsStandardV2002(grade),
            //    "w20111" => GetHgStandardV2002(grade),
            //    "w20115" => GetCdStandardV2002(grade),
            //    "w20117" => GetCr6StandardV2002(grade),
            //    "w20120" => GetPbStandardV2002(grade),
            //    "w21016" => GetCnStandardV2002(grade),
            //    "w23002" => GetVpStandardV2002(grade),
            //    "w22001" => GetTphStandardV2002(grade),
            //    "w19002" => GetLasStandardV2002(grade),
            //    "w21019" => GetS2StandardV2002(grade),
            //    "w02003" => GetFcStandardV2002(grade),
            //    _ => throw new ArgumentException("未知的指标编码")
            //};
        }

        /// <summary>
        /// 获取指标的名称（忽略大小写）
        /// </summary>
        /// <param name="factorCode"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public static string GetFactorName(string factorCode)
        {
            if (string.IsNullOrWhiteSpace(factorCode)) throw new ArgumentNullException(nameof(factorCode));
            factorCode = factorCode.ToLower();
            if (factorCode == FactorInfo.PhclCode) return FactorInfo.PhName;
            if (factorCode == FactorInfo.DoCode) return FactorInfo.DoName;
            if (factorCode == FactorInfo.CodmnCode) return FactorInfo.CodmnName;
            if (factorCode == FactorInfo.CodCode) return FactorInfo.CodName;
            if (factorCode == FactorInfo.Bod5Code) return FactorInfo.Bod5Name;
            if (factorCode == FactorInfo.Nh3nCode) return FactorInfo.Nh3nName;
            if (factorCode == FactorInfo.TpCode) return FactorInfo.TpName;
            if (factorCode == FactorInfo.TnCode) return FactorInfo.TnName;
            if (factorCode == FactorInfo.CuCode) return FactorInfo.CuName;
            if (factorCode == FactorInfo.ZnCode) return FactorInfo.ZnName;
            if (factorCode == FactorInfo.FCode) return FactorInfo.FName;
            if (factorCode == FactorInfo.SeCode) return FactorInfo.SeName;
            if (factorCode == FactorInfo.AsCode) return FactorInfo.AsName;
            if (factorCode == FactorInfo.HgCode) return FactorInfo.HgName;
            if (factorCode == FactorInfo.CdCode) return FactorInfo.CdName;
            if (factorCode == FactorInfo.Cr6Code) return FactorInfo.Cr6Name;
            if (factorCode == FactorInfo.PbCode) return FactorInfo.PhName;
            if (factorCode == FactorInfo.CnCode) return FactorInfo.CnName;
            if (factorCode == FactorInfo.VpCode) return FactorInfo.VpName;
            if (factorCode == FactorInfo.TphCode) return FactorInfo.TphName;
            if (factorCode == FactorInfo.LasCode) return FactorInfo.LasName;
            if (factorCode == FactorInfo.S2Code) return FactorInfo.S2Name;
            if (factorCode == FactorInfo.FcCode) return FactorInfo.FcName;
            //TODO: 表2、表3指标的名称
            throw new ArgumentException("非GB 3838 指标");
            //return factorCode.ToLower() switch
            //{
            //    "w01001" => GetPhName(),
            //    "w01009" => GetDoName(),
            //    "w01019" => GetCodmnName(),
            //    "w01018" => GetCodName(),
            //    "w01017" => GetBod5Name(),
            //    "w21003" => GetNh3nName(),
            //    "w21011" => GetTpName(),
            //    "w21001" => GetTnName(),
            //    "w20122" => GetCuName(),
            //    "w20123" => GetZnName(),
            //    "w21017" => GetFName(),
            //    "w20128" => GetSeName(),
            //    "w20141" => GetAsName(),
            //    "w20111" => GetHgName(),
            //    "w20115" => GetCdName(),
            //    "w20117" => GetCr6Name(),
            //    "w20120" => GetPbName(),
            //    "w21016" => GetCnName(),
            //    "w23002" => GetVpName(),
            //    "w22001" => GetTphName(),
            //    "w19002" => GetLasName(),
            //    "w21019" => GetS2Name(),
            //    "w02003" => GetFcName(),
            //    _ => throw new ArgumentException("未知的指标编码")
            //};
        }
    }
}