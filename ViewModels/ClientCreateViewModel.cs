﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Service_Billing.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service_Billing.ViewModels
{
    public class ClientCreateViewModel
    {
        public int Id { get; set; }
        public ClientAccount Account { get; set; }
        public string? MinistryAcronym { get; set; }
        public string? DivisionOrBranch { get; set; }
      //  public string? ApproverName { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem>? Contacts { get; set; }

        public ClientCreateViewModel()
        {
            Account = new ClientAccount();
        }
    }
}
