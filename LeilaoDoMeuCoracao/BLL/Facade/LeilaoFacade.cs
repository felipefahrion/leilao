using LeilaoDoMeuCoracao.BLL.Dao;
using LeilaoDoMeuCoracao.PL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeilaoDoMeuCoracao.BLL.Facade
{
    public class LeilaoFacade
    {
        private readonly LeilaoDAO leilaoDAO;

        public LeilaoFacade()
        {
            leilaoDAO = new LeilaoDAO();
        }

        public async Task<List<Leilao>> ListAll() => await leilaoDAO.ListAll();

        public async Task<Leilao> DetailsById(int? id) => await leilaoDAO.DetailsById(id);

        public async Task Create(Leilao leilao) => await leilaoDAO.Create(leilao);

        public async Task<Leilao> EditById(int? id) => await leilaoDAO.EditById(id);

        public async Task<Leilao> EditByIdAndObject(int id, Leilao leilao) => await leilaoDAO.EditByIdAndObject(id, leilao);

        public async Task<Leilao> GetToDeleteById(int? id) => await leilaoDAO.DetailsById(id);

        public async Task DeleteById(int? id) => await leilaoDAO.DeleteById(id);

        public bool LeilaoExists(int id) => leilaoDAO.LeilaoExists(id);
    }
}
