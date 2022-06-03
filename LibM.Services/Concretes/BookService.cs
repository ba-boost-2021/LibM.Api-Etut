using LibM.Common.Dtos;
using LibM.Data.Context;
using LibM.Data.Entities;
using LibM.Services.Abstractions;

namespace LibM.Services.Concretes
{
    internal class BookService : IBookService
    {
        private readonly LibMDbContext dbContext;

        public BookService(LibMDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public bool Add(NewBookDto dto)
        {
            var newEntity = new Book
            {
                AuhtorName = dto.AuthorName,
                Name = dto.Name,
            };
            dbContext.Books.Add(newEntity);
            var result = dbContext.SaveChanges();
            return result > 0;
        }
    }
}