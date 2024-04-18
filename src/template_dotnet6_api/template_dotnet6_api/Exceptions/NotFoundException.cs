namespace template_dotnet6_api.Exceptions
{
    public class NotFoundException : AppExceptionBase
    {
        public NotFoundException(string objectTypeName)
        {
           ObjectTypeName = objectTypeName;
        }

        public override string Message => $"Object [{ObjectTypeName}] is not found.";
    }
}
