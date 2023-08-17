namespace Web_Api_Project.Pagination
{
    public static class IQueryableExtension
    {
        public static IQueryable<T> Paginate<T>(this IQueryable<T> queryable, int page, int recordToTake)
        {
            return queryable.Skip((page - 1) * recordToTake).Take(recordToTake);
        }
    }
}
