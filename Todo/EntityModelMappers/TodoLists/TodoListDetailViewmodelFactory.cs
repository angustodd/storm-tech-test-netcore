using System.Linq;
using Todo.Data.Entities;
using Todo.EntityModelMappers.TodoItems;
using Todo.Models.TodoLists;

namespace Todo.EntityModelMappers.TodoLists
{
    public static class TodoListDetailViewmodelFactory
    {
        public static TodoListDetailViewmodel Create(TodoList todoList, bool hideDone, bool orderByRank)
        {
            var items = hideDone ?
                todoList.Items.Where(i => !i.IsDone) :
                todoList.Items;

            items = orderByRank ?
                items.OrderByDescending(i => i.Rank).ThenBy(i => i.Importance) :
                items.OrderBy(i => i.Importance).ThenByDescending(i => i.Rank);

            var itemViewModels = items.Select(TodoItemSummaryViewmodelFactory.Create).ToList();

            return new TodoListDetailViewmodel(todoList.TodoListId, todoList.Title, itemViewModels, hideDone, orderByRank);
        }
    }
}