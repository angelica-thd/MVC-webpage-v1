﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class PartialClasses
    {
        [MetadataType(typeof(salesMetadata))]
        public partial class sale
        {
        }
    }
}