using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Demo.Validation.Models {

	public class Thing {// : IValidatableObject
	
		[Required, JsonProperty("name")]
		public string Name { get; set; }

		[Required, EmailAddress, Key, JsonProperty("email")]
		public string Email { get; set; }

		[Range(1, 10), JsonProperty("length")]
		public int Length { get; set; }
	}
}