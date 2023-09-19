using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DrMuscleTest.Helpers
{
    public static class ImageHelper
    {
        /// <summary>
        /// Method to return FileImageSource from file
        /// </summary>
        /// <param name="fileName">Takes in fileName</param>
        /// <returns>FileImageSource</returns>
        public static FileImageSource ReturnImageSourceFromFile(string fileName)
        {
            return new FileImageSource { File = new FileImageSource { File = fileName } };
        }
    }
}
