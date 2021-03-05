using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TecTradeAPI.Models;

namespace TecTradeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetTypeController : Controller
    {
        private readonly AssetTypeContext _context;

        public AssetTypeController(AssetTypeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AssetType>>> GetAssetType()
        {
            return await _context.AssetType.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AssetType>> GetAssetType(int id)
        {
            var assettype = await _context.AssetType.FindAsync(id);

            if (assettype == null)
            {
                return NotFound();
            }

            return assettype;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAssetType(int id, AssetType assetType)
        {
            if (id != assetType.Id)
            {
                return BadRequest();
            }
            _context.Entry(assetType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssetTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<AssetType>> PostAssetType(AssetType assetType)
        {
            _context.AssetType.Add(assetType);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAssetType), new { id = assetType.Id }, assetType);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<AssetType>> DeleteAssetType(int id)
        {
            var assettype = await _context.AssetType.FindAsync(id);
            if (assettype == null)
            {
                return NotFound();
            }
            _context.AssetType.Remove(assettype);
            await _context.SaveChangesAsync();

            return assettype;
        }

        private bool AssetTypeExists(int id)
        {
            return _context.AssetType.Any(e => e.Id == id);
        }
    }
}
