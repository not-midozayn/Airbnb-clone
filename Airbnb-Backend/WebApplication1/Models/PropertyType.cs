﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class PropertyType
{
    public int Id { get; set; }

    public string PropertyTypeName { get; set; }

    public virtual ICollection<Listing> Listings { get; set; } = new List<Listing>();
}