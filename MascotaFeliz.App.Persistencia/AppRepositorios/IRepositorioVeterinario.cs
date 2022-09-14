using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
        IEnumerable<Veterinario> GetAllVeterinarios();
        Veterinario AddVeterinario (Veterinario veterinario);
        void DeleteVeterinario (int idVeterinario);
        Veterinario UpdateVeterinario (Veterinario veterinario);
        Veterinario GetVeterinario (int idVeterinario);
        IEnumerable<Veterinario> GetVeterinariosPorFiltro(string filtro);
        

    }

}