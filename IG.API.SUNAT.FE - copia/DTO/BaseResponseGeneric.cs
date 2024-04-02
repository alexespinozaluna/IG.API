namespace IG.API.SUNAT.FE.DTO
{
    public class BaseResponseGeneric<T> : BaseResponse
    {
        public T? Data { get; set; }
    }
}
