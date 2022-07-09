namespace INota.Controllers.Interfaces
{
    using INota.Controllers.Helps;
    using System;
    using System.Threading.Tasks;

    public interface IRepository<T> where T : class
    {
        #region Metodos Genericos
        //Emitir
        Task<Response> PostAsync(Guid i, T documento);

        //Listagem
        Task<Response> GetListAsync(Guid i, string documento);

        //Apagar
        Task<Response> DeleteAsync(Guid i, string documento);
        #endregion
    }
}
