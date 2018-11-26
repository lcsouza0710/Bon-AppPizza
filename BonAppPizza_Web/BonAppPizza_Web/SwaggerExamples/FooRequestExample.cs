using System;
using BonAppPizza_Web.Models;
using Swashbuckle.AspNetCore.Filters;

namespace BonAppPizza_Web.SwaggerExamples
{
    public class FooRequestExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return new Foo
            {
                Id = new Random().Next(),
                Value = Guid.NewGuid().ToString().Remove(6)
            };
        }
    }
}