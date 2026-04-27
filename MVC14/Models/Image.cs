using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC14.Models;

public partial class Image
{
    [Display(Name = "ID Hình Ảnh")]
    public int ImageId { get; set; }

    [Display(Name = "URL Hình Ảnh")]
    [DataType(DataType.Url)]
    [Url(ErrorMessage = "URL không hợp lệ")]
    public string? ImageUrl { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
