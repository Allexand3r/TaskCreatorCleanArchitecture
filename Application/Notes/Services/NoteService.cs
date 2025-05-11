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

    public async Task<string> GetNoteByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        var note = await noteRepository.GetNoteByIdAsync(id, cancellationToken);
        if (note == null)
        {
            throw new Exception($"Note with id: {id} not found");
        }
        return note.Title;
    }
     public async Task<List<Note>> GetAllNotesAsync(CancellationToken cancellationToken = default)
     {
         return await noteRepository.GetAllNotesAsync(cancellationToken);
     }

     public async Task DeleteNoteAsync(int id, CancellationToken cancellationToken = default)
     {
         var note = await noteRepository.GetNoteByIdAsync(id, cancellationToken);
         if (note == null)
         {
             throw new Exception($"Note with id: {id} not found");
         }
         await noteRepository.DeleteNoteAsync(note, cancellationToken);
     }
     public async Task UpdateTitleNoteAsync(int id, string newText, CancellationToken cancellationToken = default)
     {
         var note = await noteRepository.GetNoteByIdAsync(id, cancellationToken);
         if (note == null)
             throw new Exception($"Note with id: {id} not found");
         note.Title = newText;
         await noteRepository.UpdateTitleNoteAsync(note, cancellationToken);
     }

     public async Task CreateNoteContentAsync(int id, string text, CancellationToken cancellationToken = default)
     {
         var note = await noteRepository.GetNoteByIdAsync(id, cancellationToken);
         if (note == null)
             throw new Exception($"Note with id: {id} not found");
         note.Content = text;
         await noteRepository.CreateNoteContentAsync(note, cancellationToken);
     }
}