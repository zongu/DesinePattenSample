
namespace ChainOfResponsibilityPattern.Model.Procedure
{
    /// <summary>
    /// 經理審核
    /// </summary>
    public class ManagerProcedure : IProcedure
    {
        /// <summary>
        /// 我是經理
        /// </summary>
        const SignerType Signer = SignerType.Manager;

        /// <summary>
        /// 執行/檢查
        /// </summary>
        /// <returns></returns>
        internal override bool Execute(ref AbsenseForm absenseForm)
        {
            if (absenseForm.Days > 3 && absenseForm.Days <= 7)
            {
                absenseForm.Signer = Signer;
                absenseForm.Result = ResultType.Success;

                return false;
            }

            return true;
        }
    }
}
