using System.Threading.Tasks;

namespace ComicStore.Core.Data
{
    public interface IUnitOfWork
    {
       Task<bool> Commit();  
    }
}