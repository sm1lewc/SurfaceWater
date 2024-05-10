namespace SurfaceWater.Models
{

    /// <summary>
    /// 一条数据的整体水质类别
    /// </summary>
    public class OverallWaterGrade
    {
        /// <summary>
        /// 整体水质类别
        /// </summary>
        public WaterGrade? WaterGrade { get; set; }
        /// <summary>
        /// pH的类别
        /// </summary>
        public WaterGrade? PH { get; set; }
        /// <summary>
        /// 溶解氧的类别
        /// </summary>
        public WaterGrade? DO { get; set; }
        /// <summary>
        /// 高锰酸盐指数的类别
        /// </summary>
        public WaterGrade? CODMN { get; set; }
        /// <summary>
        /// 化学需氧量的类别
        /// </summary>
        public WaterGrade? COD { get; set; }
        /// <summary>
        /// 五日生化需氧量的类别
        /// </summary>
        public WaterGrade? BOD5 { get; set; }
        /// <summary>
        /// 氨氮的类别
        /// </summary>
        public WaterGrade? NH3N { get; set; }
        /// <summary>
        /// 总磷的类别
        /// </summary>
        public WaterGrade? TP { get; set; }
        /// <summary>
        /// 总氮的类别
        /// </summary>
        public WaterGrade? TN { get; set; }
        /// <summary>
        /// 铜的类别
        /// </summary>
        public WaterGrade? CU { get; set; }
        /// <summary>
        /// 锌的类别
        /// </summary>
        public WaterGrade? ZN { get; set; }
        /// <summary>
        /// 氟化物的类别
        /// </summary>
        public WaterGrade? F { get; set; }
        /// <summary>
        /// 硒的类别
        /// </summary>
        public WaterGrade? SE { get; set; }
        /// <summary>
        /// 砷的类别
        /// </summary>
        public WaterGrade? AS { get; set; }
        /// <summary>
        /// 汞的类别
        /// </summary>
        public WaterGrade? HG { get; set; }
        /// <summary>
        /// 镉的类别
        /// </summary>
        public WaterGrade? CD { get; set; }
        /// <summary>
        /// 六价铬的类别
        /// </summary>
        public WaterGrade? CR6 { get; set; }
        /// <summary>
        /// 铅的类别
        /// </summary>
        public WaterGrade? PB { get; set; }
        /// <summary>
        /// 氰化物的类别
        /// </summary>
        public WaterGrade? CN { get; set; }
        /// <summary>
        /// 挥发酚的类别
        /// </summary>
        public WaterGrade? VP { get; set; }
        /// <summary>
        /// 石油类的类别
        /// </summary>
        public WaterGrade? TPH { get; set; }
        /// <summary>
        /// 阴离子表面活性剂的类别
        /// </summary>
        public WaterGrade? LAS { get; set; }
        /// <summary>
        /// 硫化物的类别
        /// </summary>
        public WaterGrade? S2 { get; set; }
        /// <summary>
        /// 粪大肠菌群的类别
        /// </summary>
        public WaterGrade? FC { get; set; }
    }
}