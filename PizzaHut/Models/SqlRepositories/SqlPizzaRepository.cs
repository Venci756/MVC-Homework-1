using PizzaHut.Models.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaHut.Models.SqlRepositories
{
    public class SqlPizzaRepository : IPizzaRepository
    {
        private readonly AppDbContext _db;
        public SqlPizzaRepository(AppDbContext context)
        {
            _db = context;
        }
        public Pizza Add(Pizza pizza)
        {
            _db.Pizzas.Add(pizza);
            _db.SaveChanges();
            return pizza;
        }

        public Pizza Delete(int id)
        {
            Pizza pizza = _db.Pizzas.Find(id);
            _db.Pizzas.Remove(pizza);
            _db.SaveChanges();
            return pizza;
        }

        public Pizza Get(int id)
        {
            return _db.Pizzas.Find(id);
        }

        public IEnumerable<Pizza> GetAll()
        {
            return _db.Pizzas;
        }

        public Pizza Update(Pizza pizzaChanges)
        {

            var pizza = _db.Pizzas.Attach(pizzaChanges);
            pizza.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
            return pizzaChanges;
            //Pizza pizza = _db.FirstOrDefault(p => p.ID == pizzaChanges.ID);
            //if (pizza != null)
            //{
            //    pizza.Name = pizzaChanges.Name;
            //    pizza.PizzaType = pizzaChanges.PizzaType;
            //    pizza.Price = pizzaChanges.Price;
            //    pizza.Size = pizzaChanges.Size;
            //}
            //return pizza;
        }
    }
}
