using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models.MyWebApiProject.Models;

namespace WebApplication1.Services
{

    public class TodoService
    {
        private readonly AppDbContext _context;

        public TodoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TodoItem>> GetTodoItemsAsync()
        {
            return await _context.TodoItems.ToListAsync();
        }

        public async Task<TodoItem> GetTodoItemAsync(long id)
        {
            return await _context.TodoItems.FindAsync(id);
        }

        public async Task AddTodoItemAsync(TodoItem todoItem)
        {
            _context.TodoItems.Add(todoItem);
            await _context.SaveChangesAsync();
        }

        //public async Task UpdateTodoItemAsync(TodoItem todoItem)
        //{
        //    _context.Entry(todoItem).State = EntityState.Modified;
        //    await _context.SaveChangesAsync();
        //}

        public async Task DeleteTodoItemAsync(long id)
        {
            var todoItem = await _context.TodoItems.FindAsync(id);
            if (todoItem != null)
            {
                _context.TodoItems.Remove(todoItem);
                await _context.SaveChangesAsync();
            }
        }

    }
}
