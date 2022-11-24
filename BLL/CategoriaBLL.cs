using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class CategoriaBLL
    {
        ToDoListEntities toDoList = new ToDoListEntities();

        public void Add(string nombre)
        {
            Categoria categoria = new Categoria();
            categoria.Nombre = nombre;

            toDoList.Categoria.Add(categoria);
            toDoList.SaveChanges();
        }

        public List<Categoria> GetAll()
        {
            return toDoList.Categoria.ToList();
        }
    }
}
