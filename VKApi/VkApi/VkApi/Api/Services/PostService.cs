using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using VkApi.Api.Models;
using VkApi.Api.Services.Utils;
using VkApi.Constants;
using VkApi.TestData;

namespace VkApi.Api.Services
{
    public class PostService : Service
    {
        public PostService()
        {
        }

        public async Task<PostResponse> PostPostModelAsync(PostUrlParamsModel parameter)
        {
            RequestModel requestModel = new(ApiMethod.wallPost.GetEnumDescription(), parameter);
            Dictionary<string, string> urlParams = RequestUrlParamsModelParser.Parse(requestModel.RequestUrlParams);
            FormUrlEncodedContent httpContent = new(urlParams);
            HttpResponseMessage result = await _httpClient.PostAsync($"{requestModel.Method}", httpContent);

            return JsonManager.GetResposeBody(await result.Content.ReadAsStringAsync());
        }

        public async Task<PostResponse> EditPostModelAsync(EditPostParamsModel parameter)
        {
            RequestModel requestModel = new(ApiMethod.wallEdit.GetEnumDescription(), parameter);
            Dictionary<string, string> urlParams = RequestUrlParamsModelParser.Parse(requestModel.RequestUrlParams);
            FormUrlEncodedContent httpContent = new(urlParams);
            HttpResponseMessage result = await _httpClient.PostAsync($"{requestModel.Method}", httpContent);

            return JsonManager.GetResposeBody(await result.Content.ReadAsStringAsync());
        }

        public async Task<CommentResponse> CreateCommentAsync(CommentParamsModel parameter)
        {
            RequestModel requestModel = new(ApiMethod.wallCreateComment.GetEnumDescription(), parameter);
            Dictionary<string, string> urlParams = RequestUrlParamsModelParser.Parse(requestModel.RequestUrlParams);
            FormUrlEncodedContent httpContent = new(urlParams);
            HttpResponseMessage result = await _httpClient.PostAsync($"{requestModel.Method}", httpContent);

            return JsonManager.GetCommentResposeBody(await result.Content.ReadAsStringAsync());
        }

        public async Task<LikeResponse> IsLikedAsync(LikeParamsModel parameter)
        {
            RequestModel requestModel = new(ApiMethod.likesIsLiked.GetEnumDescription(), parameter);
            Dictionary<string, string> urlParams = RequestUrlParamsModelParser.Parse(requestModel.RequestUrlParams);
            FormUrlEncodedContent httpContent = new(urlParams);
            HttpResponseMessage result = await _httpClient.PostAsync($"{requestModel.Method}", httpContent);

            return JsonManager.GetIsLikedResposeBody(await result.Content.ReadAsStringAsync());
        }

        public async Task<DeleteResponse> DeletePostAsync(DeleteParamsModel parameter)
        {
            RequestModel requestModel = new(ApiMethod.wallDelete.GetEnumDescription(), parameter);
            Dictionary<string, string> urlParams = RequestUrlParamsModelParser.Parse(requestModel.RequestUrlParams);
            FormUrlEncodedContent httpContent = new(urlParams);
            HttpResponseMessage result = await _httpClient.PostAsync($"{requestModel.Method}", httpContent);

            return JsonManager.GetDeleteResposeBody(await result.Content.ReadAsStringAsync());
        }
    }
}
