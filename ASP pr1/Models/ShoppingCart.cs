using System.Runtime.InteropServices;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;

namespace ASP_pr1
{
    public class ShoppingCart
    {
        public int ProductId { get; set; }
        public bool ExistsInCart { get; set; }
    }
}
