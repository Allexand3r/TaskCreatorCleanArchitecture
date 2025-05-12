using Domain;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace TaskCreatorTests;

public static class NotesContextFactory
{
    public static int NoteIdForDelete = 25;
    public static int NoteIdForUpdate = 26;

    public static AppDbContext Create()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;
        var context = new AppDbContext(options);
        context.Database.EnsureCreated();
        context.Notes.AddRange(
            new Note
            {
                Id = NoteIdForDelete,
                Title = "ToDelete",
                Content = "Details1",
                Created = DateTime.Now,
                Modified = null
            },
            new Note
            {
                Id = NoteIdForUpdate,
                Title = "ToUpdate",
                Content = "Details2",
                Created = DateTime.Now,
                Modified = null
            }
        );
        context.SaveChanges();
        return context;
    }

    public static void Destroy(AppDbContext context)
    {
        context.Database.EnsureDeleted();
        context.Dispose();
    }
}