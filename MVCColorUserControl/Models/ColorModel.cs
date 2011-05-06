using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MVCColorUserControl.Managers;

namespace MVCColorUserControl.Models
{
    public class ColorModel
    {
        private int _id = IdManager.GetNextId();
        public int Id { get { return _id; } }

        private string _rgbColor;
        [Required(ErrorMessage = "Please enter an HTML hex color, for example: #FFAA00.")]
        public string RGBColor
        {
            get
            {
                return _rgbColor;
            }
            set
            {
                _rgbColor = value;

                // Ensure a hash is at front of hex color.
                if (value.IndexOf("#") != 0)
                {
                    _rgbColor = _rgbColor.Insert(0, "#");
                }
            }
        }

        public int Width { get; set; }
        public int Height { get; set; }

        public ColorModel()
        {
        }
    }
}