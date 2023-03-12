using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Structural_Design_Pattern.Facade
{
    //this is the Facade or wrapper class. Client will be totall unaware of third party library
    public class VideoConverter
    {
        private string _fileName;
        public VideoConverter(string fileName)
        {
            _fileName = fileName;
        }

        public void Convert(string format)
        {
            VideoFile vFile = new VideoFile(_fileName);
            string fileStream = vFile.GetFileStream();

            Console.WriteLine(fileStream);

            string sourceCodec = (new CodecFactory()).Extract(fileStream);
            Console.WriteLine(sourceCodec);

            ConversionCodec conversionCodec = null;
            switch (format)
            {
                case "MP4":
                    conversionCodec = new MP4ConversionCodec();
                    break;
                case "FLV":
                    conversionCodec = new FLVConversionCodec();
                    break;
                default:
                    break;
            }

            string conversionValue;
            if(conversionCodec !=null)
            {
                conversionValue = conversionCodec.Convert(sourceCodec);
            }
            else
            {
                conversionValue = "Input format not supported";
            }

            Console.WriteLine(conversionValue);

        }
    }
}
