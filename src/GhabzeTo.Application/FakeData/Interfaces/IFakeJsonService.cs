namespace GhabzeTo.Application.Interfaces
{
    public interface IFakeDataService
    {
        object GetFakeObject(int numberOfObjects, string dtoName);
    }
}
