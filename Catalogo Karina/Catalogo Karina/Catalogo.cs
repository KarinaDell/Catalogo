using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo_Karina
{
    class Catalogo
    {
     private Producto[] productos = new Producto[15];
        int c, ultimo = 0;

        public void Agregar(Producto producto)
        {
            if(ultimo != 14)
                productos[c++] = producto;
        }

        public string Buscar(int _codigo)
        {
            string s = "";
            for (int i = 0; i < 14; i++)
                if (productos[i] != null)
                    if (_codigo == productos[i].Codigo)
                        s += productos[i].ToString();
            return s;
        }

        public void Eliminar(int _codigo)
        {
            int posicion = 0;
            for (int i = 0; i < 14; i++)
                if (productos[i] != null)
                    if (_codigo == productos[i].Codigo) {
                        posicion = i;
                        break;
                    }
            for (int j = posicion; j < 14; j++)
                productos[j] = productos[j + 1];
            productos[14] = null;
        }

        public void Insertar(Producto producto, int posicion)
        {
            for(int i = 14; i > posicion; i--)
            {
                productos[i] = productos[i - 1];
            }

            productos[posicion] = producto;
        }

        public string listar()
        {
            string s = "";
            for (int i = 0; i < 14; i++)
                if (productos[i] != null)
                    s += productos[i].ToString()+Environment.NewLine;
            return s;
        }



    }
}
