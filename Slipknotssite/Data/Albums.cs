using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Slipknotssite.Controllers
{
    public class Albums
    {
       
            public int Id { get; set; }

            public string Name { get; set; }

            public string Description { get; set; }

    }
}
