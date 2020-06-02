using System;
using System.Windows.Forms;
using System.Text;
using System.Drawing;
using System.Collections.Generic;

using Leadtools;
using Leadtools.Codecs;
using Leadtools.WinForms.CommonDialogs.File;
using System.IO.Enumeration;
using System.Runtime.InteropServices.ComTypes;

namespace VMIVarex.Shared
{
    class ImageFileLoader
    {

        private static int _filterIndex = 1;
        private string _fileName;
        private RasterImage _image;
        private RasterOpenDialogLoadFormat[] _filters;

        //CodecsImageInfo info = rasterCodecs.GetInformation(stream, true);
        //RasterImage image = rasterCodecs.Load(stream, 1);

        //CodecsImageInfo info = rasterCodecs.GetInformation("file.vmi", true);
        //RasterImage image = rasterCodecs.Load("file.vmi", 1);

        //constructor method
        public ImageFileLoader()
        {
        }

        private List<ImageInfo> _images = new List<ImageInfo>();

        public string FileName
        {
            get
            {
                return _fileName;
            }
            set
            {
                _fileName = value;
            }
        }
        
        public RasterImage Image
        {
            get
            {
                return _image;
            }
        }

        public List<ImageInfo> Images
        {
            get
            {
                return _images;
            }
        }




    }
}
