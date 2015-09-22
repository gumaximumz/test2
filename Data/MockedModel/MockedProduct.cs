using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.MockedModel
{
    public class MockedProduct
    {
        public static Product[] Objects
        {
            get {
                Product[] models = new Product[]
                {
                    new Product() {
                    Id = 1,
                    Name = "AB",
                    ProductType = new ProductType() {
                        Id = 1,
                        Name = "Type1"
                       }

                    },
                    new Product() {
                    Id = 2,
                    Name = "BA",
                    ProductType = new ProductType() {
                        Id = 2,
                        Name = "Type2"
                       }

                    },
                    new Product() {
                    Id = 3,
                    Name = "ABB",
                    ProductType = new ProductType() {
                        Id = 3,
                        Name = "Type3"
                       }

                    },
                    new Product() {
                    Id = 4,
                    Name = "ABFF",
                    ProductType = new ProductType() {
                        Id = 4,
                        Name = "Type1"
                       }

                    },
                    new Product() {
                    Id = 5,
                    Name = "DC",
                    ProductType = new ProductType() {
                        Id = 5,
                        Name = "Type1"
                       }

                    },
                    new Product() {
                    Id = 6,
                    Name = "FFF",
                    ProductType = new ProductType() {
                        Id = 6,
                        Name = "Type1"
                       }

                    },
                    new Product() {
                    Id = 7,
                    Name = "ASDQ",
                    ProductType = new ProductType() {
                        Id = 7,
                        Name = "Type2"
                       }

                    },
                    new Product() {
                    Id = 8,
                    Name = "WASD",
                    ProductType = new ProductType() {
                        Id = 8,
                        Name = "Type2"
                       }

                    },
                    new Product() {
                    Id = 9,
                    Name = "ABGG",
                    ProductType = new ProductType() {
                        Id = 9,
                        Name = "Type4"
                       }

                    },
                    new Product() {
                    Id = 10,
                    Name = "BBBB",
                    ProductType = new ProductType() {
                        Id = 10,
                        Name = "Type3"
                       }

                    },
                    new Product() {
                    Id = 11,
                    Name = "TTT",
                    ProductType = new ProductType() {
                        Id = 11,
                        Name = "Type4"
                       }

                    },
                    new Product() {
                    Id = 12,
                    Name = "AB",
                    ProductType = new ProductType() {
                        Id = 12,
                        Name = "Type2"
                       }

                    }

                };

                return models;
                   

            }
        }
    }
}
