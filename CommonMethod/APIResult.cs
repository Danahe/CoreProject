namespace CoreProject.CommonMethod
{
    public class APIResult<T> : ResultMsg
    {
        /// <summary>
        /// 返回数据使用
        /// </summary>
        /// <param name="data"></param>
        public APIResult(T data)
        {
            Code = 200;
            Data = data;
            this.Message = "success";
        }
        /// <summary>
        /// 默认返回
        /// </summary>
        public APIResult()
        {
            Code = 200;
            this.Message = "success";
        }
        /// <summary>
        /// 自定义返回信息
        /// </summary>
        /// <param name="code"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public APIResult<T> Msg(bool code, string msg = null)
        {
            if (code)
            {
                return Success(msg ?? "操作成功");
            }
            else
            {
                return Error(msg ?? "操作失败");
            }
        }
        /// <summary>
        /// 错误信息
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public APIResult<T> Error(string msg)
        {
            return new APIResult<T>
            {
                Code = 500,
                Message = msg
            };
        }
        /// <summary>
        /// 成功信息
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public APIResult<T> Success(string msg)
        {
            return new APIResult<T>
            {
                Code = 200,
                Message = msg
            };
        }
    }

    public class APIPageResult<T> : Result<T>
    {
        public APIPageResult()
        {

        }
        /// <summary>
        /// 快速分页
        /// </summary>
        /// <param name="data"></param>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        public APIPageResult(List<T> data, int page, int rows)
        {
            Code = 200;
            PageIndex = page;
            PageSize = rows;
            TotalCount = data.Count;
            Data = data.Skip((PageIndex - 1) * PageSize).Take(PageSize).ToList();
        }

        private readonly int MaxPageSize = 50;

        private int _pageIndex = 1;
        public int PageIndex
        {
            get => _pageIndex;
            set => _pageIndex = (value <= 0) ? 1 : value;
        }

        private int _pageSize = 15;
        public int PageSize
        {
            get => _pageSize;
            set
            {
                if (value > MaxPageSize)
                    _pageSize = MaxPageSize;
                else if (value <= 0)
                    _pageSize = 15;
                else
                    _pageSize = value;
            }
        }
    }
}
