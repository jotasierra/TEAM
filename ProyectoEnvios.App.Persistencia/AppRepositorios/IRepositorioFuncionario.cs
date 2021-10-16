using System.Collections.Generic;
using ProyectoEnvios.App.Dominio;

namespace ProyectoEnvios.App.Persistencia
{
    public interface IRepositorioFuncionario
    {
        IEnumerable<Funcionario> GetAllFuncionarios();

        Funcionario AddFuncionario(Funcionario funcionario);

        Funcionario UpdateFuncionario(Funcionario funcionario);

        void DeleteFuncionario(int idFuncionario);

        Funcionario GetFuncionario(int idFuncionario);

    }
}