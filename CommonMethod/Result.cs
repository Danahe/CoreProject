namespace CoreProject.CommonMethod
{
    public class Result<T>
    {
        public int Code { get; set; }

        public long TotalCount { get; set; }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public IEnumerable<T> Data { get; set; }


        public static Result<T> Page(int pageIndex, int pageSize, IQueryable<T> queryable)
        {
            if (pageIndex <= 0)
                pageIndex = 1;
            if (pageSize > 100)
                pageSize = 100;
            if (pageSize <= 0)
                pageSize = 5;
            return new Result<T>()
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                Code = 200,
                TotalCount = queryable.LongCount<T>(),
                Data = (IEnumerable<T>)queryable.Skip<T>((pageIndex - 1) * pageSize).Take<T>(pageSize).ToList<T>()
            };
        }
    }
}
