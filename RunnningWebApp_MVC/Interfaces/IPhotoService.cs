using CloudinaryDotNet.Actions;
using System.Security.Cryptography.X509Certificates;

namespace RunnningWebApp_MVC.Interfaces
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> AddPhotoAsync(IFormFile file);
        Task<DeletionResult> DeletePhotoAsync(string publicId);
    }
}
