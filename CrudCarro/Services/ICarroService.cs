using System;
using System.Collections.Generic;
using CrudCarro.Entities;

namespace CrudCarro.Services
{
    public class ICarroService
    {
        public bool AdicionarCarro(Carros novoCarro);
        public List<Carros> RetornarListaCarro();
        public bool AtualizarCarro(Carros novoCarro);
        public Carros RetornarCarroPorId(int id);
        public bool DeletarCarro(int id);

    }
}
