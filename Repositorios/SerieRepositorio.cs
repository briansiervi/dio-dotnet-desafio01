using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;
using DIO.Series.Modelos;

namespace DIO.Series.Repositorios
{
    public sealed class SerieRepositorio : IRepositorio<Serie>
    {
        #region Singleton
        private static readonly Lazy<SerieRepositorio> lazy = new Lazy<SerieRepositorio>(() => new SerieRepositorio());

        public static SerieRepositorio Instance { get { return lazy.Value; } }

        public SerieRepositorio() { }
        #endregion

        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}