﻿using ProniaFrontToBack.Models;

namespace ProniaFrontToBack.Areas.Manage.ViewModels.Product
{
    public record UpdateProductVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public List<int>? TagIds { get; set; }
        public IFormFile? MainPhoto { get; set; }
        public List<IFormFile>? Images { get; set; }
        public List<ProductImageVm>? productImages { get; set; }
        public List<string>? ImagesUrls { get; set; }

    }
    public record ProductImageVm
    {
        public string ImgUrl { get; set; }
        public bool Primary { get; set; }
    }
}
