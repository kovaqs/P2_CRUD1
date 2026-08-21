using System;
using System.Collections.Generic;
using GestionEstudiantes.Core.Data;
using GestionEstudiantes.Core.Models;
using GestionEstudiantes.Core.Validation;

namespace GestionEstudiantes.Core.Services
{
    public class EstudianteService
    {
        private readonly EstudianteRepository repository;

        public EstudianteService()
        {
            repository = new EstudianteRepository();
        }


        public List<Estudiante> ObtenerTodos()
        {
            return repository.ObtenerTodos();
        }


        public Estudiante ObtenerPorId(int id)
        {
            return repository.ObtenerPorId(id);
        }


        public void Crear(Estudiante estudiante)
        {
            string error = EstudianteValidator.Validar(estudiante);

            if (error != null)
                throw new ArgumentException(error);

            if (repository.ExisteCarnet(estudiante.Carnet))
                throw new ArgumentException("Ya existe un estudiante con ese carnet.");

            if (repository.ExisteCorreo(estudiante.Correo))
                throw new ArgumentException("Ya existe un estudiante con ese correo.");

            repository.Crear(estudiante);
        }


        public void Actualizar(Estudiante estudiante)
        {
            string error = EstudianteValidator.Validar(estudiante);

            if (error != null)
                throw new ArgumentException(error);

            if (repository.ExisteCarnet(estudiante.Carnet, estudiante.Id))
                throw new ArgumentException("Ya existe otro estudiante con ese carnet.");

            if (repository.ExisteCorreo(estudiante.Correo, estudiante.Id))
                throw new ArgumentException("Ya existe otro estudiante con ese correo.");

            repository.Actualizar(estudiante);
        }


        public void Eliminar(int id)
        {
            repository.Eliminar(id);
        }


        public List<Estudiante> Buscar(string texto, string estado)
        {
            return repository.Buscar(texto, estado);
        }

        public void CambiarEstado(int id, string estado)
        {
            if (estado != "Activo" && estado != "Inactivo")
                throw new ArgumentException("Estado inválido.");

            repository.CambiarEstado(id, estado);
        }
    }
}