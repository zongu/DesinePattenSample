
namespace ObserverPattern.Model
{
    /// <summary>
    /// 圖奇觀眾
    /// </summary>
    public class TwitchUser : IObserver
    {
        /// <summary>
        /// 訂閱的實況主
        /// </summary>
        private IObserverable observerable;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="observerable"></param>
        public TwitchUser(IObserverable observerable)
        {
            this.observerable = observerable;
        }

        /// <summary>
        /// 實況主上線
        /// </summary>
        /// <returns></returns>
        public string BoradCast()
            => $"{this.observerable.ObserverableName} Online";
    }
}
