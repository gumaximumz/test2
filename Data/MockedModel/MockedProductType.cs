﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.MockedModel
{
    public class MockedProductType
    {
        public static ProductType[] Objects
        {
            get
            {
                ProductType[] model = new ProductType[]
                    {
                        new ProductType() { Id = 1, Name = "Type1" },
                        new ProductType() { Id = 2, Name = "Type2" },
                        new ProductType() { Id = 3, Name = "Type3" },
                        new ProductType() { Id = 4, Name = "Type4" }
                    };
                return model;
            }

        }
    }
}
