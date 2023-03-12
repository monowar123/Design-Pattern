using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Structural_Design_Pattern.Facade
{
    public class VideoFile
    {
        string _filePath;
        public VideoFile(string fileName)
        {
            _filePath = fileName;
        }

        public string GetFileStream()
        {
            return "Get File stream from file path";
        }
    }

    public class CodecFactory
    {
        public string Extract(string fileStream)
        {
            return "Get source codec from file stream";
        }
    }

    public interface ConversionCodec
    {
        string Convert(string SourceCodec);
    }

    public class MP4ConversionCodec : ConversionCodec
    {
        public string Convert(string SourceCodec)
        {
            return "Converted to MP4";
        }
    }

    public class FLVConversionCodec : ConversionCodec
    {
        public string Convert(string SourceCodec)
        {
            return "Converted to FLV";
        }
    }
}
