
namespace ChainOfResponsibilityPattern.Model.Procedure
{
    /// <summary>
    /// 老闆審核
    /// </summary>
    public class BossProcedure : IProcedure
    {
        /// <summary>
        /// 我是老闆
        /// </summary>
        const SignerType Signer = SignerType.Boss;

        /// <summary>
        /// 執行/檢查
        /// </summary>
        /// <returns></returns>
        internal override bool Execute(ref AbsenseForm absenseForm)
        {
            if (absenseForm.Days > 7)
            {
                absenseForm.Signer = Signer;
                absenseForm.Result = ResultType.Success;

                return false;
            }

            return true;
        }
    }
}
