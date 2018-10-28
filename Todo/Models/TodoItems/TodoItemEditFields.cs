using System.ComponentModel.DataAnnotations;
using Todo.Data.Entities;

namespace Todo.Models.TodoItems
{
    public class TodoItemEditFields : TodoItemBase
    {
        public int TodoItemId { get; set; }
        [Display(Name = "Task is complete")]
        public bool IsDone { get; set; }
        public int Rank { get; set; }

        public TodoItemEditFields() { }

        public TodoItemEditFields(int todoListId, string todoListTitle, int todoItemId, string title, bool isDone, int rank, string responsiblePartyId, Importance importance)
        {
            TodoListId = todoListId;
            TodoListTitle = todoListTitle;
            TodoItemId = todoItemId;
            Title = title;
            IsDone = isDone;
            Rank = rank;
            ResponsiblePartyId = responsiblePartyId;
            Importance = importance;
        }
    }
}