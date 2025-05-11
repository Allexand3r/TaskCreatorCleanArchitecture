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

    public async Task UpdateTitleNoteAsync(Note note, CancellationToken cancellationToken = default)
    {
        note.Modified = DateTime.UtcNow;
        context.Notes.Update(note);
        await context.SaveChangesAsync(cancellationToken);
    }

    public async Task CreateNoteContentAsync(Note note, CancellationToken cancellationToken = default)
    {
        note.Content = note.Content;
        if (note.Content == null)
            context.Notes.Update(note);
        await context.SaveChangesAsync(cancellationToken);
    }
}   