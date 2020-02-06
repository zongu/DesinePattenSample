
namespace ChainOfResponsibilityPattern.Model.Procedure
{
    /// <summary>
    /// 請假手續抽象類別
    /// </summary>
    public abstract class IProcedure
    {
        /// <summary>
        /// 是否需繼續檢查/執行
        /// </summary>
        protected bool next;

        /// <summary>
        /// 假單
        /// </summary>
        protected AbsenseForm absenseForm;

        /// <summary>
        /// 設置手續
        /// </summary>
        /// <param name="procedure"></param>
        public void SetProcedure(IProcedure procedure)
        {
            if (this.next)
            {
                this.next = procedure.Execute(ref this.absenseForm);
            }
        }

        /// <summary>
        /// 取得目前請假單結果
        /// </summary>
        /// <returns></returns>
        public AbsenseForm GetAbsenseForm()
            => this.absenseForm;

        /// <summary>
        /// 執行/檢查
        /// </summary>
        /// <returns></returns>
        internal abstract bool Execute(ref AbsenseForm absenseForm);
    }
}
