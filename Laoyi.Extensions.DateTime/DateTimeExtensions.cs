
namespace Laoyi.Extensions.DateTime;
public static class DateTimeExtensions
{
    /// <summary>
    /// 转换时间戳13位长
    /// </summary>
    /// <param name="date">日期</param>
    /// <returns></returns>
    public static long ToTimeStamp(this System.DateTime date, System.DateTimeKind kind = System.DateTimeKind.Local)
    {
        var originDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, kind);
        return (long)(date - originDate).TotalSeconds;
    }
}
