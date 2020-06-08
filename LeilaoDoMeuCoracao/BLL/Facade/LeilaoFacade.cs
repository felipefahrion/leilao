using LeilaoDoMeuCoracao.BLL.Dao;
using LeilaoDoMeuCoracao.PL;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<Lance> DeterminarLanceGanhador(int LeilaoId)
        {
            ICollection<Lance> lances = await new LanceFacade().FindAllById(LeilaoId);

            Leilao leilao = await leilaoDAO.DetailsById(LeilaoId);
            Lance lanceGanhador;

            if (leilao.TipoLeilaoEnum == PL.Enum.TipoLeilaoEnum.DEMANDA)
            {
                lanceGanhador = lances.OrderBy(x => x.Valor).Where(x => (x.DataHoraLance <= leilao.DataMaxLances) && x.Valor < leilao.Valor).FirstOrDefault();
            }
            else
            {
                lanceGanhador = lances.OrderByDescending(x => x.Valor).Where(x => (x.DataHoraLance <= leilao.DataMaxLances) && x.Valor > leilao.Valor).FirstOrDefault();
            }

            if (lanceGanhador == null)
            {
                return null;
            }

            return lanceGanhador;
        }
    }
}
