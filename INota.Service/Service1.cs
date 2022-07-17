using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace INota.Service
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        private IService nfeservice;

        protected override void OnStart(string[] args)
        {
            ThreadPool.QueueUserWorkItem(
                state =>
                {
                    try
                    {
                        (this.nfeservice = new NFeService()).Start();
                    }
                    catch (Exception ex)
                    {
                        //LogErro.Salvar(ex);
                    }
                });
        }

        protected override void OnStop()
        {
            try
            {
                nfeservice.Stop();
            }
            catch (Exception ex)
            {
                //LogErro.Salvar(ex);
            }

        }
    }
}
