using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Options;

namespace CloudinaryStorage;

public interface ICloudinaryStorageService
{
    Task<DeletionResult> DeleteImg(string publicId);

    Task<ImageUploadResult> UploadImg();
}

public class CloudinaryStorageService : ICloudinaryStorageService
{
    private readonly Cloudinary _cloudinary;
    private readonly CloudinarySettings _cloudinarySettings;

    public CloudinaryStorageService(IOptions<CloudinarySettings> options)
    {
        _cloudinarySettings = options.Value;

        var account = new Account
        {
            Cloud = _cloudinarySettings.CloudName,
            ApiKey = _cloudinarySettings.ApiKey,
            ApiSecret = _cloudinarySettings.ApiSecret,
        };

        _cloudinary = new Cloudinary(account);
    }

    public async Task<ImageUploadResult> UploadImg()
    {
        var imageUploadParams = new ImageUploadParams
        {
        };

        var uploadResult = await _cloudinary.UploadAsync(imageUploadParams);

        return uploadResult;
    }

    public async Task<DeletionResult> DeleteImg(string publicId)
    {
        var deleteParams = new DeletionParams(publicId);

        var result = await _cloudinary.DestroyAsync(deleteParams);

        return result;
    }
}