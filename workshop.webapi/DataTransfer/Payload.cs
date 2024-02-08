namespace workshop.webapi.DataTransfer
{
    public class Payload<T>
    {
        public string name { get; set; }
        public T data { get; set; }
    }
}
