using CubeGame.DAL.Data.Models.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeGame.DAL.Repo.order
{
    public interface IOrderRepo
    {
        public void AddOrder(string token);
        public List<Order> getOrderForUser(string token);
        public List<Order> GetAllOrders(string token);
    }
}
