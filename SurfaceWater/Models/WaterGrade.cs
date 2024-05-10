using System;

namespace SurfaceWater.Models
{

    /// <summary>
    /// 水质类别1-6
    /// </summary>
    public class WaterGrade
    {
        /// <summary>
        /// 类别数字
        /// </summary>
        public int Grade { get; set; }
        /// <summary>
        /// 类别文本
        /// </summary>
        public string GradeText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="grade"></param>
        /// <exception cref="ArgumentException"></exception>
        public WaterGrade(int grade)
        {
            if (grade < 0 || grade > 6) throw new ArgumentException("grade out of range");
            Grade = grade;
            GradeText = grade switch
            {
                1 => "Ⅰ",
                2 => "Ⅱ",
                3 => "Ⅲ",
                4 => "Ⅳ",
                5 => "Ⅴ",
                6 => "劣Ⅴ",
                _ => ""
            };
        }
    }
}