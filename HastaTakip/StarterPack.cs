using HastaTakip.Interfaces;
using HastaTakip.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaTakip
{
    public  class StarterPack
    {
        private readonly IDatabaseService databaseService;

        public StarterPack(IDatabaseService databaseService )
        {
            this.databaseService = databaseService;
        }
        public  void Start()
        {
            databaseService.CreateDatabase(); 
        } 
    }
}
