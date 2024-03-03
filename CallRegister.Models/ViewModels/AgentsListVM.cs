﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallRegister.Models.ViewModels
{
    public class AgentsListVM
    {
        public Agent Agent { get; set; }
        public List<PhoneCall>? PhoneCalls { get; set; }
        public List<Email>? Emails { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem>? AgentList { get; set; }

    }
}