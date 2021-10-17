using System.Collections.Generic;
using System.Linq;
using ProyectoEnvios.App.Dominio;

namespace ProyectoEnvios.App.Persistencia.AppRepositorios
{
    public class RepositorioFuncionario : IRepositorioFuncionario   
    {
        private readonly AppContext _appContext;
        public RepositorioFuncionario(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<Funcionario> IRepositorioFuncionario.GetAllFuncionarios()
        {
            return _appContext.Funcionarios;
        }

        Funcionario IRepositorioFuncionario.AddFuncionario(Funcionario funcionario)
        {
            var funcionarioAgregado = _appContext.Funcionarios.Add(funcionario);
            _appContext.SaveChanges();
            return funcionarioAgregado.Entity;
        }

        Funcionario IRepositorioFuncionario.UpdateFuncionario(Funcionario funcionario)
        {
            var funcionarioEncontrado = _appContext.Funcionarios.FirstOrDefault(u => u.Id == funcionario.Id);
            if (funcionarioEncontrado != null)
            {
                funcionarioEncontrado.fun_nombre =funcionario.fun_nombre;
                funcionarioEncontrado.fun_apellidos=funcionario.fun_apellidos;
                _appContext.SaveChanges();
            }
            return funcionarioEncontrado;
        
        }

        
        void IRepositorioFuncionario.DeleteFuncionario(int idFuncionario)
        {
            var funcionarioEncontrado = _appContext.Funcionarios.FirstOrDefault(u => u.Id == idFuncionario);
            if (funcionarioEncontrado == null)
                return;
            _appContext.Funcionarios.Remove(funcionarioEncontrado);
            _appContext.SaveChanges();
        }

        Funcionario IRepositorioFuncionario.GetFuncionario(int idFuncionario)
        {
            return _appContext.Funcionarios.FirstOrDefault(u => u.Id == idFuncionario);
        }
    }
}

        
        