﻿using Microsoft.EntityFrameworkCore;
using PFinanzas.Data.Context;
using PFinanzas.Data.Entities;

namespace PFinanzas.Data.Services
{
    public class UsuarioServices : IUsuarioServices
    {
        private readonly IMyDbContext dbContext;

        public UsuarioServices(IMyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Result> Crear(UsuarioRequest request)
        {
            try
            {
                var Usuario = Entities.Usuario.Crear(request);
                dbContext.Usuarios.Add(Usuario);
                await dbContext.SaveChangesAsync();
                return new Result { Message = "OK", Success = true };
            }
            catch (Exception ex)
            {
                return new Result() { Message = ex.Message, Success = false };

            }

        }

        public async Task<Result> Modificar(UsuarioRequest request)
        {
            try
            {
                var Usuario = await dbContext.Usuarios.FirstOrDefaultAsync(c => c.Id == request.Id);
                if (Usuario == null)
                    return new Result { Message = "Usuario no registrado", Success = false };

                if (Usuario.Modificar(request))
                    await dbContext.SaveChangesAsync();
                return new Result { Message = "OK", Success = true };

            }
            catch (Exception ex)
            {
                return new Result() { Message = ex.Message, Success = false };

            }

        }

        public async Task<Result> Eliminar(UsuarioRequest request)
        {
            try
            {
                var Usuario = await dbContext.Usuarios.FirstOrDefaultAsync(c => c.Id == request.Id);
                if (Usuario == null)
                    return new Result { Message = "Usuario no registrado", Success = false };

                dbContext.Usuarios.Remove(Usuario);
                await dbContext.SaveChangesAsync();
                return new Result { Message = "OK", Success = true };

            }
            catch (Exception ex)
            {
                return new Result() { Message = ex.Message, Success = false };

            }

        }

        public async Task<Result<List<UsuarioResponse>>> Consultar(string filtro)
        {
            try
            {
                var Usuario = await dbContext.Usuarios.Where(c => (c.Nombre + " " + c.Apellido + " " + c.Correo).ToLower().Contains(filtro.ToLower()).Select(c => c.ToResponse()).ToListAsync();
                return new List<Result<UsuarioResponse>>
                {
                    Message = "Ok",
                    Success = true,
                    Data = Usuario
                };
            }
            catch (Exception ex)
            {
                return new Result<List<UsuarioResponse>> { Message = ex.Message, Success = false };
            }
        }

    }

    public class Result
    {
        public bool Success { get; set; }
        public string? Message { get; set; }

    }

    public class Result<T>
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public T? Data { get; set; }

    }

}