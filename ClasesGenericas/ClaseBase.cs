using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesGenericas
{
    class ClaseBase<T>
    {
        private List<T> Elementos = new List<T>();

        public void Agregar(T Elemento)
        {

            Elementos.Add(Elemento);
        }

        public void Limpiar()
        {
            Elementos.Clear();
        }

        public void Insertar(int Index, T Elemento)
        {
            Elementos.Insert(Index, Elemento);
        }

        public void Eliminar(int Index)
        {
            Elementos.RemoveAt(Index);
        }

        public T this[int Index]
        {
            get { return Elementos[Index]; }
            set { Elementos[Index] = value; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Elementos.GetEnumerator();
        }

       
        public int Contar
        {
           get { return Elementos.Count;}
        }
        
    }
}
