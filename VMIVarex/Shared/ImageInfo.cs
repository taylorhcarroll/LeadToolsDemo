using Leadtools;
using System;
using System.Collections.Generic;
using System.Text;

namespace VMIVarex.Shared
{
    class ImageInfo
    {
        //base class object
        public RasterImage Image;
        public string Title;

        //constructor method null values for when you need a placeholder
        public ImageInfo()
        {
            Image = null;
            Title = string.Empty;
        }

        //method specifying what it will take as image type
        public ImageInfo(RasterImage image, string title)
        {
            Image = image;
            Title = title;
        }
    }
}
