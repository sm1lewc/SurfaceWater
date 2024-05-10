namespace SurfaceWater.Models
{

    /// <summary>
    /// 一条数据的整体水质指数
    /// </summary>
    public class OverallCWQI
    {
        /// <summary>
        /// 整条数据的CWQI
        /// </summary>
        public decimal? CWQI { get; set; }
        /// <summary>
        /// pH的水质指数
        /// </summary>
        public decimal? PhCwqi { get; set; }
        /// <summary>
        /// 溶解氧的水质指数
        /// </summary>
        public decimal? DoCwqi { get; set; }
        /// <summary>
        /// 高锰酸盐指数的水质指数
        /// </summary>
        public decimal? CodmnCwqi { get; set; }
        /// <summary>
        /// 化学需氧量的水质指数
        /// </summary>
        public decimal? CodCwqi { get; set; }
        /// <summary>
        /// 五日生化需氧量的水质指数
        /// </summary>
        public decimal? Bod5Cwqi { get; set; }
        /// <summary>
        /// 氨氮的水质指数
        /// </summary>
        public decimal? Nh3nCwqi { get; set; }
        /// <summary>
        /// 总磷的水质指数
        /// </summary>
        public decimal? TpCwqi { get; set; }
        /// <summary>
        /// 铜的水质指数
        /// </summary>
        public decimal? CuCwqi { get; set; }
        /// <summary>
        /// 锌的水质指数
        /// </summary>
        public decimal? ZnCwqi { get; set; }
        /// <summary>
        /// 氟化物的水质指数
        /// </summary>
        public decimal? FCwqi { get; set; }
        /// <summary>
        /// 硒的水质指数
        /// </summary>
        public decimal? SeCwqi { get; set; }
        /// <summary>
        /// 砷的水质指数
        /// </summary>
        public decimal? AsCwqi { get; set; }
        /// <summary>
        /// 汞的水质指数
        /// </summary>
        public decimal? HgCwqi { get; set; }
        /// <summary>
        /// 镉的水质指数
        /// </summary>
        public decimal? CdCwqi { get; set; }
        /// <summary>
        /// 六价铬的水质指数
        /// </summary>
        public decimal? Cr6Cwqi { get; set; }
        /// <summary>
        /// 铅的水质指数
        /// </summary>
        public decimal? PbCwqi { get; set; }
        /// <summary>
        /// 氰化物的水质指数
        /// </summary>
        public decimal? CnCwqi { get; set; }
        /// <summary>
        /// 挥发酚的水质指数
        /// </summary>
        public decimal? VpCwqi { get; set; }
        /// <summary>
        /// 石油类的水质指数
        /// </summary>
        public decimal? TphCwqi { get; set; }
        /// <summary>
        /// 阴离子表面活性剂的水质指数
        /// </summary>
        public decimal? LasCwqi { get; set; }
        /// <summary>
        /// 硫化物的水质指数
        /// </summary>
        public decimal? S2Cwqi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="phCwqi"></param>
        /// <param name="doCwqi"></param>
        /// <param name="codmnCwqi"></param>
        /// <param name="codCwqi"></param>
        /// <param name="bod5Cwqi"></param>
        /// <param name="nh3nCwqi"></param>
        /// <param name="tpCwqi"></param>
        /// <param name="cuCwqi"></param>
        /// <param name="znCwqi"></param>
        /// <param name="fCwqi"></param>
        /// <param name="seCwqi"></param>
        /// <param name="asCwqi"></param>
        /// <param name="hgCwqi"></param>
        /// <param name="cdCwqi"></param>
        /// <param name="cr6Cwqi"></param>
        /// <param name="pbCwqi"></param>
        /// <param name="cnCwqi"></param>
        /// <param name="vpCwqi"></param>
        /// <param name="tphCwqi"></param>
        /// <param name="lasCwqi"></param>
        /// <param name="s2Cwqi"></param>
        public OverallCWQI(decimal? phCwqi, decimal? doCwqi, decimal? codmnCwqi, decimal? codCwqi, decimal? bod5Cwqi, decimal? nh3nCwqi, decimal? tpCwqi, decimal? cuCwqi, decimal? znCwqi, decimal? fCwqi, decimal? seCwqi, decimal? asCwqi, decimal? hgCwqi, decimal? cdCwqi, decimal? cr6Cwqi, decimal? pbCwqi, decimal? cnCwqi, decimal? vpCwqi, decimal? tphCwqi, decimal? lasCwqi, decimal? s2Cwqi)
        {
            PhCwqi = phCwqi;
            DoCwqi = doCwqi;
            CodmnCwqi = codmnCwqi;
            CodCwqi = codCwqi;
            Bod5Cwqi = bod5Cwqi;
            Nh3nCwqi = nh3nCwqi;
            TpCwqi = tpCwqi;
            CuCwqi = cuCwqi;
            ZnCwqi = znCwqi;
            FCwqi = fCwqi;
            SeCwqi = seCwqi;
            AsCwqi = asCwqi;
            HgCwqi = hgCwqi;
            CdCwqi = cdCwqi;
            Cr6Cwqi = cr6Cwqi;
            PbCwqi = pbCwqi;
            CnCwqi = cnCwqi;
            VpCwqi = vpCwqi;
            TphCwqi = tphCwqi;
            LasCwqi = lasCwqi;
            S2Cwqi = s2Cwqi;
            CWQI = phCwqi + doCwqi + codmnCwqi + codCwqi + bod5Cwqi + nh3nCwqi + tpCwqi + cuCwqi + znCwqi + fCwqi + seCwqi + asCwqi + hgCwqi + cdCwqi + cr6Cwqi + pbCwqi + cnCwqi + vpCwqi + tphCwqi + lasCwqi + s2Cwqi;
        }
    }
}