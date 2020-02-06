
namespace ChainOfResponsibilityPattern.Model.Procedure
{
    /// <summary>
    /// 請假手續基底
    /// </summary>
    public class BasicProcedure : IProcedure
    {
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="absenseForm"></param>
        public BasicProcedure(AbsenseForm absenseForm)
        {
            this.absenseForm = absenseForm;
            this.next = true;
        }

        /// <summary>
        /// 執行/檢查
        /// </summary>
        /// <returns></returns>
        internal override bool Execute(ref AbsenseForm absenseForm)
            => true;
    }
}
