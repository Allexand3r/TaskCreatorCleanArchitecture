using Domain;

namespace Infrastructure.Repositories.Interfaces;

public interface INoteRepository
{
    Task CreateNoteAsync(Note note, CancellationToken cancellationToken = default);
    Task<Note?> GetNoteByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<List<Note>> GetAllNotesAsync(CancellationToken cancellationToken = default);
    Task DeleteNoteAsync(Note note, CancellationToken cancellationToken = default);
}