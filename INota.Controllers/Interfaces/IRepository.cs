namespace INota.Controllers.Interfaces
{
    using INota.Controllers.Helps;
    using System;
    using System.Threading.Tasks;

    public interface IRepository<T> where T : class
    {
        #region Metodos Genericos
        //Task<Response> GetListAsync();
        //Task<Response> GetListAsync(Guid i, T documento);
        //Task<Response> GetListAsync(string i);
        //Task<Response> DeleteAsync(int id);
        //Task<Response> DeleteAsync(T model);
        //Task<string> ExportToExcelAsync();
        //Task<Response> GetListFirstOrDefaultAsync();


        Task<Response> PostAsync(Guid i, T documento);
        #endregion
    }
}
