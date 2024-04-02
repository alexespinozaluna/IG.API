namespace IG.API.SUNAT.FE.Dto
{
    public class BaseResponseGeneric<T> : BaseResponse
    {
        public T? Data { get; set; }
    }
}
