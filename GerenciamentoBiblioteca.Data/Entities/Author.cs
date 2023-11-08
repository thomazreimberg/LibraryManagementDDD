using LibraryManagement.Data.Entities.Base;
using LibraryManagement.Domain.Interfaces.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoBiblioteca.Data.Entities
{
    public class Author : BaseTable<int>, IAuthor
    {
        [Column("varchar(50)")]
        public string? Name { get; set; }
    }
}
