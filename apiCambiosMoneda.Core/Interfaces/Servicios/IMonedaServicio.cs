﻿using apiCambiosMoneda.Dominio.DTOs;
using apiCambiosMoneda.Dominio.Entidades;

namespace apiCambiosMoneda.Core.Interfaces.Servicios
{
    public interface IMonedaServicio
    {
        Task<Moneda> Obtener(int Id);

        Task<IEnumerable<Moneda>> ObtenerTodos();

        Task<IEnumerable<Moneda>> Buscar(int Tipo, string Dato);

        Task<Moneda> Agregar(Moneda Moneda);

        Task<Moneda> Modificar(Moneda Moneda);

        Task<bool> Eliminar(int Id);

        /********** CAMBIOS **********/

        Task<IEnumerable<CambioMoneda>> ObtenerCambios(int IdMoneda);

        Task<CambioMoneda> BuscarCambio(int IdMoneda, DateTime Fecha);

        Task<CambioMoneda> AgregarCambio(CambioMoneda Cambio);

        Task<CambioMoneda> ModificarCambio(CambioMoneda Cambio);

        Task<bool> EliminarCambio(int IdMoneda, DateTime Fecha);

        /********** CONSULTAS **********/

        Task<IEnumerable<CambioMoneda>> ObtenerHistorialCambios(int idMoneda, DateTime desde, DateTime hasta);

        Task<CambioMoneda> ObtenerCambioActual(int idMoneda);

        Task<IEnumerable<Pais>> ObtenerPaisesPorMoneda(int idMoneda);

        /********** ANALISIS **********/

        public Task<IEnumerable<AnalisisInversionDTO>> AnalizarInversionEntreMonedas(string SiglaMonedaA, string SiglaMonedaB,
                                                                                        DateTime Desde, DateTime Hasta);

        Task<IEnumerable<AnalisisInversionDTO>> AnalizarInversionDolar(
             string siglaMoneda,
             DateTime desde,
             DateTime hasta,
             double umbralCambioPorcentaje = 1.0 // 1% por defecto
         );
    }
}
