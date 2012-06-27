﻿/*
 * Copyright (c) Dominick Baier & Brock Allen.  All rights reserved.
 * see license.txt
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thinktecture.IdentityModel.Http.Cors.Mvc
{
    public static class MvcCorsConfiguration
    {
        static MvcCorsConfiguration()
        {
            ResourceNameIncludesActionName = true;
            Configuration = new CorsConfiguration();
        }

        public static CorsConfiguration Configuration { get; set; }
        public static bool ResourceNameIncludesActionName { get; set; }
    }
}
