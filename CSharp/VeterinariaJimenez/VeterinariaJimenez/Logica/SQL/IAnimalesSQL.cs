using System;
using System.Data;

namespace VeterinariaJimenez.Logica.SQL
{
    public interface IAnimalesSql
    {
        #region Metodos de la clase

        Boolean IsError { set; get; }
        String ErrorDescripcion { set; get; }

        #endregion

        #region Sql

        void InsertarAnimal(string nombre, int especie, int tipo, string dueno);
        void EditarAnimal(int id, string nombre, int especie, int tipo, string dueno);
        void EliminarAnimal(int id);
        DataSet TraerAnimales(string filtro);

        #endregion
    }
}
