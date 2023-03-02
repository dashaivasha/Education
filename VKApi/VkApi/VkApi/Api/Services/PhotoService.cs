using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VkApi.Api.Models;
using VkApi.Api.Models.ResponseModels;
using VkApi.Api.Services.Utils;
using VkApi.Constants;
using VkApi.TestData;

namespace VkApi.Api.Services
{
    public class PhotoService : Service
    {
        public PhotoService()
        {
        }

        public async Task<UploadServerResponseModel> GetUploadServer(UploadServerModel parameter)
        {
            var requestModel = new RequestModel(ApiMethod.photoGetWallUploadServer.GetEnumDescription(), parameter);
            Dictionary<string, string> urlParams = RequestUrlParamsModelParser.Parse(requestModel.RequestUrlParams);
            string url = UrlUtils.ConstructUrl(urlParams);
            HttpResponseMessage result = await _httpClient.GetAsync($"{requestModel.Method}?{url}");

            return JsonManager.GetUploadServereResposeBody(await result.Content.ReadAsStringAsync());

        }

        public async Task<UploadPhotoResponse> UploadPhotoToServer(string UploadUrl)
        {
            var fileStream = File.OpenRead(FilePaths.PhotoPath);
            MultipartFormDataContent requestContent = new MultipartFormDataContent();
            requestContent.Add(new StreamContent(fileStream), "photo", Path.GetFileName(FilePaths.PhotoPath));
            HttpResponseMessage result = await _httpClient.PostAsync(UploadUrl, requestContent);
            byte[] bytes = await result.Content.ReadAsByteArrayAsync();
            Encoding encoding = Encoding.GetEncoding("latin1");
            string responseString = encoding.GetString(bytes, index: 0, bytes.Length);

            return JsonManager.GetUploadPhotoResponseBody(responseString);
        }

        public async Task<SaveResponseModel> PostSaveWallPhoto(SavePhotoModel parameter)
        {
            RequestModel requestModel = new RequestModel(ApiMethod.photosSaveWallPhoto.GetEnumDescription(), parameter);
            Dictionary<string, string> urlParams = RequestUrlParamsModelParser.Parse(requestModel.RequestUrlParams);
            FormUrlEncodedContent httpContent = new(urlParams);
            HttpResponseMessage result = await _httpClient.PostAsync($"{requestModel.Method}", httpContent);

            return JsonManager.GetSaveResponseModeleBody(await result.Content.ReadAsStringAsync());
        }
    }
}