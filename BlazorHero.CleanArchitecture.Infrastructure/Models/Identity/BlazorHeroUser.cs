﻿using BlazorHero.CleanArchitecture.Application.Contracts;
using Microsoft.AspNetCore.Identity;
using System;

namespace BlazorHero.CleanArchitecture.Infrastructure.Models.Identity
{
    public class BlazorHeroUser : IdentityUser, IAuditableEntity, IDeletableEntity
    {
        public BlazorHeroUser()
        {
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime? LastModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}