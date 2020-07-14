using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public interface IImageData
    {
        Task DeleteImage(ImageModel image);
        Task<List<ImageModel>> GetImages();
        Task InsertImage(ImageModel image);
        Task UpdateImage(ImageModel image);
    }
}