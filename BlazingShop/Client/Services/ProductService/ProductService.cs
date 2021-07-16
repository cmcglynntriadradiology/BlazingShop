using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void LoadProducts()
        {
            Products = new List<Product> {
            new Product
            {
                Id = 1,
                CategoryId = 1,
                Title = "The Hitchhiker's Guide to the Galexy",
                Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 video game, and 2005 feature film.",
                Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                Price = 9.99m,
                OriginalPrice = 19.99m,
            },
        new Product
        {
            Id = 2,
            CategoryId = 3,
            Title = "Half-Life 2",
            Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life (1998), it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay. Set roughly twenty years after the first game, players control Gordon Freeman as he joins a resistance movement to liberate the Earth from the control of an alien empire called the Combine.",
            Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
            Price = 8.19m,
            OriginalPrice = 29.99m
        }
        };
        }
    }
}
