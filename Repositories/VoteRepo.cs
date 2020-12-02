using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoterService.Models;

namespace VoterService.Repositories
{
    public class VoteRepo : IVoteRepository
    {
        private static  List<Vote> votes = new List<Vote>()
        {
            new Vote(){VoteID = 1,VoterID = 1,ContenderID = 3},
            new Vote(){VoteID = 2,VoterID = 2,ContenderID = 1},
            new Vote(){VoteID = 3,VoterID = 3,ContenderID = 3},
            new Vote(){VoteID = 4,VoterID = 4,ContenderID = 2}
        };
        public bool CastVote(Vote vote)
        {
            try
            {
                vote.VoteID = votes.Count + 1;
                votes.Add(vote);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
