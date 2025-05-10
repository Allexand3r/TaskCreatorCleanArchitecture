using Domain;
using Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Implementation;

internal class NoteRepository(AppDbContext context) : INoteRepository
{
    public async Task CreateNoteAsync(Note note, CancellationToken cancellationToken = default)
    {
        note.Created = DateTime.UtcNow;
        await context.Notes.AddAsync(note, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }

    public async Task<Note?> GetNoteByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return await context.Notes.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task<List<Note>> GetAllNotesAsync(CancellationToken cancellationToken = default)
    {
        return await context.Notes.ToListAsync(cancellationToken);
    }

    public async Task DeleteNoteAsync(Note note, CancellationToken cancellationToken = default)
    {
        context.Notes.Remove(note);
        await context.SaveChangesAsync(cancellationToken);
    }
}   