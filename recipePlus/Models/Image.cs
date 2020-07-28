using System;

namespace recipePlus.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string ImageTitle { get; set; }
        public byte[] ImageData { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }

    public class ImageViewModel
    {
        public int Id { get; set; }
        public string ImageTitle { get; set; }
        public byte[] ImageData { get; set; }

        public int RecipeId { get; set; }

        public string ImageUrl
        {
            get
            {
                string imageBase64Data = Convert.ToBase64String(this.ImageData);
                return string.Format("data:image/jpg;base64,{0}", imageBase64Data);
            }
        }
    }

}
