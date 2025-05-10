using Domain;
using Infrastructure.Repositories.Interfaces;

namespace Infrastructure.Repositories.Implementation;

internal class NoteRepository(AppDbContext context) : INoteRepository
{
    public async Task CreateNoteAsync(Note note, CancellationToken cancellationToken = default)
    {
        note.Created = DateTime.UtcNow;
        await context.Notes.AddAsync(note, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }
    
}