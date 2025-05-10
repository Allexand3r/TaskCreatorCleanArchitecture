using Domain;

namespace Infrastructure.Repositories.Interfaces;

public interface INoteRepository
{
    Task CreateNoteAsync(Note note, CancellationToken cancellationToken = default);
}