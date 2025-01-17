namespace YazilimNetFrameworkOrnekler.Ornekler.ClassicDTOPattern
{
    internal class BaseResponse
    {
        internal bool status { get; set; }
        internal int statusCode { get; set; }
        internal BaseResponseData data { get; set; }
    }

    internal class BaseResponse<T> where T : BaseResponseData
    {
        internal bool status { get; set; }
        internal int statusCode { get; set; }
        internal T data { get; set; }
    }
}
