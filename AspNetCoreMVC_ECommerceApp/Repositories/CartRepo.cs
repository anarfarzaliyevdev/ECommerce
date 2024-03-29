﻿using AspNetCoreMVC_ECommerceApp.Abstractions;
using AspNetCoreMVC_ECommerceApp.Contexts;
using ECommerce_API.Models;
using ECommerce_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMVC_ECommerceApp.Repositories
{
    public class CartRepo:GeneralRepo<Cart>,ICartRepo
    {
        public CartRepo(AppDbContext context)
            :base(context)
        {

        }
    }
}
