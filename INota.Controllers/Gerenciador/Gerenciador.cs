using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INota.Controllers.Gerenciador
{
    public partial class Gerenciador : IDisposable
    {
        public static ConcurrentBag<long> FilaBag { get; set; } = new ConcurrentBag<long>();

        //public bool Autorizar(long chave)
        //{
        //    if (FilaBag.Contains(chave))
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        FilaBag.Add(chave);




        //    }
        //}

        public void Dispose()
        {
            
        }
    }
}
