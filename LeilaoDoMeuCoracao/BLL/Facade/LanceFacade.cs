using LeilaoDoMeuCoracao.BLL.Dao;
using LeilaoDoMeuCoracao.PL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeilaoDoMeuCoracao.BLL.Facade
{
    public class LanceFacade
    {
        private readonly LanceDAO lanceDAO;

        public LanceFacade()
        {
            lanceDAO = new LanceDAO();
        }

        public LeilaoContext GetLeilaoContext() => lanceDAO.GetContext();
        public async Task<List<Lance>> ListAll() => await lanceDAO.ListAll();
        public async Task<Lance> DetailsById(int? id) => await lanceDAO.DetailsById(id);
        public async Task Create(Lance lance) => await lanceDAO.Create(lance);
    }
}
