using ProductStore.Data.Interfaces;
using ProductStore.Data.Interfaces.Repositories;
using ProductStore.Model;

namespace ProductStore.Data.Repositories
{
    public class DocumentRepository : Repository<Document, IDbContext>, IDocumentRepository
    {
        public DocumentRepository(IDbContext context) : base(context)
        {
        }
    }
}
