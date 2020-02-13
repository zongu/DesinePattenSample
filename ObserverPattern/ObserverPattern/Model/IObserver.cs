
namespace ObserverPattern.Model
{
    /// <summary>
    /// 觀察者Interface
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// 廣播
        /// </summary>
        /// <returns></returns>
        string BoradCast();
    }
}
