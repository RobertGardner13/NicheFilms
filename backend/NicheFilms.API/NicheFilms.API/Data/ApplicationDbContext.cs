﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace NicheFilms.API.Data
{
public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
base(options)
        {

        }
}

}
