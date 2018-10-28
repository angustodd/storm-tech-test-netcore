﻿using System.Collections.Generic;
using Todo.Models.TodoItems;

namespace Todo.Models.TodoLists
{
    public class TodoListDetailViewmodel
    {
        public int TodoListId { get; }
        public string Title { get; }
        public ICollection<TodoItemSummaryViewmodel> Items { get; }
        public bool HideDone { get; }
        public bool OrderByRank { get; }

        public TodoListDetailViewmodel(int todoListId, string title, ICollection<TodoItemSummaryViewmodel> items, bool hideDone, bool orderByRank)
        {
            Items = items;
            TodoListId = todoListId;
            Title = title;
            HideDone = hideDone;
            OrderByRank = orderByRank;
        }
    }
}