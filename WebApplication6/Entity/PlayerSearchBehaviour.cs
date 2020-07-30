using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication6.Entity
{
    public interface PlayerSearchBehaviour
    {
        List<Players> getPlayers(int Teamid, int playerType);
    }
}
