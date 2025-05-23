using Domain;

namespace Application.Notes.Interfaces;

public interface INoteService
{
    Task CreateNoteAsync(string text, CancellationToken cancellationToken = default);
    Task<string> GetNoteByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<List<Note>> GetAllNotesAsync(CancellationToken cancellationToken = default);
    Task DeleteNoteAsync(int id, CancellationToken cancellationToken = default);
    Task UpdateTitleNoteAsync(int id, string newText, CancellationToken cancellationToken = default);
    Task CreateNoteContentAsync(int id, string text, CancellationToken cancellationToken = default);
}