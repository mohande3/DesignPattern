using DesignPattern.CustomerProject.CommonDAL;
using System.Data.SqlClient;

namespace DesignPattern.CustomerProject.AdoDAL
{
    public abstract class TemplateADO<T> : AbstractDal<T>
    {
        protected SqlConnection _sqlConnection;
        protected SqlCommand _sqlCommand;


        public TemplateADO(string connectionString) : base(connectionString)
        {

        }
        public void Execute(T entity)
        {
            Open();
            ExecuteCommand(entity);
            Close();
        }
        private void Open()
        {
            _sqlConnection = new SqlConnection(connectionString);
            _sqlConnection.Open();
            _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;
        }
        protected abstract void ExecuteCommand(T entity);
        private void Close() { _sqlConnection.Close(); }

        public override void Save()
        {
            foreach (var entity in listTypes)
            {
                Execute(entity);
            }
        }
    }
}