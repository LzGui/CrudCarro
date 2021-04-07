using CrudCarro.Context;
using CrudCarro.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using System;

namespace CrudCarro.Services
{
    public class CarroService : ICarroService
    {
        private readonly LocalDbContext _local;

        public CarroService(LocalDbContext local)
        {
            _local = local;
        }

        public bool AdicionarCarro(Carros carro)
        {

            _local.carro.Add(carro);
            _local.SaveChanges();
            return true;
        }

        public bool AtualizarCarro(Carros novoCarro)
        {

            _local.carro.Attach(novoCarro);
            _local.Entry(novoCarro).State = EntityState.Modified;
            _local.SaveChanges();
            return true;
        }

        public bool DeletarCarro(int id)
        {
   
            var objApagar = _local.carro.Where(d => d.id == id).FirstOrDefault();
            _local.carro.Remove(objApagar);
            _local.SaveChanges();
            return true;
        }

        public List<Carros> RetonarListaCarro()
        {

            return _local.carro.ToList();
        }

        public Carros RetornarProdutoPorId(int id)
        {

            return _local.carro.Where(d => d.id == id).FirstOrDefault();
        }
    }
}