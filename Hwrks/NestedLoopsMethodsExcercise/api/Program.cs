var client = new HttpClient();
var request = new HttpRequestMessage(HttpMethod.Post, "https://www.google-analytics.com/collect");
var response = await client.SendAsync(request);
response.EnsureSuccessStatusCode();
Console.WriteLine(await response.Content.ReadAsStringAsync());
