using System;
using System.ComponentModel.DataAnnotations;
using AgendaVoluntaria.Api.Views.Core;

namespace AgendaVoluntaria.Api.Views
{
    public class VolunteerShiftResponse : BaseResponse
    {
        public Guid IdVolunteer { get; set; }

        public Guid IdShift { get; set; }
    }
}