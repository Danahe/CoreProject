namespace CoreProject.CommonMethod
{
    /// <summary>
    /// 回执对象
    /// </summary>
    public class ResultMsg
    {
        public int Code { get; set; }
        public string Message { get; set; } = "";
        public object? Data { get; set; }=new object();

        public ResultMsg SetResultMsg(int code, string message, object data)
        { 
            Code = code;
            Message = message;
            Data = data;
            return this;
        }

        ResultMsg Success() => new ResultMsg()
        {
            Code = 200,
            Message = "success",
            Data = (object)null
        };

        public static ResultMsg Success(object data) => new ResultMsg()
        {
            Data = data,
            Code = 200,
            Message = "success"
        };

        public static ResultMsg Fail(string message) => new ResultMsg()
        {
            Code = 500,
            Message = message,
            Data = null
        };

        public static ResultMsg NoAuth() => new ResultMsg()
        {
            Code = 401,
            Message = "未通过认证",
            Data = null
        };
    }
}
