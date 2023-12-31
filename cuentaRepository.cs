﻿using ExamenFinalOptativoIV.Model;

namespace ExamenFinalOptativoIV
{
    public class cuentaRepository
    {
        private string _connectionString;
        private Npgsql.NpgsqlConnection connection;

        public cuentaRepository(string connectionString)
        {
            this._connectionString = connectionString;
            this.connection = new Npgsql.NpgsqlConnection(this._connectionString);
        }

        public CuentaModel consultarCuenta(string numeroCuenta)
        {
            try
            {
                return connection.QueryFirst<CuentaModel>($"SELECT * FROM cuenta WHERE numeroCuenta = {numeroCuenta}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string modificarCuenta(CuentaModel cuenta)
        {
            try
            {
                connection.Execute($"UPDATE cuenta SET " +
                    "idPersona = @idPersona, " +
                    "nombreCuenta = @nombreCuenta, " +
                    "numeroCuenta = @numeroCuenta, " +
                    "saldo = @saldo, " +
                    "limite = @limite, " +
                    "moneda = @moneda, " +
                    "estado = @estado " +
                    $"WHERE id = {cuenta.idCuenta}", cuenta);
                return "Se modificaron los datos correctamente...";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
