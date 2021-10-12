using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClotingStore.BL
{
   public  class CategoriasBL
    {
        Contexto _contexto;
        public List<Categorias> ListadeCategorias { get; set; }
    
        public CategoriasBL()
        {
            _contexto = new Contexto();
            ListadeCategorias = new List<Categorias>();
        }
        public List<Categorias> ObtenerCategorias()
        {
            ListadeCategorias = _contexto.Categoria.ToList();
            return ListadeCategorias;
        }

        public void GuardarCategoria(Categorias categoria)
        {
            if (categoria.Id == 0)
            {
                _contexto.Categoria.Add(categoria);
            }
            else
            {
                var categoriaExistente = _contexto.Categoria.Find(categoria.Id);
                categoriaExistente.Descripcion = categoria.Descripcion;

            }

            _contexto.SaveChanges();
        }

        public Categorias ObtenerCategoria(int id)
        {
            var categoria = _contexto.Categoria.Find(id);
            return categoria;
        }
        public void EliminarCategoria(int id)
        {
            var categoria = _contexto.Categorias.Find(id);
            _contexto.Categorias.Remove(categoria);
            _contexto.SaveChanges();
        }
    }

}
    

