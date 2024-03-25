using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ArtShop.Data;
using ArtShop.Data.Models;
using ArtShop.Services.Common.Contracts;
using ArtShop.Services.Models.Artwork;
using Microsoft.AspNetCore.Authorization;

namespace ArtShopApp.Server.Controllers
{
    [Route("api/artwork")]
    [ApiController]
    public class ArtworkController(IServiceManager serviceManager) : BaseController
    {
        // GET: api/Artwork
        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<ArtworkDto>>> GetArtworks()
        {
            try
            {
                return Ok(await serviceManager.ArtworkService.GetAllAsync());
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

        //// GET: api/Artwork/{id}
        [HttpGet("{id}")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ArtworkDto>> GetArtworkById(int id)
        {
            try
            {
                var artwork = await serviceManager.ArtworkService.GetByIdAsync(id);

                if (artwork is null)
                {
                    return NotFound();
                }

                return Ok(await serviceManager.ArtworkService.GetByIdAsync(id));

            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

        //// PUT: api/Artwork/{id}
        [HttpPut("{id}")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> PutArtwork(int id, ArtworkFormDto model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            try
            {
                await serviceManager.ArtworkService.UpdateAsync(model);
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, "Internal server error");
            }

            return NoContent();
        }

        // POST: api/Artwork
        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ArtworkDto>> PostArtwork(ArtworkFormDto artwork)
        {
            try
            {
                int createdArtworkId = await serviceManager.ArtworkService.AddAsync(artwork);

                var createdArtwork = await serviceManager.ArtworkService.GetByIdAsync(createdArtworkId);

                return CreatedAtAction("GetArtworkById", new { id = createdArtwork.Id }, createdArtwork);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // DELETE: api/Artwork/{id}
        [HttpDelete("{id}")]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteArtwork(int id)
        {
            try
            {
                await serviceManager.ArtworkService.DeleteAsync(id);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }

            return Ok();
        }
    }
}
