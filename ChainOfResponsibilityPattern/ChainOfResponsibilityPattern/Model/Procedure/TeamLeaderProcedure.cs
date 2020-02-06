
namespace ChainOfResponsibilityPattern.Model.Procedure
{
    /// <summary>
    /// 組長審核
    /// </summary>
    public class TeamLeaderProcedure : IProcedure
    {
        /// <summary>
        /// 我是組長
        /// </summary>
        const SignerType Signer = SignerType.TeamLeader;

        /// <summary>
        /// 執行/檢查
        /// </summary>
        /// <returns></returns>
        internal override bool Execute(ref AbsenseForm absenseForm)
        {
            if (absenseForm.Days <= 3)
            {
                absenseForm.Signer = Signer;
                absenseForm.Result = ResultType.Success;

                return false;
            }

            return true;
        }
    }
}
