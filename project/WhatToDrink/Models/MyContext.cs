using Microsoft.EntityFrameworkCore;

namespace WhatToDrink.Models
{
    public class MyContext: DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
    }
}