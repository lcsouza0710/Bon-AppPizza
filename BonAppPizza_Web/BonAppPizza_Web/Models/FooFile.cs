﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace BonAppPizza_Web.Models
{
    public class FooFile : Foo
    {
        /// <summary>
        /// Gets or set the file content.
        /// </summary>
        public IFormFile File { get; set; }
    }
}