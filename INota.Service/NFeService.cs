using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INota.Service
{

    [Export(typeof(IService))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class NFeService : IService
    {
        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
