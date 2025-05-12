
using Domain;


namespace TaskCreatorTests;

public class TaskCrudTest
{
    [Fact]
    public async Task DeleteNote_RemovesNoteFromDatabase()
    {
        var context = NotesContextFactory.Create();
        var noteToDelete = await context.Notes.FindAsync(NotesContextFactory.NoteIdForDelete);

        context.Notes.Remove(noteToDelete);
        await context.SaveChangesAsync();

        var deletedNote = await context.Notes.FindAsync(NotesContextFactory.NoteIdForDelete);
        Assert.Null(deletedNote);

        NotesContextFactory.Destroy(context);
    }

    [Fact]
    public async Task UpdateNote_ChangesNoteContent()
    {
        var context = NotesContextFactory.Create();
        var noteToUpdate = await context.Notes.FindAsync(NotesContextFactory.NoteIdForUpdate);

        noteToUpdate.Content = "Updated content";
        noteToUpdate.Modified = DateTime.Now;
        await context.SaveChangesAsync();

        var updatedNote = await context.Notes.FindAsync(NotesContextFactory.NoteIdForUpdate);
        Assert.Equal("Updated content", updatedNote.Content);

        NotesContextFactory.Destroy(context);
    }

    [Fact]
    public async Task CreateNote_AddsNoteToDatabase()
    {
        var context = NotesContextFactory.Create();
        var newNote = new Note
        {
            Id = 100,
            Title = "Created",
            Content = "Some content",
            Created = DateTime.Now
        };

        context.Notes.Add(newNote);
        await context.SaveChangesAsync();

        var note = await context.Notes.FindAsync(100);
        Assert.NotNull(note);
        Assert.Equal("Created", note.Title);

        NotesContextFactory.Destroy(context);
    }
}