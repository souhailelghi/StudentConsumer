using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace StudentConsumerMicroservice.Services
{
    public class StudentService
    {
        private readonly HttpClient _httpClient;

        public StudentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

            public async Task<StudentDto> GetStudentDetailsAsync(string email, string password)
            {
                // Define the endpoint of the existing microservice
                var endpoint = $"http://localhost:5225/api/student/login?email={email}&password={password}";

                // Send the HTTP GET request
                var response = await _httpClient.GetAsync(endpoint);

                if (!response.IsSuccessStatusCode)
                {
                    return null;  // Handle the case when the external service returns an error
                }   

                // Parse the response
                var responseContent = await response.Content.ReadAsStringAsync();
                var studentDetails = JsonConvert.DeserializeObject<StudentDto>(responseContent);

                return studentDetails;
            }
    }

    // Data Transfer Object (DTO) to represent the student details
    public class StudentDto
    {
        public string CodeUIR { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
