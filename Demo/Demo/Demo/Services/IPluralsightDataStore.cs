using Demo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Services
{
    public interface IPluralsightDataStore
    {
        Task<String> AddNoteAsync(Note courseNote);
        Task<bool> UpdateNoteAsync(Note courseNote);
        Task<Note> GetNoteAsync(String id);
        Task<IList<String>> GetCoursesAsync();

    }
}
