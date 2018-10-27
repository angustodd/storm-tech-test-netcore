using System.Linq;
using Todo.Data.Entities;
using Todo.EntityModelMappers.TodoItems;
using Todo.Models.TodoLists;

namespace Todo.EntityModelMappers.TodoLists
{
    public static class TodoListDetailViewmodelFactory
    {
        public static TodoListDetailViewmodel Create(TodoList todoList, bool hideDone)
        {
            var items = hideDone ?
                todoList.Items.Where(i => !i.IsDone) :
                todoList.Items;

            var itemViewModels = items.Select(TodoItemSummaryViewmodelFactory.Create).ToList();

            return new TodoListDetailViewmodel(todoList.TodoListId, todoList.Title, itemViewModels, hideDone);
        }
    }
}