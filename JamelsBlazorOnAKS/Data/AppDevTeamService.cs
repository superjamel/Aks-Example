using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JamelsBlazorOnAKS.Data
{
    public class AppDevTeamService
    {
        private static readonly string[] FirstName = new[]
        {
            "Olga","Caroline", "Dennis", "Jamel", "Jelle"
        };

        private static readonly string[] LastName = new[]
        {
            "Lastname 1","Lastname 2", "Lastname 3", "Lastname 4", "Lastname 5"
        };

        public Task<AppDevMember[]> GetAppDevMembers()
        {
            var listAppDev = new List<AppDevMember>();
            for (int i = 0; i < FirstName.Length; i++)
            {
                AppDevMember member = new AppDevMember();
                member.Name = FirstName[i];
                member.LastName = LastName[i];
                member.Role = "App Dev Specialist";
                listAppDev.Add(member);
            }
            return Task.FromResult(listAppDev.ToArray());
        }
    }
}
