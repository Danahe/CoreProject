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

    public class Result
    {
        public int Code { get; set; }
        public string Message { get; set; } = "";
        public object? Data { get; set; } = new object();

        public Result SetResult(int code, string message, object data)
        {
            Code = code;
            Message = message;
            Data = data;
            return this;
        }

        Result Success() => new Result()
        {
            Code = 200,
            Message = "success",
            Data = (object)null
        };

        public static Result Success(object data) => new Result()
        {
            Data = data,
            Code = 200,
            Message = "success"
        };

        public static Result Fail(string message) => new Result()
        {
            Code = 500,
            Message = message,
            Data = null
        };

        public static Result NoAuth() => new Result()
        {
            Code = 401,
            Message = "未通过认证",
            Data = null
        };
    }
}
