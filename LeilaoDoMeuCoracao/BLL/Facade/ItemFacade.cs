using LeilaoDoMeuCoracao.BLL.Dao;
using LeilaoDoMeuCoracao.PL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeilaoDoMeuCoracao.BLL.Facade
{
    public class ItemFacade
    {
        private ItemDAO ItemDAO;

        public ItemFacade()
        {
            ItemDAO = new ItemDAO();
        }

        public async Task<List<Item>> ListAll() => await ItemDAO.ListAll();

        public async Task<Item> DetailsById(int? id) => await ItemDAO.DetailsById(id);

        public async Task Create(Item item) => await ItemDAO.Create(item);

        public async Task<Item> EditById(int? id) => await ItemDAO.EditById(id);

        public async Task<Item> EditByIdAndObject(int id, Item item) => await ItemDAO.EditByIdAndObject(id, item);

        public async Task<Item> GetToDeleteById(int? id) => await ItemDAO.GetToDeleteById(id);

        public async Task DeleteById(int? id) => await ItemDAO.DeleteById(id);

        public bool ItemExists(int id) => ItemDAO.ItemExists(id);
    }
}
