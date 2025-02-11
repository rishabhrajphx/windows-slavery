using System.ServiceModel;

namespace MyWcfProject.Interfaces
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        MyModel GetData(int value);

        [OperationContract]
        void SaveData(MyModel model);

        [OperationContract]
        int C2F(int c);

        [OperationContract]
        int F2C(int f);

        [OperationContract]
        string Sort(string s);
    }
}