using Microsoft.AspNetCore.Mvc;
using RateMe.Business.Services.Interfaces;
using RateMe.Models;

namespace RateMe.Controllers
{
    [ApiController]
    public class PicturesController : ControllerBase
    {
        private readonly IPicturesService _picturesService;
        private readonly IUsersService _usersService;

        public PicturesController(IPicturesService picturesService, IUsersService usersService)
        {
            _picturesService = picturesService;
            _usersService = usersService;
        }

        //[HttpPost]
        //[Route("api/create/picture")]
        //public async Task<IActionResult> AddPicture([FromBody] Picture picture)
        //{
        //    if (picture == null)
        //    {
        //        return BadRequest();
        //    }

        //    await _picturesService.AddPictureAsync(picture);

        //    return Ok();
        //}

        [HttpGet]
        [Route("api/pictures")]
        public async Task<IEnumerable<Picture>> GetAllPictures()
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return await _picturesService.GetPicturesAsync();
        }

        [HttpPost]
        [Route("api/create/picture")]
        public async Task<ActionResult<Picture>> PostAsync([FromForm] IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("Invalid file");
            }

            var picture = new Picture
            {
                Name = file.FileName,
                Type = file.ContentType
            };

            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                picture.Data = stream.ToArray();
            }

            var savedPicture = await _picturesService.SavePictureAsync(picture);

            return savedPicture;
        }
    }
}
