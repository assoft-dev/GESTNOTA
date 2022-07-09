using INota.Controllers.Helps;
using INota.Controllers.Interfaces;
using INota.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace INota.Controllers.Repository
{
    public class Repository : IRepository<Documento>
    {
        public string Urlbase { get { return "https://api.enotasgw.com.br/v2/empresas"; } }
        public string Token { get; set; }

        public Repository()
        {

        }
        public async Task<Response> PostAsync(Guid empresaId, Documento documento)
        {
            try
            {
                var strJson = JsonConvert.SerializeObject(documento);
                var strContent = new StringContent(strJson, Encoding.UTF8, "application/json");

                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Clear();
                    httpClient.DefaultRequestHeaders.Add("Authorization", string.Format("Basic {0}", Token));
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    using (var request = new HttpRequestMessage(HttpMethod.Post, 
                                                                string.Format("{0}/{1}/nfc-e", Urlbase, empresaId)))
                    {
                        request.Content = strContent;

                        using (var response = httpClient.SendAsync(request).Result)
                        {
                            var resultContent = await response.Content.ReadAsStringAsync();

                            if (response.IsSuccessStatusCode)
                            {
                                var list = JsonConvert.DeserializeObject<List<Documento>>(resultContent);
                                return new Response
                                {
                                    IsSuccess = true,
                                    Result = list
                                };
                            }
                            else
                            {
                                return new Response
                                {
                                    IsSuccess = false,
                                    Message = ((int)response.StatusCode) + " - " + response.ReasonPhrase,
                                };
                            }
                        }
                    }
                }
            } 
            catch (Exception exe)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = exe.Message
                };
            }
        }

        public async Task<Response> GetListAsync(Guid empresaId, string documento)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Clear();
                    httpClient.DefaultRequestHeaders.Add("Authorization", string.Format("Basic {0}", Token));
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    using (var request = new HttpRequestMessage(HttpMethod.Get,
                                                                string.Format("{0}/{1}/nfc-e/{2}", Urlbase, empresaId, documento)))
                    {
                        using (var response = await httpClient.SendAsync(request))
                        {
                            var resultContent = await response.Content.ReadAsStringAsync();

                            if (response.IsSuccessStatusCode)
                            {
                                var list = JsonConvert.DeserializeObject<List<Documento>>(resultContent);
                                return new Response
                                {
                                    IsSuccess = true,
                                    Result = list
                                };
                            }
                            else
                            {
                                return new Response
                                {
                                    IsSuccess = false,
                                    Message = ((int)response.StatusCode) + " - " + response.ReasonPhrase,
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception exe)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = exe.Message
                };
            }
        }

        public async Task<Response> DeleteAsync(Guid empresaId, string documento)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Clear();
                    httpClient.DefaultRequestHeaders.Add("Authorization", string.Format("Basic {0}", Token));
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    using (var request = new HttpRequestMessage(HttpMethod.Delete,
                                                                string.Format("{0}/{1}/nfc-e/{2}", Urlbase, empresaId, documento)))
                    {
                        using (var response = await httpClient.SendAsync(request))
                        {
                            var resultContent = await response.Content.ReadAsStringAsync();

                            if (response.IsSuccessStatusCode)
                            {
                                var list = JsonConvert.DeserializeObject<List<Documento>>(resultContent);
                                return new Response
                                {
                                    IsSuccess = true,
                                    Result = list
                                };
                            }
                            else
                            {
                                return new Response
                                {
                                    IsSuccess = false,
                                    Message = ((int)response.StatusCode) + " - " + response.ReasonPhrase,
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception exe)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = exe.Message
                };
            }
        }
    }
}
