
namespace ObserverPattern.Model
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// 圖奇實況主
    /// </summary>
    public class Twitcher : IObserverable
    {
        /// <summary>
        /// 訂閱的觀眾
        /// </summary>
        private List<IObserver> observers;

        /// <summary>
        /// 建構子
        /// </summary>
        public Twitcher()
        {
            this.observers = new List<IObserver>();
        }

        /// <summary>
        /// 觀眾訂閱
        /// </summary>
        /// <param name="observer"></param>
        public override void Add(IObserver observer)
        {
            this.observers.Add(observer);
        }

        /// <summary>
        /// 觀眾退訂
        /// </summary>
        /// <param name="observer"></param>
        public override void Del(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        /// <summary>
        /// 通知觀眾
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> Notify()
            => this.observers.Select(o => o.BoradCast());
    }
}
