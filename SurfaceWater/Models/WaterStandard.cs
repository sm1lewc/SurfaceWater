namespace SurfaceWater.Models
{
    /// <summary>
    /// 水质类别标准限值
    /// </summary>
    public class WaterStandard
    {
        /// <summary>
        /// 类别
        /// </summary>
        public int Grade { get; set; }
        /// <summary>
        /// 类别的标准限制
        /// </summary>
        public decimal Standard { get; set; }
    }
}