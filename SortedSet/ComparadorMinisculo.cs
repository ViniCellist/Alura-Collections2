
namespace A1._3_SortedSet
{
    internal class ComparadorMinisculo : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return string.Compare(x, y, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}