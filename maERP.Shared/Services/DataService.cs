﻿#nullable disable

using System.Net.Http.Headers;
using System.Net.Http.Json;
using Newtonsoft.Json;
using maERP.Shared.Dtos.User;
using maERP.Shared.Contracts;

namespace maERP.Shared.Services
{
    public class DataService<T> : IDataService<T> where T : class
    {
        public async Task<LoginResponseDto> Login(string server, string email, string password)
        {
            using (var client = new HttpClient())
            {
                string requestUrl = server + "/api/Users/login";
                client.Timeout = TimeSpan.FromSeconds(Convert.ToDouble(1000));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var loginData = new Dictionary<string, string>
                {
                    {"email", email},
                    {"password", password}
                };

                HttpResponseMessage response = new HttpResponseMessage();
                response = await client.PostAsJsonAsync(requestUrl, loginData); // .ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    response.Dispose();

                    var responseObj = JsonConvert.DeserializeObject<LoginResponseDto>(result);

                    maERP.Shared.Globals.ServerBaseUrl = server;

                    LoginResponseDto loginDto = new LoginResponseDto
                    {
                        Succeeded = true,
                        Token = responseObj?.Token
                    };

                    return loginDto;
                }

                response.Dispose();
                return null;
            }
        }

        public async Task<T> Request(string method, string path, object payload = null)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string requestUrl = maERP.Shared.Globals.ServerBaseUrl + "/api" + path;
                    // string accessToken = Preferences.Default.Get<string>("oauth_token", "null");
                    string accessToken = maERP.Shared.Globals.AccessToken;
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                    client.Timeout = TimeSpan.FromSeconds(Convert.ToDouble(1000));

                    HttpResponseMessage response = new HttpResponseMessage();

                    if (method == "GET")
                    {
                        response = await client.GetAsync(requestUrl).ConfigureAwait(false);

                    }
                    else if (method == "POST")
                    {
                        response = await client.PostAsJsonAsync(requestUrl, payload).ConfigureAwait(false);
                    }
                    else if (method == "PUT")
                    {
                        response = await client.PutAsJsonAsync(requestUrl, payload).ConfigureAwait(false);
                    }
                    else if (method == "DELETE")
                    {
                        response = await client.DeleteAsync(requestUrl).ConfigureAwait(false);
                    }
                    else
                    {
                        throw new Exception();
                    }

                    if (response.IsSuccessStatusCode)
                    {
                        string result = response.Content.ReadAsStringAsync().Result;

                        try
                        {
                            var responseObj = JsonConvert.DeserializeObject<T>(result);
                            response.Dispose();

                            return responseObj;
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        throw new Exception();
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        Console.WriteLine("Not Found");
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        Console.WriteLine("Not Authorized");
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            throw new Exception();
        }
    }
}