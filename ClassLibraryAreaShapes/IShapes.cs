namespace ClassLibraryAreaShapes
{
    public interface IData
    {
        double Area();
    }

    public interface IDataProcess
    {
        double ProcessData(IData data);

    }
    public class DataProcess : IDataProcess
    {
        public double ProcessData(IData data) => data.Area();
    }
}
