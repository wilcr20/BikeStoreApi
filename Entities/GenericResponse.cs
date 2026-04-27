namespace BikeStoreApi.Entities
{
    public class GenericResponse<T>
    {
        public string Message { get; set; } = String.Empty;
        public List<T> ? DataList { get; set; }

        public T? DataObject { get; set; }
    }
}
