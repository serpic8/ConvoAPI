using API.Models;
using API.Models.Dto;
using API.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Clase1Controller : ControllerBase
    {
        private readonly ILogger<Clase1Controller> _logger;
        private readonly IClase1Repository _clase1Repo;
        private readonly IMapper _mapper;

        public Clase1Controller(ILogger<Clase1Controller> logger, IClase1Repository clase1Repository, IMapper mapper)
        {
            _logger = logger;
            _clase1Repo = clase1Repository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Authorize(Roles = "Admin")] //Roles con los cuales puedo usar la autorizacion, para ver los role puedo observar el data contexts
        public async Task<ActionResult<IEnumerable<Clase1Dto>>> GetProducts()
        {
            _logger.LogInformation("Obtener los Datos");

            var productsList = await _clase1Repo.GetAll();

            return Ok(_mapper.Map<IEnumerable<Clase1Dto>>(productsList));
        }

        [HttpDelete("{id}", Name = "DeleteProduct")] //El nombre se puede cambiar
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            var product = await _clase1Repo.GetById(id);

            if (product == null)
            {
                return NotFound();
            }

            await _clase1Repo.Delete(product);

            return Ok();
        }

        [HttpPost("Products", Name = "AddProducts")] //Aqui tmb
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Clase1Dto>> AddProduct([FromBody] Clase1CreateDto clase1CreateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                Clase1 model = _mapper.Map<Clase1>(clase1CreateDto);

                await _clase1Repo.Add(model);

                return CreatedAtRoute("GetData", new { id = model.Id }, model);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error al agregar el Dato: " + ex.Message);
            }
        }

        //Funcionan Igual ambos
        //[HttpPost]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public async Task<ActionResult<Clase1Dto>> AddClase([FromBody] Clase1CreateDto claseCreateDto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (await _clase1Repo.Get(s => s.Nombre.ToLower() == claseCreateDto.Nombre.ToLower()) != null)
        //    {
        //        ModelState.AddModelError("NombreExiste", "¡El CLiente con ese Nombre ya existe!");
        //        return BadRequest(ModelState);
        //    }

        //    if (claseCreateDto == null)
        //    {
        //        return BadRequest(claseCreateDto);
        //    }

        //    Clase1 modelo = _mapper.Map<Clase1>(claseCreateDto);

        //    await _clase1Repo.Add(modelo);

        //    return CreatedAtRoute("GetCliente", new { id = modelo.Id }, modelo);
        //}


        [HttpPut("{id}", Name = "UpdateProduct")]  //Lo del nombre
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> UpdateProduct(int id, [FromBody] Clase1UpdateDto productDto)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var clase = await _clase1Repo.GetById(id);
            if (clase == null)
            {
                return NotFound();
            }

            clase.Nombre = productDto.Nombre;
            clase.Fecha = productDto.Fecha;      //Solo cambia nombres
            clase.Clase2_ID = productDto.Clase2_ID;
            clase.Clase4_ID = productDto.Clase4_ID;
           

            // Guardar los cambios en la base de datos
            await _clase1Repo.Update(clase);

            return Ok();
        }

    }
}
