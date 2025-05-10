using Application.Notes.Interfaces;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("/api/note")]

public class NoteController(INoteService noteService) : ControllerBase
{
    [HttpPost("createTask")]
    public async Task<IActionResult> CreateTask(string text)
    {
        await noteService.CreateNoteAsync(text);
        return NoContent();
    }

    [HttpGet("getTask/{id:int}")]
    public async Task<IActionResult> GetTask(int id, CancellationToken cancellationToken = default)
    {
        var note = await noteService.GetNoteByIdAsync(id, cancellationToken);
        return Ok(note);
    }
    
    [HttpGet("getTasks")]
    public async Task<IActionResult> GetTasks(CancellationToken cancellationToken = default)
    {
        var note = await noteService.GetAllNotesAsync(cancellationToken);
        return Ok(note);
    }

    [HttpDelete("deleteTask/{id:int}")]
    public async Task<IActionResult> DeleteTask(int id, CancellationToken cancellationToken = default)
    {
        await noteService.DeleteNoteAsync(id, cancellationToken);
        return NoContent();
    }
}