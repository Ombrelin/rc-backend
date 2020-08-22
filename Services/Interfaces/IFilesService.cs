using System;
using RencontreContemporainesAPI.Models;

namespace RencontreContemporainesAPI.Services.Interfaces
{
    public interface IFilesService
    {
        Guid Upload(string fileName, byte[] fileData);
        DbFile Download(Guid fileId);
        void Delete(Guid fileId);
    }
}