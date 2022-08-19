using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace CoreProject.CommonMethod
{
    public static class SystemCommonMethod
    {
        public static string GetGuid()
        {
            var guid = Guid.NewGuid().ToString("N");
            return guid;
        }

        /// <summary>
        /// MD5_32味加密
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string MD5Encryption(string source)
        {
            string md5Str = string.Empty;
            MD5 md5 =MD5.Create();
            byte[] byData = Encoding.Default.GetBytes(source);
            byte[] result = md5.ComputeHash(byData);

            md5Str = BitConverter.ToString(result);
            md5Str = md5Str.Replace("-", "");

            return md5Str;
        }
    }
}
