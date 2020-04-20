namespace EstacionamientoNetCore.APIS
{
    using EstacionamientoEF.Entity;
    using EstacionamientoNetCore.ApiHelpers;
    using EstacionamientoNetCore.Factory;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class APIEmployee
    {
        private readonly HttpClient httpClient;


        public async Task<T> PostRequestAsync<T>(string actionPath, string content,
         RestHeaderParameter headerParam, CancellationTokenSource cancellationTokenSource, bool json)
        {
            HttpContent hc = new StringContent(content);
            if (json)
                hc.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            else
                hc.Headers.ContentType = new MediaTypeHeaderValue("application/xml");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, actionPath)
            {
                Content = hc
            };

            await Helpers.SetHeadersAsync(request, headerParam, json);

            if (cancellationTokenSource.IsCancellationRequested)
            {
                throw new TaskCanceledException("cancellationTokenSource alreday cancelled");
            }

            var httpResponseMessage = await this.httpClient.SendAsync(request, cancellationTokenSource.Token);

            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                // Unwrap the response and throw as an Api Exception:
                var ex = Helpers.CreateExceptionFromResponseErrors(httpResponseMessage);
                throw ex;
            }

            return await Helpers.DeserializeResponseAsync<T>(actionPath, httpResponseMessage, headerParam.UserId, json);
        }

        public static List<Auto> GetPay(string urlToken, string urlBase, string pathCertificate, string clientID, string clientSecret, string grantType, string usuario, string country, string nro_venta, string rut, string monto, string app)
        {
           
            string importe = Convert.ToInt64(Math.Round(Convert.ToDouble(monto))).ToString();
            int index = rut.IndexOf('-');
            string rut_sin_guion = index > 0 ? rut.Substring(0, index) + rut.Substring(index + 1, rut.Length - (index + 1)) : rut;
            Empleado request = new Empleado();
            Auto response = new Auto();
            List<Auto> listAuto = new List<Auto>();
            try
            {
                Uri url = new Uri(urlBase);

                var cert = FindCertificateByThumbprint("1A7201E21CA93CAFED9FDCD1736716F606A22651");

                using (var certHandler = HttpMessageHandlerFactory.Create(cert))
                using (var client = new HttpClient(certHandler))
                {
                    client.DefaultRequestHeaders.Add("Metadata-UserId", usuario);
                    client.DefaultRequestHeaders.Add("Metadata-SenderCountry", country);
                    client.DefaultRequestHeaders.Add("Metadata-RequestId", new Random().Next(999999).ToString(CultureInfo.InvariantCulture));
                    client.DefaultRequestHeaders.Add("Metadata-SystemId", app);
                    client.DefaultRequestHeaders.Add("Metadata-SenderBusinessScope", "SDS");

                    var Content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

                    var result = client.PostAsync(url, Content).Result;

                    if (result.IsSuccessStatusCode)
                    {
                        response = JsonConvert.DeserializeObject<Auto>(result.Content.ReadAsStringAsync().Result);
                    }
                    else
                    {
                        string resultJson = result.Content.ReadAsStringAsync().Result;                        
                    }
                }
                listAuto.Add(response);
                return listAuto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static X509Certificate2 FindCertificateByThumbprint(string findValue)
        {
            var store = new X509Store(StoreName.My, StoreLocation.CurrentUser);

            try
            {
                store.Open(OpenFlags.ReadOnly);
                var col = store.Certificates.Find(X509FindType.FindByThumbprint, findValue, false);
                return col[0];
            }
            finally
            {
                store.Close();
            }
        }
    }
}
