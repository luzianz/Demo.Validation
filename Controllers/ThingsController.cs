using Demo.Validation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Demo.Validation.Controllers {

	[Route("api/[controller]")]
	public class ThingsController : Controller {

		[HttpPost]
		public IActionResult PostThing([FromBody] Thing thing) {
			switch (ModelState.ValidationState) {
				case ModelValidationState.Invalid:
				case ModelValidationState.Skipped:
				case ModelValidationState.Unvalidated:
					return BadRequest(ModelState);
				case ModelValidationState.Valid:
					return Ok();
				default:
					return StatusCode(500, "Something dum happened");
			}
		}
	}
}