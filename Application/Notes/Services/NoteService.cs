using Application.Notes.Interfaces;
using Domain;
using Infrastructure.Repositories.Interfaces;

namespace Application.Notes.Services;

internal class NoteService(INoteRepository noteRepository) : INoteService
{
    public async Task CreateNoteAsync(string text, CancellationToken cancellationToken = default)
    {
        var note = new Note
        {
            Title = text
        };
        await noteRepository.CreateNoteAsync(note, cancellationToken);
    }
}