
namespace ChainOfResponsibilityPattern.Model
{
    using System;
    using System.ComponentModel;

    /// <summary>
    /// 請假單
    /// </summary>
    public class AbsenseForm
    {
        public static AbsenseForm GenerateInstance(string name, int days)
        {
            return new AbsenseForm()
            {
                Name = name,
                Days = days,
                Signer = SignerType.None,
                Result = ResultType.Fail,
                CreateTime = DateTime.Now
            };
        }

        /// <summary>
        /// 請假人姓名
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 請假天數
        /// </summary>
        public int Days { get; private set; }

        /// <summary>
        /// 核准人
        /// </summary>
        public SignerType Signer { get; set; }

        /// <summary>
        /// 請假結果
        /// </summary>
        public ResultType Result { get; set; }

        /// <summary>
        /// 請假單創建時間
        /// </summary>
        public DateTime CreateTime { get; private set; }
    }

    public enum SignerType
    {
        [Description("不存在")]
        None,
        [Description("組長")]
        TeamLeader,
        [Description("經理")]
        Manager,
        [Description("老闆")]
        Boss
    }

    public enum ResultType
    {
        Fail,
        Success
    }
}
