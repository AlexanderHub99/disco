using System.Collections.Generic;

namespace MyFirstApplication.Models
{

    public static class Repository
    {
        private static List<GuesResponse> _responses = new List<GuesResponse>();

        public static IEnumerable<GuesResponse> Responses => _responses;

        public static void AddResponse(GuesResponse response)
        {
            _responses.Add(response);
        }
    }
}