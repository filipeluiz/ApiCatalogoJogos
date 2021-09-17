using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCatalogoJogos.InputModel;
using ApiCatalogoJogos.ViewModel;

namespace ApiCatalogoJogos.Services
{
    public interface IJogoService
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade);

        Task<JogoViewModel> Obter(Guid id);

        Task<JogoViewModel> Inserir(JogoInputModel jogo);

        Task<JogoViewModel> Atualizar(Guid id, JogoInputModel jogo);

        Task<JogoViewModel> Atualizar(Guid id, double preco);

        Task<JogoViewModel> Remover(Guid id);        
    }
}