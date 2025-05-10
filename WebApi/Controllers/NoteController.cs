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
}