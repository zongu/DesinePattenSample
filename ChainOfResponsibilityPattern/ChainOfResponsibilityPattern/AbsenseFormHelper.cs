
namespace ChainOfResponsibilityPattern
{
    using ChainOfResponsibilityPattern.Model;
    using ChainOfResponsibilityPattern.Model.Procedure;

    /// <summary>
    /// 請假小幫手
    /// </summary>
    public static class AbsenseFormHelper
    {
        /// <summary>
        /// 一般撰寫方法
        /// </summary>
        /// <param name="name"></param>
        /// <param name="days"></param>
        /// <returns></returns>
        public static AbsenseForm ByNormalCase(string name, int days)
        {
            var result = AbsenseForm.GenerateInstance(name, days);

            if(result.Days <= 3)
            {
                result.Signer = SignerType.TeamLeader;
                result.Result = ResultType.Success;
            }
            else if(result.Days > 3 && result.Days <= 7)
            {
                result.Signer = SignerType.Manager;
                result.Result = ResultType.Success;
            }
            else if(result.Days > 7)
            {
                result.Signer = SignerType.Boss;
                result.Result = ResultType.Success;
            }

            return result;
        }

        /// <summary>
        /// 使用責任練模式寫法
        /// </summary>
        /// <param name="name"></param>
        /// <param name="days"></param>
        /// <returns></returns>
        public static AbsenseForm ByDesignPattenCase(string name, int days)
        {
            var procedure = new BasicProcedure(AbsenseForm.GenerateInstance(name, days));
            procedure.SetProcedure(new TeamLeaderProcedure());
            procedure.SetProcedure(new ManagerProcedure());
            procedure.SetProcedure(new BossProcedure());

            return procedure.GetAbsenseForm();
        }
    }
}
