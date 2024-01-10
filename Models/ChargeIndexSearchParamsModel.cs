﻿namespace Service_Billing.Models
{
    public class ChargeIndexSearchParamsModel
    {
        public string? QuarterFilter { get; set; }
        public string? MinistryFilter { get; set; }
        public string? TitleFilter { get; set; }
        public int? CategoryFilter { get; set; }
        public string? AuthorityFilter { get; set; }
        public int? ClientNumber {  get; set; }
        public string? Keyword {  get; set; }
        public bool? Inactive { get; set; } = false;
        public bool ShouldRestrictToUserOwnedServices { get; set; }
        public string QuarterString {  get; set; } = string.Empty;
    }
}
