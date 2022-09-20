using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyTodoApp.Models
{
    public class Todo
    {
        public int Id{ get; set; }

        [DisplayName("Título")]
        [Required]
        public string Title{ get; set; }

        [DisplayName("Concluído")]
        public bool Done{ get; set; }

        [DisplayName("Criado em")]
        public DateTime CreatedAt { get; set; }  = DateTime.Now;

        [DisplayName("Última atualização")]
        public DateTime LastUpdateDate{ get; set; } = DateTime.Now;

        [DisplayName("Usuario")]
        public string User{ get; set; }

    }
}