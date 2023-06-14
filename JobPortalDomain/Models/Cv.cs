using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JobPortalDomain.Models;

public class Cv
{
    public int Id { get; set; }
    [Display(Name = "Upload your CV")]
    public string Name { get; set; }
    public string ContentType { get; set; }
    public byte[] Data { get; set; }

    public Cv(int id, string name, string contentType, byte[] data)
    {
        Id = id;
        Name = name;
        ContentType = contentType;
        Data = data;
    }
    public Cv(string name, string contentType, byte[] data)
    {
        Name = name;
        ContentType = contentType;
        Data = data;
    }
    public Cv(int id, string contentType)
    {
        Id = id;
        ContentType = contentType;
    }

    public Cv() { }

    public FileContentResult ToFileContentResult()
    {
        return new FileContentResult(Data, ContentType)
        {
            FileDownloadName = Name
        };
    }
}
