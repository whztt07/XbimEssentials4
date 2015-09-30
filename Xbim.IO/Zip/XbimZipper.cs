using System;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace Xbim.IO.Zip
{
    public class XbimZipper
    {
        //public void Zip(Stream outputStream, string innerName, Action<Stream> innerWriter)
        //{
        //    using (var archive = new ZipArchive(outputStream, ZipArchiveMode.Create))
        //    {
        //        var entry = archive.CreateEntry(innerName);
        //        using (var entryStream = entry.Open())
        //        {
        //            innerWriter(entryStream);
        //            entryStream.Close();
        //        }
        //    }
        //}

        //public void Unzip(Stream inputStream, Action<Stream> innerReader, string innerExtension = null)
        //{
        //    using (var archive = new ZipArchive(inputStream, ZipArchiveMode.Read))
        //    {
        //        var entry = innerExtension == null
        //            ? archive.Entries.FirstOrDefault()
        //            : archive.Entries.FirstOrDefault(
        //                e => e.Name.ToLowerInvariant().EndsWith(innerExtension.ToLowerInvariant()));
        //        if (entry == null) return;
        //        using (var entryStream = entry.Open())
        //        {
        //            innerReader(entryStream);
        //            entryStream.Close();
        //        }
        //    }
        //}
    }
}
