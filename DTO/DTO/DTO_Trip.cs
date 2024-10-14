using DTO.Schemas;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Trip : DTO_Base<Trip>
    {
		private DTO_Bus dto_bus = new DTO_Bus();
        private DTO_Driver dto_driver = new DTO_Driver();
        private DTO_School dto_school = new DTO_School();
        private DTO_Region dto_region = new DTO_Region();
        private DTO_Student dto_student = new DTO_Student();

        public DTO_Trip() : base("Trip")
        {
		}
	}
}
