
namespace ObserverPattern.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// 被觀察者介面
    /// </summary>
    public abstract class IObserverable
    {
        /// <summary>
        /// 被觀察者名稱
        /// </summary>
        public string ObserverableName { get; set; }

        /// <summary>
        /// 加入觀察者
        /// </summary>
        /// <param name="observer"></param>
        public abstract void Add(IObserver observer);

        /// <summary>
        /// 移除觀察者
        /// </summary>
        /// <param name="observer"></param>
        public abstract void Del(IObserver observer);

        /// <summary>
        /// 通知
        /// </summary>
        /// <returns></returns>
        public abstract IEnumerable<string> Notify();
    }
}
