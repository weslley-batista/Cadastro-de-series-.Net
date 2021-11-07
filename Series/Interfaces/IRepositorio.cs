using System.Collections.Generic;

namespace Series.Interfaces
{
    public interface IRepositorio<srie>
    {
        //metodos necessarios
         List<srie> Lista();
         srie RetornaPorId(int id);
         void Insere(srie entidade);        
        void Exclui(int id);        
        void Atualiza(int id, srie entidade);
        int ProximoId();    
    }
}