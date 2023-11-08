using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Data.Entities.Base
{
    public class BaseTable<T>
    {
        [Key]
        public T Id { get; set; }
    }
}
