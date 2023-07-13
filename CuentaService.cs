using System;
using infraestructure.repository;

namespace ExamenFinalOptativoIV
{
    public class CuentaService
    {
        private class cuentaRepository repository;

        public CuentaService(string CadenaConexion)
        {
            repository = new cuentaRepository(CadenaConexion);
        }

        public bool insertarCuenta()
        {
            return true;
        }

        public bool modificarCuenta()
        {
            return true;
        }
        public bool eliminarCuenta()
        {
            return true;
        }

        public infraestructure.Models.cuentaModel consultarCuenta(string numeroCuenta)
        {
            return repository.consultarCuenta(numeroCuenta);
        }

        public List<string> listarCuentas()
        {
            return null;
        }
    }
}
