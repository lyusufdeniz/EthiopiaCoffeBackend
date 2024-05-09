﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthiopiaCoffe.Repository.DTOs.Category
{
    public record CategoryUpdateDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
    }
}