using System;
using System.ComponentModel;
using System.ComponentModel. DataAnnotations;

namespace MyTodoApp.Models
{
    public class Todo
    {
        public int Id { get; set;}
        
        [DisplayName("Titulo")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Title { get; set;}

        [DisplayName("Concluido")]
        public bool Done { get; set;}

        [DisplayName("Criado em")]
        public DateTime CreatedAt { get; set;} = DateTime.Now;

        [DisplayName("Última atualização")]
        public DateTime LastUpdateDate { get; set;} = DateTime.Now;

        [DisplayName("Usuario")]
        public string User { get; set;}

    }
}