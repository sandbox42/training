namespace Acme.Common
{
    /// <summary>
    /// Provides a result flag and message 
    /// useful as a method return type.
    /// </summary>
    public class OperationResult<T>
    {
        public OperationResult()
        {
        }

        public OperationResult(T result, string message) : this()
        {
            this.Success = result;
            this.Message = message;
        }

        public T Success { get; set; }
        public string Message { get; set; }
    }

}
