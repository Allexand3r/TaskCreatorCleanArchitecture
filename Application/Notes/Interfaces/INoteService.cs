namespace Application.Notes.Interfaces;

public interface INoteService
{
    Task CreateNoteAsync(string text, CancellationToken cancellationToken = default);
}