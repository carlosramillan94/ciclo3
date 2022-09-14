using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioHistoria
    {
        IEnumerable<Historia> GetAllHistorias();
        Historia AddHistoria (Historia historia);
        void DeleteHistoria (int IdHistoria);
        Historia UpdateHistoria (Historia historia);
        Historia GetHistoria (int IdHistoria);
        ////IEnumerable<Historia> GetHistoriasPorFiltro(string filtro);

    }

}