using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BrentBindewaldCPT206Lab5.Models;
using StudentProfileWebApi.Models;


namespace BrentBindewaldCPT206Lab5.Services
{
    public class StudentProfileService
    {
        private readonly HttpClient _httpClient;

        public StudentProfileService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<StudentProfile>> GetStudentProfilesAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<StudentProfile>>("api/StudentProfiles");
        }
    }
}
