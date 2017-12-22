using FacultyManager.Applicatiion.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FacultyManager.Applicatiion;

namespace FacultyManager.Applicatiion.Services
{
    public class ApiService
    {
        private ErrorDescriber describer = new ErrorDescriber();

        public async Task<DataResult<TResponse>> GetAsync<TResponse>(string action, Dictionary<string, string> parameters = null)
        {
            if (parameters != null)
            {
                var content = new FormUrlEncodedContent(parameters);
                action += "?" + await content.ReadAsStringAsync();
            }

            var response = await App.HttpClient.GetAsync(action);

            return await DeserializeResponse<TResponse>(response);
        }

        public async Task<DataResult<TResponse>> PostAsync<TResponse, TParam>(string url, TParam properties)
        {
            var postProperties = UrlPropertyConverter.MappingToDictionary(properties);
            var content = new FormUrlEncodedContent(postProperties);
            var response = await App.HttpClient.PostAsync(url, content);
            var responseResult = await DeserializeResponse<TResponse>(response);

            return responseResult;
        }

        private async Task<DataResult<T>> DeserializeResponse<T>(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                return DataResult<T>.Failed(describer.RequestError(response.StatusCode.ToString(), response.Content.ToString()));
            }

            var jsonString = await response.Content.ReadAsStringAsync();

            if (jsonString.Contains("error"))
            {
                return DataResult<T>.Failed(describer.RequestError(response.StatusCode.ToString(), jsonString));
            }

            var data = JsonConvert.DeserializeObject<T>(jsonString);

            return DataResult<T>.Success(data);
        }
    }
}
